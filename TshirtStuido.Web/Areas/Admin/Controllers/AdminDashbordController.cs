using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TshirtStuido.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminDashbordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
