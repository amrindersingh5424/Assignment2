using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
  public static  class TriangleSolver
    {
       public static string answer;
        public static string Analyze(int side1, int side2, int side3)
        {
            if (((side1 + side2) > side3) && ((side1 + side3) > side2) && ((side2 + side3) > side1))
            {
                 if (side1 == side2 && side2 == side3 && side3 == side1)
                {
                    answer = "It is Equilateral Triangle";
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                { 
                    answer = "It is isosceles Triangle";
                }    
                else
                {
                    answer = "It is Scalene Triangle";
                }
            }
            else
            {
                answer = "Sorry the sides do not form a triangle";
            }
            return answer;
        }
    }
}
