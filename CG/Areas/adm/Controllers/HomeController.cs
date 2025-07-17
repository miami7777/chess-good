using AutoMapper;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System;
using System.Data;
using CG.Domain.Entities;
using CG.Dto.RequestMessage;
using CG.Interfaces;
using CG.Models;
using CG.Models.Lichess;
using CG.Domain;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Extentions;
using CG.Helpers;
using CG.HttpServices.Interfaces;
using CG.Interfaces;
using CG.Models;
using CG.Services.Interfaces;
using CG.Areas.adm.Models;

namespace CG.Areas.adm.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpHelper _httpHelper;
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ILogger<HomeController> _logger;
        private readonly DataManager _dataManager;
        private readonly IMapper _mapper;
        private readonly ILichessIdentityServerHttpService _lichessIdentityServerHttpService;
        private readonly ILichessService _lichessService;
        private readonly IUserService _userService;
        private readonly IStateKeyCacheService _stateKeyCache;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public HomeController(ILogger<HomeController> logger, IHttpHelper httpHelper, DataManager dataManager, 
            ILichessIdentityServerHttpService lichessIdentityServerHttpService, ILichessService lichessService,
            IMapper mapper, IStringLocalizer<HomeController> localizer, IUserService userService,
            IStateKeyCacheService stateKeyCache, RoleManager<ApplicationRole> roleManager)
        {
            _localizer = localizer;
            _logger = logger;
            _dataManager = dataManager;  
            _mapper = mapper;        
            _httpHelper = httpHelper;
            _lichessIdentityServerHttpService = lichessIdentityServerHttpService;
            _lichessService = lichessService;
            _userService = userService;
            _stateKeyCache = stateKeyCache;
            _roleManager = roleManager;
        }

        [Area("adm")]
        public async Task<IActionResult> Index()
        {
            GetLocalization();
            GetDataHeaderline();
            var user = GetCurrentUser();
            var myActiveCourses = await _dataManager.courseRepositories.GetCoursesByTrainerId(user.Id,5).ToListAsync();
            var myActiveWebinars = await _dataManager.webinarRepositories.GetWebinarByTrainerId(user.Id, 5).ToListAsync();

            ViewData["MyCourses"] = myActiveCourses;
            ViewData["MyWebinars"] = myActiveWebinars;
            return View();
        }
        [Area("adm")]
        public async Task<IActionResult> Profile()
        {
            GetLocalization();
            var user = GetCurrentUser();
            var profile = _mapper.Map<UserViewModel>(user);
            var rolesEng = user.UserRoles.Select(x => x.Role.Name);
            var rolesRu = new List<string>();
            foreach (string role in rolesEng)
            {
                Enum.TryParse(role, out Role myRole);
                rolesRu.Add(EnumHelper.GetDescriptionEnum(myRole));
            }
            profile.Roles = String.Join(",", rolesRu);
            var courses = await _dataManager.courseRepositories.GetCourses().ToListAsync();
            var webinars  = await _dataManager.webinarRepositories.GetWebinar().ToListAsync();
            profile.CoursesCount = User.IsInRole("admin") ? courses.ToList().Count() : user.Courses.Count();
            profile.WebinarsCount = User.IsInRole("admin") ? webinars.ToList().Count() : user.Webinars.Count();
            var students = User.IsInRole("admin") ? await _dataManager.userRepositories.GetUsersAsync() : await _dataManager.userRepositories.GetStudentsByTrainerIdAsync(user.Id);
            var lessons = User.IsInRole("admin") ? _dataManager.lessonsRepositories.GetLessons() : _dataManager.lessonsRepositories.GetLessonsByTrainerId(user.Id);
            profile.StudentsCount = students.Count();
            profile.Lessons = lessons.Count();
            profile.Age = user.GetAge();
            if (user.LichessUserId != null)
            {
                if (Request.Cookies["lichess_access_token"] != null)
                {
                    var token = Request.Cookies["lichess_access_token"];

                   var data = await _lichessService.GetLichessUser(user.LichessUserId, token);
                   await _userService.UpdateLichessUser(data);
                    await _dataManager.userRepositories.UpdateUserPerfsAsync(user);
                    Enum.TryParse(data.Title, out ChessTitle title);
                   profile.ChessTitle = title;
                   
                }
                profile.LichessData = await _dataManager.lichessUsersRepositories.GetLichessUserByIdAsync(user.LichessUserId);                
            }
            GetDataHeaderline();           

            return View(profile);
        }
        [Area("adm")]
        public IActionResult EditProfile()
        {
            GetLocalization();
            var user = GetCurrentUser();
            var profile = _mapper.Map<UserViewModel>(user);                       
            profile.Age = user.GetAge();
            profile.Country = EnumHelper.GetValueByDescriptionEnum<Country>(profile.Country);
            GetDataHeaderline();            
            return View(profile);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<ActionResult> EditProfile(UserViewModel user)
        {
            
            ApplicationUser applicationUser = GetCurrentUser();
            if (applicationUser == null)
                return RedirectToAction("Profile", "Home");
            applicationUser.DateBirthday = user.DateBirthday;
             applicationUser.Email = user.Email;
            applicationUser.City = user.City;
            applicationUser.Region = user.Region;
            Enum.TryParse(user.Country, out Country country);            
            applicationUser.Country = EnumHelper.GetDescriptionEnum(country);            
            applicationUser.Name = user.Name;
            applicationUser.Surname = user.Surname;            
            applicationUser.ChessTitle = user.ChessTitle;            
            applicationUser.Stage = user.Stag;
            await _dataManager.userRepositories.SaveUserAsync(applicationUser);
           
            return RedirectToAction("Profile", "Home");
        }
        [Area("adm")]
        public IActionResult Headers()
        {
            GetLocalization();
            GetDataHeaderline();
            var res = _dataManager.settingsRepositories.GetSettingsAsync().Result.ToList();
            
            return View(res);
        }
        [Area("adm")]
        public IActionResult Categories()
        {
            GetLocalization();
            GetDataHeaderline();
            var res = _dataManager.categoryRepositories.GetAllCategory();
            var list = res.ToList();
            return View(list);
        }
        [Area("adm")]
        public IActionResult Statuses()
        {
            GetLocalization();
            GetDataHeaderline();
            var res = _dataManager.statusCoursesRepositories.GetStatusAsync();
            var list = res.ToList();
            return View(list);
        }
        [Area("adm")]
        public IActionResult ClockTournaments()
        {
            GetLocalization();
            GetDataHeaderline();
            var res = _dataManager.clockTournamentsRepositories.GetAllClockTournaments();
            var list = res.ToList();
            return View(list);
        }
        [Area("adm")]
        public async Task<IActionResult> AddClock()
        {
            GetLocalization();
            GetDataHeaderline();
            var clock = new ClockTournament();
            return View(clock);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<IActionResult> SaveClockTournament(ClockTournament clock)
        {
            if (ModelState.IsValid)
            {
                await _dataManager.clockTournamentsRepositories.SaveClockTournamentAsync(clock);
            }
            return RedirectToAction("ClockTournaments", "Home");
        }
        [Area("adm")]
        [HttpGet("EditClock/{id}")]
        public async Task<IActionResult> EditClock([FromRoute] int id)
        {
            var clock = await _dataManager.clockTournamentsRepositories.GetClockTournamentByIdAsync(id).ConfigureAwait(false);
            if (clock == null)
            {
                return BadRequest("Контроль не существует!");
            }


            return View(clock);
        }
        [Area("adm")]
        [HttpDelete("DeleteClock/{id}")]
        public async Task<ActionResult> DeleteClockTournament(int id)
        {
            await _dataManager.clockTournamentsRepositories.DeleteClockTournamentAsync(id).ConfigureAwait(false);
            return Json(1);
        }
        [Area("adm")]
        [HttpGet("EditStatuses/{id}")]
        public async Task<IActionResult> EditStatuses([FromRoute] int id)
        {
            var status = await _dataManager.statusCoursesRepositories.GetStatusByIdAsync(id).ConfigureAwait(false);
            if (status == null)
            {
                return BadRequest("Статус не существует!");
            }


            return View(status);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<IActionResult> SaveStatus(DirectoryStatusCourses status)
        {
            if (ModelState.IsValid)
            {
                await _dataManager.statusCoursesRepositories.SaveStatusAsync(status);
            }
            return RedirectToAction("Statuses", "Home");
        }
        [Area("adm")]
        [HttpDelete("DeleteStatus/{id}")]
        public async Task<ActionResult> DeleteStatuses(int id)
        {
            await _dataManager.statusCoursesRepositories.DeleteStatusAsync(id).ConfigureAwait(false);
            return Json(1);
        }
        [Area("adm")]
        public async Task<IActionResult> AddStatus()
        {
            GetLocalization();
            GetDataHeaderline();
            var status = new DirectoryStatusCourses();
            return View(status);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<IActionResult> AddStatus(DirectoryStatusCourses status)
        {            
            if (ModelState.IsValid)
            {
                await _dataManager.statusCoursesRepositories.SaveStatusAsync(status);
            }
            return RedirectToAction("Statuses", "Home");
        }
        [Area("adm")]
        [HttpGet("EditCategory/{id}")]
        public async Task<IActionResult> EditCategory([FromRoute] int id)
        {
            var category = await _dataManager.categoryRepositories.GetCategoryByIdAsync(id).ConfigureAwait(false);
            if (category == null)
            {
                return BadRequest("Категория не существует!");
            }
           

            return View(category);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<IActionResult> SaveCategory(DirectoryCategory category)
        {
            if (ModelState.IsValid)
            {
                await _dataManager.categoryRepositories.SaveCategoryAsync(category);
            }
            return RedirectToAction("Categories", "Home");
        }
        [Area("adm")]
        public async Task<IActionResult> Roles()
        {
            GetLocalization();
            GetDataHeaderline();
            var res = _roleManager.Roles.ToList();

            return View(res);
        }
        [Area("adm")]
        public async Task<IActionResult> Users()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            GetLocalization();
            GetDataHeaderline();
            var res = await _dataManager.userRepositories.GetUsersAsync().ConfigureAwait(false);
            if (res != null)
            {
                users = res.ToList();
            }
            return View(users);
        }
        [Area("adm")]
        public async Task<IActionResult> AddRoles()
        {
            GetLocalization();
            GetDataHeaderline();
            var roles = new ApplicationRole();            
            return View(roles);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<IActionResult> AddRoles(ApplicationRole role)
        {    
            role.NormalizedName = role?.Name?.ToUpper();
            if (ModelState.IsValid)
            {
                await _roleManager.CreateAsync(role);
            }
            return RedirectToAction("Roles", "Home");
        }
        [Area("adm")]
        [HttpGet("EditUserRoles/{id}")]
        public async Task<IActionResult> EditUserRoles([FromRoute] string id)
        {            
            var user = await _dataManager.userRepositories.GetUserByIdAsync(id).ConfigureAwait(false);
            if (user == null)
            {
                return BadRequest("Пользователя не существует!");
            }
            var userRole = user?.UserRoles?.FirstOrDefault();
            UserRoleViewModel userRoleViewModel = new UserRoleViewModel();
            if (userRole != null)
            {
                userRoleViewModel.UserId = userRole.UserId;
                userRoleViewModel.UserName = userRole?.User?.UserName ?? "";
                Enum.TryParse(userRole.Role.Name,out Role role);
                userRoleViewModel.Role = role;
            }
            
            return View(userRoleViewModel);
        }
        [Area("adm")]
        [HttpPost]
        public async Task<IActionResult> EditRoleUsers(UserRoleViewModel editRole)
        {
            var user = await _dataManager.userRepositories.GetUserByIdAsync (editRole.UserId).ConfigureAwait(false); 
            if (user == null)
            {
                return BadRequest("Пользователь не найден!");
            }
            await _userService.UpdateRoleUser(user,editRole.Role.ToString());
            return RedirectToAction("Users", "Home");
        }
        [Area("adm")]
        public async Task<IActionResult> Courses()
        {
            GetLocalization();
            GetDataHeaderline();
            var user = GetCurrentUser();
            var myCourses = await _dataManager.courseRepositories.GetCourses().Where(x => x.TrainerId == user.Id).OrderByDescending(x => x.CreatedDate).ToListAsync();

            ViewData["AllCourses"] = myCourses;
            return View(myCourses);
        }
        [Area("adm")]
        public async Task<IActionResult> Webinars()
        {
            GetLocalization();
            GetDataHeaderline();
            var user = GetCurrentUser();
            var myWebinars = await _dataManager.webinarRepositories.GetWebinar().Where(x => x.TrainerId == user.Id).OrderByDescending(x => x.CreatedDate).ToListAsync();

            ViewData["AllWebinars"] = myWebinars;
            return View(myWebinars);
        }
        [Area("adm")]
        public async Task<IActionResult> ConfirmEmail()
        {
            GetLocalization();
            GetDataHeaderline();
           
            return View();
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
        public ApplicationUser GetCurrentUser()
        {
           return _dataManager.userRepositories.GetUserByNameAsync(User.Identity.Name).Result;
        }
        public void GetDataHeaderline()
        {
            var user = GetCurrentUser();
            ViewData["user"] = user;
            ViewData["avatar"] = user?.Avatar;
            ViewData["flag"] = user?.Country != null ? user?.Country.Substring(0, 2).ToLower() : null;
        }
        private void GetLocalization()
        {
            var language = Request.Cookies["CultureInfo"];
            if (Request.RouteValues["language"] != null && Request.RouteValues["language"] != language)
                SetLanguage(Request.RouteValues["language"].ToString(), Request.GetDisplayUrl());
        }
        [Area("adm")]
        public async Task<ActionResult> FileUserUploadUniversal(string error)
        {
            if (error == "1")
            {
                return Json(0);
            }
           
            var preview = await _dataManager.userFilesRepositories.GetUserFilesByTypeAsync(TypeUserFiles.Avatar, GetCurrentUser().Id);
            var user = GetCurrentUser();
            try
            {
                UserFiles file = new UserFiles();
                if (preview.Count() > 0)
                {
                    file = await preview.FirstOrDefaultAsync() ?? new UserFiles();
                }
                foreach (UploadedFileInfo fileInfo in FileHelper.GetFilesFromRequest(HttpContext.Request))
                {
                    file.CreateDate = DateTime.Now;
                    file.FileName = fileInfo.FileName;
                    file.FileContentType = fileInfo.FileContentType;
                    file.FileContent = fileInfo.FileContent;
                    file.UserId = GetCurrentUser().Id;                   
                    file.TypeUserFiles = TypeUserFiles.Avatar;
                    await _dataManager.userFilesRepositories.SaveUserFilesAsync(file);
                    user.AvatarFilesId = file.Id;
                    await _dataManager.userRepositories.SaveUserAsync(user);
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
        public async Task<FileResult> DownloadThumb(int id, int height, int width)
        {
            try
            {
                var file = await _dataManager.userFilesRepositories.GetUserFilesByIdAsync(id);

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
    }
}
