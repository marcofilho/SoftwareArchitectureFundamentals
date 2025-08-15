using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class MultipleClassesController : Controller
    {
        private readonly Func<string, IService> _serviceAccessor;

        public MultipleClassesController(Func<string, IService> serviceAccessor)
        {
            _serviceAccessor = serviceAccessor;
        }

        public string Index()
        {
            return _serviceAccessor("A").ReturnValue();
            //return _serviceAccessor("B").ReturnValue();
            //return _serviceAccessor("C").ReturnValue();
        }
    }
}
