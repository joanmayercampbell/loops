using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CylinderHelper
{
    class Program
    {
        static double GetNumberFromUser()
        {
            double userNumber = 0;
            bool numberEntered = false;

            while (!numberEntered)
            {
                try
                {
                    string userResponse = Console.ReadLine();
                    userNumber = Convert.ToDouble(userResponse);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Please enter a number. Try again!");
                }

                numberEntered = true;
            }
        }
         
        static void Main(string[] args)
        {
            bool end = true;
            string userinput = "not done";

            while (end)
            {
                //inital statement
                Console.WriteLine("Calculate new cylinder values ");

                Console.WriteLine("What is the radius ? ");
                
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The radius is " + radius);

                Console.WriteLine("What is the height ? ");
                double height = Convert.ToDouble(Console.ReadLine());

                //Volume = radius^2 * height * pi
                // radius ^ 2 is radius * radius

                double pi = 3.14159;
                if (radius > 0 && height > 0)
                {
                    double volume = (radius * radius) * height * pi;
                    Console.WriteLine("The volume is " + volume);

                    // surface area = 2*pi*radius*height + 2*pi*radius^2
                    double surfaceArea = (pi * 2 * radius * height) + (2 * pi * radius * radius);
                    Console.WriteLine("the surface area = " + surfaceArea);
                }
                else
                {
                    Console.WriteLine("You can't have a negative");
                }

                Console.WriteLine("Enter \"done\" to exit");
                userinput = Console.ReadLine();

                if (userinput.ToLower() == "done")
                {
                    end = false;
                }
               
            }
        }
    }
}
