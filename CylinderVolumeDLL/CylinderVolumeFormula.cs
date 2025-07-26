using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CylinderVolumeDLL
{
    public class CylinderVolumeFormula
    {
        //create the choice selection DLL which is sent the variables created by the user,
        //inputted into the selected formula, then return the resulting value to the main form
        public decimal Processchoice(decimal radius, decimal pi, decimal height, decimal volume)
        {
            //takes the respective variables, solves the equation, then returns the value to the main form
            pi = 3.14159m;
            volume = pi * (radius * radius) * height;
            return volume;
        }
    }
}
