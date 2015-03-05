using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USP.API.Enums.Characters
{
    public enum HeightEnum {
        [Description("Short")]
        small = 0,
        [Description("Average")]
        average,
        [Description("Tall")]
        tall
    }
}
