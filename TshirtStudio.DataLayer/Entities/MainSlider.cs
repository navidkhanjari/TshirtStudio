using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TshirtStudio.DataLayer.Entities
{
   public class MainSlider
    {
        [Key]
        public int Sliderid { get; set; }

        [Display(Name = "عنوان اسلایدر")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری است .")]
        public string SliderTitle { get; set; }

        [Display(Name = "الت اسلایدر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید .")]
        public string sliderAlt { get; set; }

        [Display(Name = "ترتیب اسلایدر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید .")]
        public int SliderSort { get; set; }

        [Display(Name = "لینک اسلایدر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید .")]
        public string SliderLink { get; set; }

        [Display(Name = "تصویر اسلایدر اسلایدر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید .")]
        public string SliderImg { get; set; }

        public bool IsActive { get; set; }
    }
}
