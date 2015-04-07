using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCRMPackageDeploy
{
    public static class PackageConfigManager
    {
        private static PackageConfig _Config = null;
         static  PackageConfigManager()
        {
            using (StreamReader r = new StreamReader("EasyCRMPackage.json"))
            {
                string json = r.ReadToEnd();
                _Config = JsonConvert.DeserializeObject<PackageConfig>(json);
            }

        }

        public static string ShortName
         {
             get
             {
                 return _Config.ShortName;
             }
         }
        public static string LongName
        {
            get
            {
                return _Config.LongName;
            }
        }

        public static string Description
        {
            get
            {
                return _Config.Description;
            }
        }
        public static string PackageFolder
        {
            get
            {
                return _Config.PackageFolder;
            }
        }
    }
}
