using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TshirtStudio.Core.Extensions
{
    public static class UploadImg
    {
        public static string CreateImage(IFormFile file)
        {
            try
            {
                string ImageName = GenerateCode.GuidCode() + Path.GetExtension(file.FileName);
                string PathImg = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/SitePannel/ImageSite/" + ImageName);

                using (var stream = new FileStream(PathImg, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return ImageName;
            }
            catch (Exception)
            {

                return "false";
            } 
        } 
        
        public static bool DeleteImage(string path , string ImageName)
        {
            try
            {
                string FullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/SitePannel/" + path + "/" + ImageName);
                if (File.Exists(FullPath))
                {
                    File.Delete(FullPath);
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
