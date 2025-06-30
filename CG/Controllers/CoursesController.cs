using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using CG.Domain;
using CG.Models.Enum;
using CG.Models;
using Microsoft.EntityFrameworkCore;

namespace CG.Controllers
{
    public class CoursesController : Controller
    {
        private readonly IStringLocalizer<CoursesController> _localizer;
        private readonly ILogger<CoursesController> _logger;
        private readonly DataManager _dataManager;

        public CoursesController(ILogger<CoursesController> logger, DataManager dataManager, IStringLocalizer<CoursesController> localizer)
        {
            _dataManager = dataManager;
            _logger = logger;
            _localizer = localizer;
        }       
        public async Task<IActionResult> Index()
        {
            GetLocalization();
            await GetAllCourses();
            GetHeaders();
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
        private async Task GetAllCourses()
        {
            var allCourses = await _dataManager.courseRepositories.GetCourses().Where(x => x.StatusId == 5).ToListAsync();
            ViewData["AllCourse"] = allCourses.ToList();
        }
        private void GetLocalization()
        {
            var language = Request.Cookies["CultureInfo"];
            if (Request.RouteValues["language"] != null && Request.RouteValues["language"] != language)
                SetLanguage(Request.RouteValues["language"].ToString(), Request.GetDisplayUrl());
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
