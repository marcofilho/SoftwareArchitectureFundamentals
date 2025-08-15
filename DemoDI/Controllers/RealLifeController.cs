using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class RealLifeController : Controller
    {
        private readonly ICustomerService _customerService;

        public RealLifeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public void Index()
        {
            _customerService.Add(new Customer());
        }
    }
}
