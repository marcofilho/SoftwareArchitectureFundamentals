using DemoDI.Cases;

namespace DemoDI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region Lifecycle

            builder.Services.AddTransient<ITransientOperation, Operation>();
            builder.Services.AddScoped<IScopedOperation, Operation>();
            builder.Services.AddSingleton<ISingletonOperation, Operation>();
            builder.Services.AddSingleton<ISingletonInstanceOperation>(new Operation(Guid.Empty));
            builder.Services.AddTransient<OperationService>();

            #endregion

            #region VidaReal

            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();

            #endregion

            #region Generics

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            #endregion

            #region MultiplasClasses

            builder.Services.AddTransient<ServiceA>();
            builder.Services.AddTransient<ServiceB>();
            builder.Services.AddTransient<ServiceC>();
            builder.Services.AddTransient<Func<string, IService>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "A":
                        return serviceProvider.GetService<ServiceA>();
                    case "B":
                        return serviceProvider.GetService<ServiceB>();
                    case "C":
                        return serviceProvider.GetService<ServiceC>();
                    default:
                        return null;
                }
            });

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
