using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TshirtStudio.Core.Service.Interface;
using TshirtStudio.DataLayer.Context;
using TshirtStudio.DataLayer.Entities;

namespace TshirtStudio.Core.Service
{
   
    public class SliderService : ISliderService
    {
        private ApplicationDbContext _Context;
        public SliderService(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public int AddSlider(MainSlider mainSlider)
        {
            try
            {
                _Context.mainSliders.Add(mainSlider);
                _Context.SaveChanges();
                return mainSlider.Sliderid;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public bool DeleteSlider(MainSlider mainSlider)
        {
            try
            {
                _Context.mainSliders.Remove(mainSlider);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public MainSlider FindSliderById(int sliderId)
        {
            return _Context.mainSliders.Find(sliderId);
        }

        public List<MainSlider> ShowAllSlider()
        {
            return _Context.mainSliders.OrderBy(s=> s.SliderSort).ToList();
        }

        public bool UpdateSlider(MainSlider mainSlider)
        {
            try
            {
                _Context.mainSliders.Update(mainSlider);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
