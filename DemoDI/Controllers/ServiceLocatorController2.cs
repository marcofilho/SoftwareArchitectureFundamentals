using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class ServiceLocatorController2 : Controller
    {
        public void Index([FromServices] IServiceProvider serviceProvider)
        {
            // It will returns null if the service is not registered
            serviceProvider.GetRequiredService<ICustomerService>().Add(new Customer());
        }
    }
}
