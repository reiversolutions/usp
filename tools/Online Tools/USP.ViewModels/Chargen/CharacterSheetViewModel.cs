using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USP.API.Enums.Characters;
using USP.ViewModels.Interfaces.Chargen;

namespace USP.ViewModels.Chargen
{
    public class CharacterSheetViewModel : ICharacterSheetViewModel
    {
        // Personal
        public string Name { get; set; }
        public string Ethnicity { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public HeightEnum Height { get; set; }
        public WeightEnum Weight { get; set; }
        public string Background { get; set; }
        public string Backstory { get; set; }

        // Attributes
        public int Constitution { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        public int Mind { get; set; }
        public int Charm { get; set; }
        public int Willpower { get; set; }
    }
}
