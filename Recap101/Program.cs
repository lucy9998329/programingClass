using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap101
{
    class Program
    {
        static void Main(string[] args)
        {
            //how to create a variable
            //var name = "Bob";

            //var age = 32;
            //int age2;

            Console.WriteLine();

            //how to create a constant
            //safe conding
            // const string name = "";
            //const string dobcountry = "New Zealand";
            //Console.WriteLine(dobcountry);
            //Console.ReadKey();

            /*var int1 = 55;
            var int2 = 95;
            if(int1 > int2)
            {
                Console.WriteLine($"Int1 ({int1}) is bigger than int2 ({int2})");
                //Console.WriteLine("Int1 ("+int1+") is bigger than int2 ({int2})");
              
            } else
            {
                Console.WriteLine($"int1 ({int1}) is not bigger than int2 ({int2})");
                Console.ReadKey();
                
            }*/

            var day = "Monday";

            switch (day)

            {
                case "Monday":
                    Console.WriteLine("Monday is a tough day because it's the first day of the week");
                    break;

                case "Wednesday":
                    Console.WriteLine("Has 1h class");
                    break;
                default:
                    Console.WriteLine($"this is for any other day - including Tuesday {day}");
                    break;

            }

        }
    }
}
