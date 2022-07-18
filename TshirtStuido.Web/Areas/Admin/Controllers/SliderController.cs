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
        #region Constructor
        private ISliderService _sliderService;
        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        #endregion

        #region index
        public IActionResult Index()
        {
            return View(_sliderService.ShowAllSlider());
        }
        #endregion

        #region Add Slider
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
            TempData["Result"] = res > 0 ? "true" : "false";
            return Redirect("~/Admin/Slider");
        }
        #endregion

        #region Update Slider
        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            MainSlider mainSlider = _sliderService.FindSliderById(id);
            if(mainSlider == null)
            {
                TempData["NotFoundSlider"] = "true";
                return Redirect("~/Admin/Slider");
            }
            else
            {
                return View(mainSlider);
            }
        }
        [HttpPost]
        public IActionResult UpdateSlider(MainSlider mainSlider)
        {
            if (!ModelState.IsValid)
                return View(mainSlider);
            bool res = _sliderService.UpdateSlider(mainSlider);
            TempData["Result"] = res ? "true" : "false";
            return Redirect("~/Admin/Slider");
        }
        #endregion

        #region Delete Slider
        [HttpGet]
        public IActionResult DeleteSlider(int id)
        {
            MainSlider mainSlider = _sliderService.FindSliderById(id);
            if (mainSlider == null)
            {
                TempData["NotFoundSlider"] = "true";
                return Redirect("~/Admin/Slider");
            }
            else
            {
                return View(mainSlider);
            }
        }
        [HttpPost]
        public IActionResult DeleteSlider(MainSlider mainSlider)
        {
            bool res = _sliderService.DeleteSlider(mainSlider);
            TempData["Result"] = res ? "true" : "false";
            return Redirect("~/Admin/Slider");
        }
        #endregion
    }
}
