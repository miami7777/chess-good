using FFMpegCore;
using FFMpegCore.Pipes;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using SkiaSharp;
using CG.Areas.adm.Models;
using CG.Domain;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Helpers;
using CG.Models.Enum;
using CG.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CG.Areas.adm.Controllers
{
    public class CourseController : Controller
    {
        private readonly IStringLocalizer<CourseController> _localizer;
        private readonly DataManager _dataManager;

        public CourseController(DataManager dataManager, IStringLocalizer<CourseController> localizer)
        {
            _dataManager = dataManager;
            _localizer = localizer;
        }
        [Area("adm")]
        public async Task<IActionResult> Index(int id)
        {
            GetLocalization();
            GetDataHeaderline();
            var course = await _dataManager.courseRepositories.GetCourseByIdAsync(id);
            GetHeaders();
            return View(course);
        }
        [Area("adm")]
        public async Task<IActionResult> Card(int id)
        {
            GetLocalization();
            GetDataHeaderline();
            var course = await _dataManager.courseRepositories.GetCourseByIdAsync(id);
            GetHeaders();
            return View(course);
        }
        [Area("adm")]
        public async Task<IActionResult> CreateCourse()
        {
            GetLocalization();
            GetDataHeaderline();
            var course = new Course();           
            course.StartTimeCourse = DateTimeOffset.Now.ToLocalTime().Date;
            course.StartTimeCourse = course.StartTimeCourse.AddHours(DateTime.Now.ToLocalTime().Hour);
            course.StartTimeCourse = course.StartTimeCourse.AddMinutes(DateTime.Now.ToLocalTime().Minute);

            var categories = _dataManager.categoryRepositories.GetAllCategory();           
            ViewData["Categories"] = new SelectList(categories.ToList(),"ListOrder","Name");
            var clock = _dataManager.clockTournamentsRepositories.GetAllClockTournaments();
            ViewData["ClockTournaments"] = new SelectList(clock.ToList(), "Limit", "Name");
            return View(course);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> CreateCourse(Course addCourse)
        {            
            addCourse.StatusId = 1;            
            addCourse.TrainerId = GetCurrentUser().Id;  
            if (ModelState.IsValid)
            {
                await _dataManager.courseRepositories.SaveCourseAsync(addCourse);
            }
            return RedirectToAction("Courses", "Home");
        }
        [Area("adm")]
        public async Task<IActionResult> EditCourse(int id)
        {
            GetLocalization();
            GetDataHeaderline();
            var course = await _dataManager.courseRepositories.GetCourseByIdAsync(id);
            var categories = _dataManager.categoryRepositories.GetAllCategory();
            ViewData["Categories"] = new SelectList(categories.ToList(), "ListOrder", "Name");
            var clock = _dataManager.clockTournamentsRepositories.GetAllClockTournaments();
            ViewData["ClockTournaments"] = new SelectList(clock.ToList(), "Limit", "Name");
            var list = _dataManager.statusCoursesRepositories.GetStatusAsync();
            ViewData["StatusCourse"] = list.ToList();
            return View(course);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> EditCourse(Course editCourse)
        {
            if (ModelState.IsValid)
            {
                await _dataManager.courseRepositories.SaveCourseAsync(editCourse);
            }
            return RedirectToAction("Courses", "Home");
        }
        [Area("adm")]
        [HttpDelete("DeleteCourse/{id}")]
        public async Task<ActionResult> DeleteMyCourse(int id)
        {
            await _dataManager.courseRepositories.DeleteCourseAsync(id).ConfigureAwait(false);
            return Json(1);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> ChangeCourseKind(int courseId,TypeCourse type)
        {
            await _dataManager.courseRepositories.ChangeCourseKind(courseId, type);
            var course = await _dataManager.courseRepositories.GetCourseByIdAsync(courseId);
            return Json(new { rusName = EnumHelper.GetDescriptionEnum(course.TypeCourse), engName = course.TypeCourse });
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> ChangeCourseStatus(int courseId, int status)
        {
            await _dataManager.courseRepositories.ChangeCourseStatus(courseId, status);
            var course = await _dataManager.courseRepositories.GetCourseByIdAsync(courseId);
            return Json(course.DirectoryStatusCourses?.Name);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> AddChapter(Chapters chapter,int courseId)
        {
            Course course = await _dataManager.courseRepositories.GetCourseByIdAsync(courseId);
            if (ModelState.IsValid)
            {
                await _dataManager.chaptersRepositories.SaveChapterAsync(chapter);
                if (course.CourseDetails.Count == 0)
                {
                    course.CourseDetails = new List<CourseDetails>();
                }
                CourseDetails newCourseDetails = new CourseDetails() { ChapterId = chapter.Id, CourseId = courseId };
                course.CourseDetails.Add(newCourseDetails);
                await _dataManager.courseRepositories.SaveCourseAsync(course);
            }
            return RedirectToAction("EditCourse", "Course", new {id = course.Id});
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> EditChapter(Chapters chapter, int courseId,int chapterId)
        {
            Course course = await _dataManager.courseRepositories.GetCourseByIdAsync(courseId);
            Chapters editChapters = await _dataManager.chaptersRepositories.GetChapterByIdAsync(chapterId);
            if (editChapters != null)
            {
                chapter.ChapterPreviewId = editChapters.ChapterPreviewId;
                chapter.ChapterVideoId = editChapters.ChapterVideoId;
            }
            if (ModelState.IsValid)
            {
                var editChapter = await _dataManager.chaptersRepositories.GetChapterByIdAsync(chapterId);
                editChapter.Header = chapter.Header;
                editChapter.NavigationTitle = chapter.NavigationTitle;
                editChapter.Name = chapter.Name;
                editChapter.Description = chapter.Description;
                await _dataManager.chaptersRepositories.SaveChapterAsync(editChapter);
                
            }
            return RedirectToAction("EditCourse", "Course", new { id = course.Id });
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> DeleteChapter(int courseId, int chapterDeleteId)
        {
            Course course = await _dataManager.courseRepositories.GetCourseByIdAsync(courseId);
            var cd = course.CourseDetails.Where(x => x.ChapterId == chapterDeleteId && x.CourseId == courseId).FirstOrDefault();
            if (cd != null)
            {                
                await _dataManager.courseDetailsRepositories.DeleteCourseDetailsAsync(cd);
            }           
            return RedirectToAction("EditCourse", "Course", new { id = course.Id });
        }
        [Area("adm")]
        [HttpGet]
        public async Task<ActionResult> GetChapter(int courseId,int chapterId)
        {
            GetLocalization();            
            var course = await _dataManager.courseRepositories.GetCourseByIdAsync(courseId);
            var chapter = course.CourseDetails.FirstOrDefault(x => x.ChapterId == chapterId)?.Chapters;
            return Json(chapter != null ? new { Id = chapter.Id, NavigationTitle = chapter.NavigationTitle, Name = chapter.Name, Header = chapter.Header, Description = chapter.Description} : null);
        }
        [Area("adm")]
        public async Task<ActionResult> FileCourseUploadUniversal(string CourseId, TypeCourseFiles typeCourseFiles, int chapterId, string error)
        {
            if (error == "1")
            {
                return Json(0);
            }           
            int.TryParse(CourseId, out int courseIdAsInt);
            var preview = await _dataManager.courseFilesRepositories.GetCourseFilesByTypeAsync(typeCourseFiles, courseIdAsInt);
            var previewChapter = await _dataManager.chaptersRepositories.GetChapterByIdAsync(chapterId);
            try
            {
                CourseFiles file = new CourseFiles();
                if (preview.Count() > 0 && previewChapter == null)
                {
                    file = await preview.FirstOrDefaultAsync() ?? new CourseFiles();
                }
                var chapter = new Chapters();
                if (typeCourseFiles == TypeCourseFiles.PreviewChapter && chapterId != 0)
                {
                    chapter = await _dataManager.chaptersRepositories.GetChapterByIdAsync(chapterId);
                    if (chapter.ChapterPreviewId.HasValue)
                    {                        
                        file = await _dataManager.courseFilesRepositories.GetCourseFilesByIdAsync((int)chapter.ChapterPreviewId);
                    }
                }
                if (typeCourseFiles == TypeCourseFiles.ContentChapter && chapterId != 0)
                {
                    chapter = await _dataManager.chaptersRepositories.GetChapterByIdAsync(chapterId);
                    if (chapter.ChapterVideoId.HasValue)
                    {
                        file = await _dataManager.courseFilesRepositories.GetCourseFilesByIdAsync((int)chapter.ChapterVideoId);
                    }
                }
                foreach (UploadedFileInfo fileInfo in FileHelper.GetFilesFromRequest(HttpContext.Request))
                {                    
                    file.CreateDate = DateTime.Now;
                    file.FileName = fileInfo.FileName;                    
                    file.FileContentType = fileInfo.FileContentType;
                    file.FileContent = fileInfo.FileContent;
                    file.UserID = Convert.ToInt32(GetCurrentUser().Id);
                    file.CourseId = courseIdAsInt;
                    file.TypeCourseFiles = typeCourseFiles;
                    await _dataManager.courseFilesRepositories.SaveCourseFilesAsync(file); 
                    if (typeCourseFiles == TypeCourseFiles.PreviewChapter && chapterId != 0)
                    {                        
                        chapter.ChapterPreviewId = file.Id;
                        await _dataManager.chaptersRepositories.SaveChapterAsync(chapter);
                    }
                    if (typeCourseFiles == TypeCourseFiles.ContentChapter && chapterId != 0)
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
            return RedirectToAction("Courses", "Home");
        }
        [Area("adm")]
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
                throw;
            }
        }
        [Area("adm")]
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
