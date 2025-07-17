using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using System.Globalization;
using CG.Domain;
using CG.Models;
using CG.Models.Enum;

namespace CG.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ILogger<HomeController> _logger;
        private readonly DataManager _dataManager;

        public HomeController(ILogger<HomeController> logger, DataManager dataManager, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _dataManager = dataManager;
            _localizer = localizer;
        }        
        public async Task<IActionResult> Index()
        {
            GetLocalization();
            await GetPageCounts();
            await GetAllCategory();
            await GetPopularCourses(3);
            await GetPopularTrainers(3);
            var user = await GetCurrentUser();
            ViewData["User"] = user;
            GetHeaders();
            return View(user);
        }

        private void GetHeaders()
        {
            SettingsViewModel settingsModel = new SettingsViewModel();
            settingsModel.settingsHeaders = new Dictionary<string, string>();
            settingsModel.menu = Enum.GetNames(typeof(HeaderMenu)).Cast<string>().ToList();
            settingsModel.footer_menu = Enum.GetNames(typeof(FooterMenu)).Cast<string>().ToList();
            settingsModel.service_menu = Enum.GetNames(typeof(ServiceMenu)).Cast<string>().ToList();
            try
            {
                foreach (var localResourse in _localizer.GetAllStrings())
                {
                    settingsModel.settingsHeaders.Add(localResourse.Name, localResourse.Value);
                }
            }
            catch (Exception ex)
            {
                settingsModel.settingsHeaders.Add("culture", "ru");
            }
            ViewData["Headers"] = settingsModel;
            
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
        private async Task GetPageCounts()
        {
            var courses = await _dataManager.courseRepositories.GetCourses().ToListAsync();
            var students = await _dataManager.userRepositories.GetUsersByRoleAsync("user");
            var trainers = await _dataManager.userRepositories.GetUsersByRoleAsync("trainer");
            var webinars = await _dataManager.webinarRepositories.GetWebinar().ToListAsync();
            var myCounts = new Dictionary<string, int>
            {
               {"courses",courses.Count() },
               {"students",students.Count() },
               {"trainers",trainers.Count() },
               {"webinars",webinars.Count() },
            };
            ViewData["MyCounts"] = myCounts;
        }
        private async Task GetAllCategory()
        {
            var mycategory = _dataManager.categoryRepositories.GetAllCategory();
            ViewData["MyCategory"] = mycategory.Where(x => x.IsActive == true).OrderBy(x => x.ListOrder).ToList();
        }
        private async Task GetAllReviews()
        {
            var allReviews = await _dataManager.reviewsRepositories.GetReviewsAsync();
            ViewData["AllReviews"] = allReviews.OrderBy(x => x.ListOrder).ToList();
        }
        private async Task GetPopularCourses(int count)
        {
            var popularCourses = await _dataManager.courseRepositories.GetPopularCoursesAsync(count);
            ViewData["PopularCourse"] = popularCourses.OrderBy(x => x.CreatedDate).ToList();
        }
        private async Task GetPopularTrainers(int count)
        {
            var popularTrainers = await _dataManager.userRepositories.GetPopularUsersAsync(count,"user");
            ViewData["PopularTrainers"] = popularTrainers.OrderByDescending(x => x.Stage).ToList();
        }
        private async Task GetTrainers()
        {
            var allTrainers = await _dataManager.userRepositories.GetUsersAsync(1,"user");
            ViewData["AllTrainers"] = allTrainers.OrderByDescending(x => x.Stage).ToList();
        }
        private async Task GetTariffs()
        {
            var allTariffs = await _dataManager.tariffRepositories.GetTariffsAsync();
            ViewData["AllTariffs"] = allTariffs.OrderBy(x => x.PriceMonth).ToList();
        }
        private async Task GetServices()
        {
            var allServices = await _dataManager.serviceRepositories.GetServicesAsync();
            ViewData["AllServices"] = allServices.OrderBy(x => x.CreatedDate).ToList();
        }
        public async Task<ApplicationUser> GetCurrentUser()
        {
            if (User?.Identity?.Name != null)
            {
                return await _dataManager.userRepositories.GetUserByNameAsync(User.Identity.Name);
            }
            else
                return null;
        }
        public async Task<IActionResult> About()
        {
            GetLocalization();
            await GetPageCounts();
            await GetAllReviews();
            GetHeaders();
            return View();
        }
        public async Task<IActionResult> Trainers()
        {
            GetLocalization();
            await GetTrainers();
            GetHeaders();
            return View();
        }        
        public async Task<IActionResult> Pricing()
        {
            GetLocalization();
            await GetTariffs();
            await GetServices();
            GetHeaders();
            return View();
        }
        public IActionResult FAQ()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult RulesChess()
        {
            GetLocalization();            
            GetHeaders();
            return View();
        }
        public IActionResult Debut()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult middlegame()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult endgame()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult strategy()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult tactics()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult matte_designs()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult tactical_techniques()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult world_champions()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult stalemate_structures()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult Contact()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
        public IActionResult Privacy()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }
       
        public IActionResult SuccessReg()
        {
            GetLocalization();
            GetHeaders();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            GetLocalization();
            GetHeaders();
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
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
