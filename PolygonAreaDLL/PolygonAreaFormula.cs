using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonAreaDLL
{
    public class PolygonAreaFormula
    {
        //create the choice selection DLL which is sent the variables created by the user,
        //inputted into the selected formula, then return the resulting value to the main form
        public decimal Processchoice(decimal perimeter, decimal apothem, decimal area)
        {
            //takes the respective variables, solves the equation, then returns the value to the main form
            area = (perimeter / 2) * apothem;
            return area;
        }
    }
}
