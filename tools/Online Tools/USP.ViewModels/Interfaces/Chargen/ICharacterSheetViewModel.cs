using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USP.API.Enums.Characters;

namespace USP.ViewModels.Interfaces.Chargen
{
    public interface ICharacterSheetViewModel
    {
        string Name { get; set; }
        string Ethnicity { get; set; }
        int Age { get; set; }
        string Gender { get; set; }
        HeightEnum Height { get; set; }
        WeightEnum Weight { get; set; }
        string Background { get; set; }
        string Backstory { get; set; }
    }
}
