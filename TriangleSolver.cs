using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
  public static  class TriangleSolver
    {
       public static String answer;
        public  static String Analyze(int side1, int side2, int side3)
        {
            if (((side1 + side2) > side3) && ((side1 + side3) > side2) && ((side2 + side3) > side1))
            {
                 if (side1 == side2 || side2 == side3 || side1 == side2)
                {
                    answer = "It is isosceles Triangle";
                }
                else if (side1 == side2 && side2 == side3 && side3 == side1)
                {
                    answer = "It is Equilateral Triangle";
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
