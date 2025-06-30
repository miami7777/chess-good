using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using CG.Domain;
using CG.Models.Enum;
using CG.Models;
using Microsoft.Extensions.Localization;
using CG.Helpers;

namespace CG.Controllers
{
    public class CourseController : Controller
    {
        private readonly IStringLocalizer<CourseController> _localizer;
        private readonly ILogger<CoursesController> _logger;
        private readonly DataManager _dataManager;

        public CourseController(ILogger<CoursesController> logger, DataManager dataManager, IStringLocalizer<CourseController> localizer)
        {
            _logger = logger;
            _dataManager = dataManager;
            _localizer = localizer;
        }        
        public async Task<IActionResult> Index(int id)
        {
            GetLocalization();
            var course = await _dataManager.courseRepositories.GetCourseByIdAsync(id);
            GetHeaders();
            return View(course);
        }
        public async Task<IActionResult> View(int id)
        {
            GetLocalization();
            var course = await _dataManager.courseRepositories.GetCourseByIdAsync(id);
            GetHeaders();
            if (course.TypeCourse == Domain.Enum.TypeCourse.Private)
            {
                return RedirectToAction("ViewPrivate",new {id = id});
            }
            return View(course);
        }
        public async Task<IActionResult> ViewPrivate(int id)
        {
            GetLocalization();
            var course = await _dataManager.courseRepositories.GetCourseByIdAsync(id);
            GetHeaders();            
            return View(course);
        }
        public async Task<FileResult> DownloadThumb(int id, int height, int width)
        {
            try
            {
                var file = await _dataManager.courseFilesRepositories.GetCourseFilesByIdAsync(id);

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
        public async Task<FileResult> DownloadVideo(int id, int height, int width)
        {
            try
            {
                var file = await _dataManager.courseFilesRepositories.GetCourseFilesByIdAsync(id);

                if (file?.FileContent != null)
                {
                    try
                    {

                        System.IO.File.WriteAllBytes("wwwroot/output.webm", file.FileContent);
                        var frames = FileHelper.CreateFrames(count: 150, width: 400, height: 300, file.FileContent);
                        //RawVideoPipeSource videoFramesSource = new(frames) { FrameRate = 30 };                       
                        //bool success = FFMpegArguments.FromPipeInput(videoFramesSource).OutputToFile("wwwroot/output.webm", overwrite: true, options => options.WithVideoCodec("libvpx-vp9")).ProcessSynchronously();
                        return File("output.webm", "application/unknown", "test");
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
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
