using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using CG.Domain.Entities;
using CG.Areas.adm.Models;
using CG.Domain;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Helpers;
using CG.Models;

namespace CG.Areas.adm.Controllers
{
    public class WebinarController : Controller
    {
        private readonly IStringLocalizer<CourseController> _localizer;
        private readonly DataManager _dataManager;

        public WebinarController(IStringLocalizer<CourseController> localizer, DataManager dataManager)
        {
            _localizer = localizer;
            _dataManager = dataManager;
        }
        [Area("adm")]
        // GET: WebinarsController
        public ActionResult Index()
        {
            GetLocalization();
            GetDataHeaderline();
            GetHeaders();
            return View();
        }
        [Area("adm")]
        // GET: WebinarsController/Details/5
        public ActionResult Card(int id)
        {
            GetLocalization();
            GetDataHeaderline();
            GetHeaders();
            return View();
        }
        [Area("adm")]
        // GET: WebinarsController/Create
        public ActionResult CreateWebinar()
        {
            GetLocalization();
            GetDataHeaderline();
            GetHeaders();
            return View();
        }
        [Area("adm")]
        // POST: WebinarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateWebinar(IFormCollection collection)
        {
            try
            {
                GetLocalization();
                GetDataHeaderline();
                GetHeaders();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [Area("adm")]
        // GET: WebinarsController/Edit/5
        public async Task<IActionResult> EditWebinar(int id)
        {
            GetLocalization();
            GetDataHeaderline();
            var webinar = await _dataManager.webinarRepositories.GetWebinarByIdAsync(id);
            var categories = _dataManager.categoryRepositories.GetAllCategory();
            ViewData["Categories"] = new SelectList(categories.ToList(), "ListOrder", "Name");
            var list = _dataManager.statusCoursesRepositories.GetStatusAsync();
            ViewData["StatusCourse"] = list.ToList();
            GetHeaders();
            return View(webinar);
        }
        [Area("adm")]
        // POST: WebinarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditWebinar(Webinar webinar)
        {
            if (ModelState.IsValid)
            {
                await _dataManager.webinarRepositories.SaveWebinarAsync(webinar);
            }
            return RedirectToAction("Webinars", "Home");
        }
        [Area("adm")]
        // GET: WebinarsController/Delete/5
        public ActionResult DeleteWebinar(int id)
        {
            return View();
        }
        [Area("adm")]
        // POST: WebinarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteWebinar(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> ChangeWebinarAccess(int webinarId, TypeCourse type)
        {
            await _dataManager.webinarRepositories.ChangeWebinarAccess(webinarId, type);
            var webinar = await _dataManager.webinarRepositories.GetWebinarByIdAsync(webinarId);
            return Json(new { rusName = EnumHelper.GetDescriptionEnum(webinar.TypeAccess), engName = webinar.TypeAccess });
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> ChangeWebinarKind(int webinarId, TypeWebinar type)
        {
            await _dataManager.webinarRepositories.ChangeWebinarKind(webinarId, type);
            var webinar = await _dataManager.webinarRepositories.GetWebinarByIdAsync(webinarId);
            return Json(new { rusName = EnumHelper.GetDescriptionEnum(webinar.TypeWebinar), engName = webinar.TypeWebinar });
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> ChangeWebinarStatus(int webinarId, int status)
        {
            await _dataManager.webinarRepositories.ChangeWebinarStatus(webinarId, status);
            var course = await _dataManager.webinarRepositories.GetWebinarByIdAsync(webinarId);
            return Json(course.DirectoryStatusCourses?.Name);
        }
        [Area("adm")]
        public async Task<ActionResult> FileWebinarUploadUniversal(string WebinarId, TypeWebinarFiles typeWebinarFiles, int chapterId, string error)
        {
            if (error == "1")
            {
                return Json(0);
            }
            int.TryParse(WebinarId, out int webinarIdAsInt);
            var preview = await _dataManager.webinarFilesRepositories.GetWebinarFilesByTypeAsync(typeWebinarFiles, webinarIdAsInt);
            var previewChapter = await _dataManager.chaptersRepositories.GetChapterByIdAsync(chapterId);
            try
            {
                WebinarFiles file = new WebinarFiles();
                if (preview.Count() > 0 && previewChapter == null)
                {
                    file = await preview.FirstOrDefaultAsync() ?? new WebinarFiles();
                }
                var chapter = new Chapters();
                if (typeWebinarFiles == TypeWebinarFiles.PreviewChapter && chapterId != 0)
                {
                    chapter = await _dataManager.chaptersRepositories.GetChapterByIdAsync(chapterId);
                    if (chapter.ChapterPreviewId.HasValue)
                    {
                        file = await _dataManager.webinarFilesRepositories.GetWebinarFilesByIdAsync((int)chapter.ChapterPreviewId);
                    }
                }
                if (typeWebinarFiles == TypeWebinarFiles.ContentChapter && chapterId != 0)
                {
                    chapter = await _dataManager.chaptersRepositories.GetChapterByIdAsync(chapterId);
                    if (chapter.ChapterVideoId.HasValue)
                    {
                        file = await _dataManager.webinarFilesRepositories.GetWebinarFilesByIdAsync((int)chapter.ChapterVideoId);
                    }
                }
                foreach (UploadedFileInfo fileInfo in FileHelper.GetFilesFromRequest(HttpContext.Request))
                {
                    file.CreateDate = DateTime.Now;
                    file.FileName = fileInfo.FileName;
                    file.FileContentType = fileInfo.FileContentType;
                    file.FileContent = fileInfo.FileContent;
                    file.UserID = Convert.ToInt32(GetCurrentUser().Id);
                    file.WebinarId = webinarIdAsInt;
                    file.TypeWebinarFiles = typeWebinarFiles;
                    await _dataManager.webinarFilesRepositories.SaveWebinarFilesAsync(file);
                    if (typeWebinarFiles == TypeWebinarFiles.PreviewChapter && chapterId != 0)
                    {
                        chapter.ChapterPreviewId = file.Id;
                        await _dataManager.chaptersRepositories.SaveChapterAsync(chapter);
                    }
                    if (typeWebinarFiles == TypeWebinarFiles.ContentChapter && chapterId != 0)
                    {
                        chapter.ChapterVideoId = file.Id;
                        await _dataManager.chaptersRepositories.SaveChapterAsync(chapter);
                    }
                }
            }
            catch (DbUpdateException e)
            {

            }
            catch (Exception ex)
            {

            }

            return Json(1);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> SavePreview(byte[] preview)
        {
            if (ModelState.IsValid)
            {

            }
            return RedirectToAction("Webinars", "Home");
        }

        [Area("adm")]
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
                throw;
            }
        }
        [Area("adm")]
        public async Task<FileResult> DownloadVideo(int id, int height, int width)
        {
            try
            {
                var file = await _dataManager.webinarFilesRepositories.GetWebinarFilesByIdAsync(id);

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
        private void GetLocalization()
        {
            var language = Request.Cookies["CultureInfo"];
            if (Request.RouteValues["language"] != null && Request.RouteValues["language"] != language)
                SetLanguage(Request.RouteValues["language"].ToString(), Request.GetDisplayUrl());
        }
        public void GetDataHeaderline()
        {
            var user = GetCurrentUser();
            ViewData["user"] = user;
            ViewData["avatar"] = user?.Avatar;
            ViewData["flag"] = user?.Country != null ? user?.Country.Substring(0, 2).ToLower() : null;
        }
        public ApplicationUser GetCurrentUser()
        {
            return _dataManager.userRepositories.GetUserByNameAsync(User.Identity.Name).Result;
        }
        private void GetHeaders()
        {
            SettingsViewModel settingsModel = new SettingsViewModel();
            settingsModel.settingsHeaders = new Dictionary<string, string>();
            try
            {
                foreach (var localResourse in _localizer.GetAllStrings())
                {
                    settingsModel.settingsHeaders.Add(localResourse.Name, localResourse.Value);
                }
                ViewData["Headers"] = settingsModel;
            }
            catch (Exception ex)
            {
                ViewData["Headers"] = settingsModel;
            }

        }
    }
}
