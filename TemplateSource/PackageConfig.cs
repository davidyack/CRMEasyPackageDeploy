using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCRMPackageDeploy
{
    public class PackageConfig
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }

        public string Description { get; set; }
        public string PackageFolder { get; set; }
    }
}
