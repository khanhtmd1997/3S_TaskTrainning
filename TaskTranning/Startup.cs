using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using TaskTranning.AllViewModels;
using TaskTranning.Models;
using TaskTranning.Resources;
using TaskTranning.Services;
using TaskTranning.Services.Interface;
using ICustomerServices = TaskTranning.Services.Interface.ICustomerServices;
using IProductServices = TaskTranning.Services.Interface.IProductServices;
using IStockServices = TaskTranning.Services.Interface.IStockServices;

namespace TaskTranning
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromDays(1);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });


            services.AddTransient<IUserServices, UserServices>();
            services.AddTransient<IStoreServices, StoreServices>();
            services.AddTransient<ICustomerServices, CustomerServices>();
            services.AddTransient<ICategoryServices, CategoryServices>();
            services.AddTransient<IProductServices, ProductServices>();
            services.AddTransient<IBrandServices, BrandServices>();
            services.AddTransient<IStockServices, StockServices>();
            services.AddTransient<CodeFirstDataContext>();
            services.AddAutoMapper();
            
            
            services.AddDbContext<CodeFirstDataContext>(item => item.UseSqlServer(Configuration.GetConnectionString("myconn")));
            services.AddDbContext<CodeFirstDataContext>();
            
            services.AddSingleton<ResourcesServices>();
            #region snippet1

            #endregion
            services.AddLocalization(options => options.ResourcesPath = "Resources"); 
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("vi-VN")                
                };

                options.DefaultRequestCulture = new RequestCulture("en-US");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
            });
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddViewLocalization(opts => { opts.ResourcesPath = "Resources";})
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                    {
                        var assemblyName = new AssemblyName(typeof(SharedResource).GetTypeInfo().Assembly.FullName);
                        return factory.Create("SharedResource", assemblyName.Name);
                    };
                })
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<UserValidator>())
                .AddViewLocalization();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            
            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(options.Value);
            
            app.UseRequestLocalization();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            
            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == StatusCodes.Status404NotFound
                    && !context.Response.HasStarted)
                {
                    context.Request.Path ="/Error/404";
                    await next();
                }
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=User}/{action=LoginForm}/{id?}");
                
            });
        }
    }
}