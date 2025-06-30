    
    CreateHostBuilder(args).Build().Run();
static IHostBuilder CreateHostBuilder(string[] args) =>    
   
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder
                //webBuilder.UseKestrel();
                //webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                .UseIISIntegration()
                .UseIIS()
                .UseStartup<Startup>();
            });

