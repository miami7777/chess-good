using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using CG.Domain;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;
using CG.Domain.Repositories.EntityFramework;
using CG.Hubs;
using CG.Mapping;
using CG.ServiceConvention;
using CG.Builders;
using CG.Helpers;
using CG.HttpServices.Implementation;
using CG.HttpServices.Interfaces;
using CG.Interfaces;
using CG.Services.Implementation;
using CG.Services.Interfaces;
using SSO.Api.CacheServices.Implementation;
using CG.Extentions;
using CG.Service;
using CG.Service.Interfaces;

public class Startup {
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
        BaseConfiguration = new BaseConfiguration();
        Configuration.Bind("Project",new BaseConfiguration());
        
    }
    public IConfiguration Configuration { get; }

    public BaseConfiguration BaseConfiguration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
        var lichessUrl = Configuration["LichessServer:ServerUrl"];
        services.AddLocalization(options => options.ResourcesPath = "Resources");
        
        services.AddTransient<IServiceRepositories, ServiceRepositories>();
        services.AddTransient<ITariffsRepositories, TariffsRepositories>();
        services.AddTransient<ICourseRepositories, CourseRepositories>();
        services.AddTransient<IReviewsRepositories, ReviewRepositories>();
        services.AddTransient<ICourseDetailsRepositories, CourseDetailsRepositories>();
        services.AddTransient<IChaptersRepositories, ChapterRepositories>();
        services.AddTransient<IWebinarRepositories, WebinarRepositories>();
        services.AddTransient<ICategoryRepositories, DirectoryCategoriesRepositories>();
        services.AddTransient<IUsersRepositories, UserRepositories>();
        services.AddTransient<ILichessUsersRepositories, LichessUserRepositories>();        
        
        services.AddTransient<ISettingsRepositories, SettingsRepositories>();
        services.AddTransient<ILessonsRepositories, LessonsRepositories>();
        services.AddTransient<ICourseFilesRepositories, CourseFilesRepositories>();
        services.AddTransient<IWebinarFilesRepositories, WebinarFilesRepositories>();
        services.AddTransient<IStatusCoursesRepositories, StatusCoursesRepositories>();
        services.AddTransient<ILocalIdentityServerHttpService, LocalIdentityServerHttpService>();
        services.AddTransient<ILichessIdentityServerHttpService, LichessIdentityServerHttpService>();
        services.AddTransient<IClockTournamentsRepositories, ClockTournamentsRepositories>();
        services.AddTransient<ILichessService, LichessService>();
        services.AddTransient<IStateKeyCacheService, StateKeyCacheService>();       
        services.AddTransient<DirectoryCategory>();
        services.AddTransient<DirectoryStatusCourses>();
        services.AddTransient<Course>();
        services.AddTransient<Service>();
        services.AddTransient<Tariffs>();
        services.AddTransient<Webinar>();        
        services.AddTransient<ApplicationUser>();
        services.AddTransient<ResponseBuilder>();
        services.AddTransient<DataManager>();
        services.AddTransient<IHttpHelper, HttpHelper>();
        services.AddTransient<ICalculationRatingService, CalculationRatingService>();
        services.AddScoped<IUserService, UserService>();
        
        services.AddDbContext<AppDbContext>(x => x.UseSqlServer(BaseConfiguration.projectConnection));

        services.AddIdentity<ApplicationUser, ApplicationRole>(opt =>
        {
            opt.User.RequireUniqueEmail = true;
            opt.Password.RequiredLength = 6;
            opt.Password.RequireNonAlphanumeric = false;
            opt.Password.RequireUppercase = false;
            opt.Password.RequireLowercase = false;
            opt.Password.RequireDigit = false;
        }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

        services.ConfigureApplicationCookie( 
        opt =>
        {
            opt.Cookie.Name = "Name";
            opt.Cookie.HttpOnly = true;
            opt.LoginPath = "/ru/account/login";
            opt.LogoutPath = "/ru/account/accessdenied";
            opt.SlidingExpiration = true;
        });
        services.AddAuthorization(x => x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin","organizer","member","user","sportsman"); })) ;
        services.AddAutoMapper(typeof(MappingProfile));
        if (lichessUrl != null)
            services.AddHttpClients(lichessUrl);
        // Add services to the container.
        services.AddControllersWithViews(x => x.Conventions.Add(new AdminAreaAuthorization("adm","AdminArea")));
        var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        services.AddSignalR(hubOptions => { hubOptions.ClientTimeoutInterval = TimeSpan.FromMinutes(3); });
        services.AddCors(options =>
        {
            options.AddPolicy(name: MyAllowSpecificOrigins,
                              policy =>
                              {
                                  policy.WithOrigins("http://chess-good.ru",
                                                      "https://chess-good.ru",
                                                      "http://127.0.0.1:5177",
                                                           "https://127.0.0.1:7229");
                              });
        });
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IMapper mapper)
    {
        var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        void ApplyHeaders(IHeaderDictionary headers)
        {
            headers.Add("Cross-Origin-Embedder-Policy", "require-corp");
            headers.Add("Cross-Origin-Opener-Policy", "same-origin");
        }
        mapper.ConfigurationProvider.AssertConfigurationIsValid();
        // Configure the HTTP request pipeline.
        if (!env.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            //The default HSTS value is 30 days.You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        var supportedCultures = new[]
            {
                new CultureInfo("en"),
                new CultureInfo("ru"),
                new CultureInfo("de")
            };
        app.UseRequestLocalization(new RequestLocalizationOptions
        {
            DefaultRequestCulture = new RequestCulture("ru"),
            SupportedCultures = supportedCultures,
            SupportedUICultures = supportedCultures
        });
        app.UseHttpsRedirection();
        
        app.Use(async (context, next) =>
        {
            ApplyHeaders(context.Response.Headers);
            await next();
        });
        app.UseStaticFiles();
        app.UseRouting();

        app.UseCookiePolicy();
        app.UseWebSockets();
        app.UseCors(MyAllowSpecificOrigins);
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(
            endpoints => {                
                endpoints.MapControllerRoute("adm", "{area:exists}/{language=ru}/{controller=Home}/{action=Index}/{id?}");                
                endpoints.MapControllerRoute("default", "{language=ru}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<ChessHub>("{language=ru}/{controller=Chess}/chessHub");
            });        
    }
}
