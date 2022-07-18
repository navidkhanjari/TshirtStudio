using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TshirtStudio.DataLayer.Entities;

namespace TshirtStudio.Core.Service.Interface
{
    public interface ISliderService
    {
        List<MainSlider> ShowAllSlider();
        MainSlider FindSliderById(int sliderId);
        int AddSlider(MainSlider mainSlider);
        bool UpdateSlider(MainSlider mainSlider);
        bool DeleteSlider(MainSlider mainSlider);
    }
}
