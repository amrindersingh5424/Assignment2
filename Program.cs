using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1, side2, side3;
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");

            int input = int.Parse(Console.ReadLine());
            if (input == 1) {
                Console.WriteLine("Enter value of  side 1");
                side1 = gettingDimensions();

                Console.WriteLine("Enter value of  side 2");
                side2 = gettingDimensions();

                Console.WriteLine("Enter value of  side 3");
                side3 = gettingDimensions();

                
            }
            else { Environment.Exit(0); }
            
        }
        public static int gettingDimensions() {
            int dimension = 0;
            string input = "";
            do {
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out dimension) || dimension < 0);
            return dimension
        return 
                }
    }
}
