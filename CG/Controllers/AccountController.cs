using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using CG.Domain;
using CG.Helpers;
using CG.Models;
using CG.Models.Enum;
using CG.Services.Interfaces;

namespace CG.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly IUserService _userService;

        public AccountController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, SignInManager<ApplicationUser> signInManager, IStringLocalizer<HomeController> localizer, IUserService userService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            _userService = userService;
            _localizer = localizer;
        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            GetLocalization();
            ViewBag.ReturnUrl = returnUrl;
            return View(new LoginViewModel());
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model,string returnUrl)
        {            
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe,false);
                    if (result.Succeeded)
                    {
                        if (user.PerfsId == null)
                        {
                            await _userService.AddUserData(user);
                        }
                        if (User.IsInRole("user"))
                        {
                            returnUrl = null;
                        }
                        return Redirect("/");
                    }                                        
                }
                ModelState.AddModelError(nameof(LoginViewModel.UserName), "Неверный логин или пароль");
                ViewBag.returnUrl = returnUrl;                
            }
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            GetLocalization();            
            return View(new RegisterViewModel());
        }       
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            try            
            {                
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByNameAsync(model.UserName);
                    var userEmail = await userManager.FindByEmailAsync(model.Email);
                    if (!model.IsApproval)
                    {
                        ModelState.AddModelError(nameof(RegisterViewModel.IsApproval), "Пользователь не дал согласие на обработку данных!");
                    }
                    else
                    if (user == null && userEmail == null)
                    {
                        ApplicationUser newUser = new ApplicationUser
                        { 
                            Id = UserHelper.GenString(5),                         
                            UserName = model.UserName,
                            NormalizedUserName = model.UserName.ToUpper(),
                            Email = model.Email,
                            NormalizedEmail = model.Email.ToUpper(),                            
                            SecurityStamp = string.Empty,
                        };

                        Task<IdentityResult> regUser = userManager.CreateAsync(newUser, model.Password?.ToString() ?? "");
                        regUser.Wait();
                        if (regUser.Result.Succeeded)
                        {
                            Task<IdentityResult> newUserRole = userManager.AddToRoleAsync(newUser, "user");
                            newUserRole.Wait();
                        }
                        // генерация токена для пользователя
                        var code = await userManager.GenerateEmailConfirmationTokenAsync(newUser);
                        var callbackUrl = Url.Action(
                            "ConfirmEmail",
                            "Account",
                            new { userId = newUser.Id, code = code },
                            protocol: HttpContext.Request.Scheme);
                        var emailService = new CG.EmailService.EmailService();
                        await emailService.SendEmailAsync(model.Email, "Подтвердите ваш аккаунт",
                            $"Подтвердите регистрацию, перейдя по ссылке: <a href='{callbackUrl}'>link</a>");
                        ViewBag.ReturnUrl = "/";

                        await _userService.AddUserData(newUser);
                        return RedirectToAction("SuccessReg","Home");                        
                    }
                    ModelState.AddModelError(nameof(RegisterViewModel.UserName), "Пользователь уже зарегистрирован!");
                }
            } 
            catch (Exception ex) 
            { 

            }
                return View(model);
        }       
        public IActionResult SetEmail()
        {
            GetHeaders();
            GetLocalization();
            return View(new ForgetViewModel());
        }
        [HttpPost]        
        public async Task<IActionResult> SetEmail(ForgetViewModel model)
        {
            GetHeaders();
            ViewBag.ReturnUrl = "/";
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);
                if (user == null)
                {
                    // пользователь с данным email может отсутствовать в бд
                    // тем не менее мы выводим стандартное сообщение, чтобы скрыть 
                    // наличие или отсутствие пользователя в бд
                    return View("Error");
                }
                user.Email = model.Email;                
                await userManager.UpdateAsync(user);
                var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = Url.Action(
                             "ConfirmEmail",
                             "Account",
                             new { userId = user.Id, code = code },
                             protocol: HttpContext.Request.Scheme);
                CG.EmailService.EmailService emailService = new CG.EmailService.EmailService();
                await emailService.SendEmailAsync(model.Email, "Подтверждение аккаунта",
                    $"Для сохранения почты пройдите по ссылке: <a href='{callbackUrl}'>link</a>");
                return View("SuccessSetEmail");
            }
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Forget()
        {
            GetLocalization();
            return View(new ForgetViewModel());
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Forget(ForgetViewModel model)
        {
            GetHeaders();
            ViewBag.ReturnUrl = "/";
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user == null || !(await userManager.IsEmailConfirmedAsync(user)))
                {
                    // пользователь с данным email может отсутствовать в бд
                    // тем не менее мы выводим стандартное сообщение, чтобы скрыть 
                    // наличие или отсутствие пользователя в бд
                    return View("ForgotPasswordConfirmation");
                }

                var code = await userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, email = user.Email, code = code }, protocol: HttpContext.Request.Scheme);
                CG.EmailService.EmailService emailService = new CG.EmailService.EmailService();
                await emailService.SendEmailAsync(model.Email, "Reset Password",
                    $"Для сброса пароля пройдите по ссылке: <a href='{callbackUrl}'>link</a>");                
                return View("ForgotPasswordConfirmation");
            }
            return View(model);
        }        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string email,string code = null)
        {
            GetLocalization();
            GetHeaders();
            return code == null ? View("Error") : View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetViewModel model)
        {
            GetHeaders();
            ViewBag.ReturnUrl = "/";
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return View("ForgotPasswordConfirmation");
            }
            var result = await userManager.ResetPasswordAsync(user, model.Code, model.Password);
            if (result.Succeeded)
            {
                return View("ForgotPasswordConfirmation");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            GetHeaders();
            var result = await userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
                return View("ConfirmEmail");
            else
                return View("Error");
        }
        public async Task<IActionResult> Logout()
        {
            GetLocalization();
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
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
    }
}
