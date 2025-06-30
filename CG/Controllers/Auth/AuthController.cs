using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CG.Builders;
using CG.Domain;
using CG.HttpServices.Interfaces;
using CG.Interfaces;
using CG.Services.Interfaces;

namespace CG.Controllers.Auth;

#pragma warning disable CS1591
[ApiController]
public partial class AuthController : Controller
{
    private readonly IMapper _mapper;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ResponseBuilder _responseBuilder;
    private readonly IUserService _userService;

    private readonly ILocalIdentityServerHttpService _identityServerHttpService;
    private readonly ILichessIdentityServerHttpService _lichessIdentityServerHttpService;
    private readonly IStateKeyCacheService _stateKeyCache;
   

    public AuthController(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        IMapper mapper,
        ResponseBuilder responseBuilder,
        DataManager dataManager,
        ILocalIdentityServerHttpService identityServerHttpService,
        ILichessIdentityServerHttpService lichessIdentityServerHttpService,
        IStateKeyCacheService stateKeyCacheService,
        IUserService userService
       )
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _mapper = mapper;
        _responseBuilder = responseBuilder;
        _stateKeyCache = stateKeyCacheService;
        _userService = userService;       
        _identityServerHttpService = identityServerHttpService;
        _lichessIdentityServerHttpService = lichessIdentityServerHttpService;
       
    }
    
}