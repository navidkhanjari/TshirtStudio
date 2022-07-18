using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TshirtStudio.Core.Service.Interface;
using TshirtStudio.DataLayer.Entities;

namespace TshirtStuido.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private ISliderService _sliderService;
        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public IActionResult Index()
        {
            return View(_sliderService.ShowAllSlider());
        }
        [HttpGet]
        public IActionResult AddSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSlider(MainSlider mainslider)
        {
            if (!ModelState.IsValid)
                return View(mainslider);
            int res = _sliderService.AddSlider(mainslider);
            TempData["Result"] = res > 0 ?"true" : "false";
            return Redirect("~/Admin/Slider");
        }
    }
}
