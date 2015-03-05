using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USP.API.Enums.Characters
{
    public enum WeightEnum
    {
        [Description("Skinny")]
        skinny = 0,
        [Description("Average")]
        average,
        [Description("Athletic")]
        athletic,
        [Description("Muscle")]
        muscle,
        [Description("Overweight")]
        overweight
    }
}
