using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPrismVolumeDLL
{
    public class RegularPrismVolumeFormula
    {
        //create the choice selection DLL which is sent the variables created by the user,
        //inputted into the selected formula, then return the resulting value to the main form
        public decimal Processchoice(decimal baselength, decimal height, decimal volume)
        {
            //takes the respective variables, solves the equation, then returns the value to the main form
            volume = baselength * height;
            return volume;
        }
    }
}
