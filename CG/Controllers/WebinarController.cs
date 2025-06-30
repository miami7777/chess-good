using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using CG.Controllers;
using CG.Domain;
using CG.Models.Enum;
using CG.Models;

namespace CG.Controllers
{
    public class WebinarController : Controller
    {
        private readonly IStringLocalizer<CourseController> _localizer;
        private readonly ILogger<CoursesController> _logger;
        private readonly DataManager _dataManager;

        public WebinarController(IStringLocalizer<CourseController> localizer, ILogger<CoursesController> logger, DataManager dataManager)
        {
            _localizer = localizer;
            _logger = logger;
            _dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<FileResult> DownloadThumb(int id, int height, int width)
        {
            try
            {
                var file = await _dataManager.webinarFilesRepositories.GetWebinarFilesByIdAsync(id);

                if (file?.FileContent != null)
                {
                    try
                    {
                        #region SkiaSharp
                        using MemoryStream ms = new MemoryStream(file.FileContent);
                        using SkiaSharp.SKBitmap sourceBitmap = SkiaSharp.SKBitmap.Decode(ms);

                        int sheight = height > 0 ? Math.Min(height, sourceBitmap.Height) : sourceBitmap.Height;
                        int swidth = width > 0 ? Math.Min(width, sourceBitmap.Width) : sourceBitmap.Width;

                        using SkiaSharp.SKBitmap scaledBitmap = sourceBitmap.Resize(new SkiaSharp.SKImageInfo(swidth, sheight), SkiaSharp.SKFilterQuality.Medium);
                        using SkiaSharp.SKImage scaledImage = SkiaSharp.SKImage.FromBitmap(scaledBitmap);
                        using SkiaSharp.SKData data = scaledImage.Encode();
                        return File(data.ToArray(), string.IsNullOrEmpty(file.FileContentType) ? "application/unknown" : file.FileContentType, file.FileName);
                        #endregion

                    }
                    catch (Exception ex)
                    {
                        #region System.Drawing
                        Stream imageStream = new MemoryStream(file.FileContent);
                        System.Drawing.Image fullImage = System.Drawing.Image.FromStream(imageStream);

                        int thumbHeight = height;
                        int thumbWidth = fullImage.Width * thumbHeight / fullImage.Height;

                        if (fullImage.Height > fullImage.Width)
                        {
                            thumbHeight = height;
                            thumbWidth = fullImage.Width * thumbHeight / fullImage.Height;
                        }
                        else
                        {
                            thumbWidth = width;
                            thumbHeight = fullImage.Height * thumbWidth / fullImage.Width;
                        }

                        System.Drawing.Image thumbImage = fullImage.GetThumbnailImage(thumbWidth, thumbHeight, null, new IntPtr());
                        MemoryStream thumbStream = new MemoryStream();
                        thumbImage.Save(thumbStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                        return File(thumbStream.ToArray(), string.IsNullOrEmpty(file.FileContentType) ? "application/unknown" : file.FileContentType, file.FileName);
                        #endregion
                    }
                }
                else
                {
                    return File(new byte[0], "image/jpg", "empty.jpg");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Не удалось загрузить изображение {@id}", id);
                throw;
            }
        }
        private void GetLocalization()
        {
            var language = Request.Cookies["CultureInfo"];
            if (Request.RouteValues["language"] != null && Request.RouteValues["language"] != language)
                SetLanguage(Request.RouteValues["language"].ToString(), Request.GetDisplayUrl());
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
        private void GetHeaders()
        {
            SettingsViewModel settingsModel = new SettingsViewModel();
            settingsModel.settingsHeaders = new Dictionary<string, string>();
            settingsModel.menu = Enum.GetNames(typeof(HeaderMenu)).Cast<string>().ToList();
            settingsModel.footer_menu = Enum.GetNames(typeof(FooterMenu)).Cast<string>().ToList();
            settingsModel.service_menu = Enum.GetNames(typeof(ServiceMenu)).Cast<string>().ToList();
            foreach (var localResourse in _localizer.GetAllStrings())
            {
                settingsModel.settingsHeaders.Add(localResourse.Name, localResourse.Value);
            }
            ViewData["Headers"] = settingsModel;

        }
    }
}
