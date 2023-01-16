using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Signature.Helpers
{
    public class GlobalSettings
    {
        public GlobalSettings(bool isMock)
        {
            IsMock = isMock;
        }
        public bool IsMock { get; set; }
        public CultureInfo CultureInfo { get; set; }
    }
}
