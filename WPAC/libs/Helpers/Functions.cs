using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPAC.libs;

namespace WPAC
{
    public static class Functions
    {
        public static string GetAppdataPath(bool isOursWay = true)
        {
            var returnVal = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            returnVal += isOursWay ? Config.DEFAULT_APPDATA_PATH : "";
            if (!Directory.Exists(returnVal + Config.DEFAULT_APPDATA_PATH)) { Directory.CreateDirectory(returnVal + Config.DEFAULT_APPDATA_PATH); }
            return returnVal;
        }

    }
}
