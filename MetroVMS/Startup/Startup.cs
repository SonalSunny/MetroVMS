using MetroVMS.Entity;
using MetroVMS.Program;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net;

namespace MetroVMS.Startup
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            //services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddControllers().ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressMapClientErrors = true;
                options.InvalidModelStateResponseFactory = context =>
                {
                    var problemDetails = new ProblemDetails
                    {
                        Status = StatusCodes.Status404NotFound,
                        Title = "Not Found",
                        Detail = "The requested resource could not be found."
                    };

                    return new NotFoundObjectResult(problemDetails)
                    {
                        ContentTypes = { "application/problem+json" }
                    };
                };
            });
            services.AddRazorPages();

            services.RegisterDBContext(Configuration);

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(o =>
               {
                   o.LoginPath = new PathString("/SessionTracker");
                   o.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                   o.AccessDeniedPath = new PathString("/ErrorPages/AccessDenied");
                   o.LoginPath = "/Account/Login";
                   o.AccessDeniedPath = "/Account/AccessDenied";
               });

            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<Logger>();

            services.AddHttpClient();
            services.RegisterLocalization();
        }

        public async void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            // Enable WebSockets
            app.UseWebSockets();
            app.UseStaticFiles();
            app.UseRequestLocalization(app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);
            app.UseRouting();
            app.MapControllers();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorPages();



            //app.UseStatusCodePages(async context =>
            //{
            //    var request = context.HttpContext.Request;
            //    var response = context.HttpContext.Response;

            //    if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
            //    {
            //        response.Redirect("/SessionTracker");
            //    }
            //    else if (response.StatusCode == (int)HttpStatusCode.Forbidden)
            //    {
            //        response.Redirect($"/Error/403");
            //    }
            //    else if (response.StatusCode == (int)HttpStatusCode.NotFound)
            //    {
            //        response.Redirect($"/PageNotFound");
            //    }
            //    else
            //    {
            //        response.Redirect($"/Error/{response.StatusCode}");
            //    }
            //});
            app.UseWhen(context => !context.Request.Path.StartsWithSegments("/api"), builder =>
            {
                builder.UseStatusCodePages(async context =>
                {
                    var request = context.HttpContext.Request;
                    var response = context.HttpContext.Response;

                    if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
                    {
                        response.Redirect("/SessionTracker");
                    }

                    // if (response.StatusCode == (int)HttpStatusCode.Unauthorized && !request.Path.StartsWithSegments("/CoreModule/ApprovalRequests/QuotationApproval/Manage"))
                    // {
                    //    response.Redirect("/SessionTracker");
                    //}
                    else if (response.StatusCode == (int)HttpStatusCode.Forbidden)
                    {
                        response.Redirect($"/Error/403");
                    }
                    else if (response.StatusCode == (int)HttpStatusCode.NotFound)
                    {
                        response.Redirect($"/PageNotFound");
                    }
                    //else
                    //{
                    //    response.Redirect($"/Error/{response.StatusCode}");
                    //}
                });
            });

            //app.UseStatusCodePagesWithRedirects("~/Error/{0}");
            app.MapGet("/", async context =>
            {
                context.Response.Redirect("/Login");
            });
            await DBInitializer.Initialize(app);

        }

    }
}
