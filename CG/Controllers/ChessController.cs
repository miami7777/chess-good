using Azure.Core;
using CG.Models.Enum;
using CG.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using CG.Domain;
using CG.Service.Interfaces;
using CG.Service;
using Org.BouncyCastle.Crypto.Digests;

namespace CG.Controllers
{
    public class ChessController : Controller
    {
        private readonly IStringLocalizer<ChessController> _localizer;         
        private readonly DataManager _dataManager;
        public ICalculationRatingService _calculationRatingService;

        public ChessController(IStringLocalizer<ChessController> localizer,DataManager dataManager,ICalculationRatingService calculationRatingService)
        {
            _localizer = localizer;            
            _dataManager = dataManager;
            _calculationRatingService = calculationRatingService;
        }

        public async Task<IActionResult> Index()
        {
            GetLocalization();
            GetHeaders();
            var user = await GetCurrentUser();
            ViewData["User"] = user;
            return View();
        }        
        public async Task<IActionResult> Game(int id)
        {
            GetLocalization();
            GetHeaders();
            var user = await GetCurrentUser();
            ViewData["User"] = user;          
            return View(id);
        }
        [HttpPost]
        public async Task<ActionResult> GetNewRating([FromBody] GameState game)
        {
            var newRatingW = await _calculationRatingService.GetRatingByTypeAndUserAsync(game.Options.type, game.Colors["white"].UserName);
            var newRatingB = await _calculationRatingService.GetRatingByTypeAndUserAsync(game.Options.type, game.Colors["black"].UserName);
            var oldRatingW = game.Colors["white"].Rating;
            var oldRatingB = game.Colors["black"].Rating;
            var result = new { whiteR = Convert.ToInt32(newRatingW) - Convert.ToInt32(oldRatingW),
                blackR = Convert.ToInt32(newRatingB) - Convert.ToInt32(oldRatingB)
            };
            return Json(result);
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
        public async Task<ApplicationUser> GetCurrentUser()
        {
            if (User?.Identity?.Name != null)
            {
                return await _dataManager.userRepositories.GetUserByNameAsync(User.Identity.Name);
            }
            else
                return null;
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
    }    
}
