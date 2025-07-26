using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeVolumeDLL
{
    public class CubeVolumeFormula
    {
        //create the choice selection DLL which is sent the variables created by the user,
        //inputted into the selected formula, then return the resulting value to the main form
        public decimal Processchoice(decimal side, decimal volume)
        {
            //takes the respective variables, solves the equation, then returns the value to the main form
            volume = side * side * side;
            return volume;
        }
    }
}
