using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace backend
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
            services.AddDbContext<AppDBContext>(options => options.
            UseMySql("server=localhost;Database=EntitfyDB;persistsecurityinfo=True;Uid=root;Pwd=root;"));

            services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            #region comment

            /*
            using (var context = new AppDBContext()) {

                context.Database.EnsureCreated();

                //Ok let's add some users, admins, products, orders.
                if (context.Product.Count<Product>() == 0)
                {
                    Product p = new Product { ProductID = "1", Price = 3, ProductOrders = new Collection<ProductOrder>(), ProductName = "Brush" };
                    Console.Write("yep");
                    context.Product.Add(p);
                    
                    context.SaveChanges();

                }
                if (context.Customer.Count<Customer>() == 0)
                {
                    Customer shahd = new Customer { First_name = "Shahd", Last_name = "Sherif", Orders = new Collection<Order>(), Password = "password", Status = "Active", Username = "shahd" };

                    context.Customer.Add(shahd);
                    context.SaveChanges();
                }
                if (context.Admin.Count<Admin>() == 0) {

                    Admin shahd = new Admin { First_name = "Shahd", Last_name = "", Password = "password", Status = "Active", Username = "shahd" };
                    context.SaveChanges();
                }

                //if (context.Order.Count<Order>() == 0) {

                //    Order o = new Order { CustomerUsername="shahd", OrderNumber=1, OrderTotal=context.ProductOrder.}
                //}
            }
            */

            #endregion


            //services.AddDefaultIdentity<IdentityUser>()
            //    .AddRoles<IdentityRole>()
            //    .AddEntityFrameworkStores<AppDBContext>()
            //    .AddDefaultTokenProviders();


            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<AppDBContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options => {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 1;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
               

            });
            services.ConfigureApplicationCookie(options =>
            {

                options.LoginPath = "/login";
            });
            services.AddControllersWithViews();
            services.AddCors();
            services.AddMvc();
        }

        private ServiceLifetime UseMySQL(string v)
        {
            throw new NotImplementedException();
        }

        //Since our app only has 2 static roles, we only need to do this once. so in the startup class is good. 
        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            var mRoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roles = { "admin", "customer" };
            foreach (var role in roles)
            {
                //creating the roles and seeding them to the database
                var roleExist = await mRoleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                     await mRoleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            //we need the provider so we can access it from any page
            IoCContainer.Provider =  serviceProvider;

            //setup identti
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

           // CreateRoles(serviceProvider).Wait();
        }
    }
}
