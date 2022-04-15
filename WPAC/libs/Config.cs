using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPAC.libs
{
    public static class Config
    {
        
        public const string 
            DEFAULT_TEMP_PATH = "\\WPAC",
            DEFAULT_APPDATA_PATH = "\\WPAC",
            DEFAULT_ENCRYPTION_PASSWORD = "WPAC",
            IP_CHECK_URL = "http://api.ipify.org";

        public const string BROWSER_VISIBILITY = "DEFAULT"; // HEADLESS, MINIMIZED, DEFAULT
        public static string BROWSER_MODE;
    }
}
