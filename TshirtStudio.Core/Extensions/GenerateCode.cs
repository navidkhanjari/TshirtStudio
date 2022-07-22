using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TshirtStudio.Core.Extensions
{
   public static class GenerateCode
    {
        public static string GuidCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
