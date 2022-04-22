using Microsoft.AspNetCore.Mvc;
using Tickets.Data;

namespace Tickets.Controllers
{
    public class checController : Controller
    {
        private readonly DataContext _contextAccessor;
        public checController(DataContext context)
        {
            _contextAccessor = context;
        }
            
            public IActionResult Index()
        {
            return View();
        }
    }
}
