using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using USP.API.Enums.Characters;
using USP.ViewModels.Interfaces.Chargen;
using USP.Utilities;

namespace USP.ViewModels.Chargen
{
    public class CharacterSheetSelectList
    {
        public static SelectList GetHeightDropdownList()
        {
            Enum.GetValues(typeof(HeightEnum));
            List<SelectListItem> dropdown = new List<SelectListItem>();

            foreach (HeightEnum index in Enum.GetValues(typeof(HeightEnum)))
            {
                dropdown.Add(
                    new SelectListItem
                    {
                        Text = index.GetEnumDescription(),
                        Value = ((int) index).ToString()
                    }
                );
            }

            return new SelectList(
                dropdown, 
                "Value",
                "Text"
            );
        }


        public static SelectList GetWeightDropdownList()
        {
            Enum.GetValues(typeof(WeightEnum));
            List<SelectListItem> dropdown = new List<SelectListItem>();

            foreach (WeightEnum index in Enum.GetValues(typeof(WeightEnum)))
            {
                dropdown.Add(
                    new SelectListItem
                    {
                        Text = index.GetEnumDescription(),
                        Value = ((int)index).ToString()
                    }
                );
            }

            return new SelectList(
                dropdown,
                "Value",
                "Text"
            );
        }
    }
}
