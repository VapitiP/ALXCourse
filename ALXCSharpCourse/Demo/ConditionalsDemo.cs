using ALXCSharpCourse.Enums;
using System;

namespace ALXCSharpCourse.Demo
{
    public class ConditionalsDemo
    {
        public static void Run()
        {

            int number = 20;
            if (number > 15)
            {
                Console.WriteLine($"The numer{number} is greather than 15");

            }
            else if (number == 15)
            {
                Console.WriteLine($"The number{number} is eqal to 15");
            }
            else if (number == 3)
            {
                Console.WriteLine($"Im potato");
            }
            else
            {
                Console.WriteLine($"The numer{number} is smaller or eqal 15");
            }

        }

        public static void RunNumberApp()
        {
            Console.WriteLine("NuberApp");
            Console.Write("Enter a number");
            int x = 0;
            bool succeeded = Int32.TryParse(Console.ReadLine(), out x);
            //int x = Convert.ToInt32(Console.ReadLine());
            if (succeeded)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine($" The number {x} is even  ");
                }
                else
                {
                    Console.WriteLine($"The number {x}is odd");
                }
            }
            else
            {
                Console.WriteLine("The given input is not a number!");
            }
        }

        public static void RunSwitch()
        {
            var sex = Sex.FEMALE;
            switch (sex)
            {
                case Sex.MALE:
                    Console.WriteLine("The sex is male");
                    Console.WriteLine("Hello");
                    break;

                case Sex.FEMALE:
                    Console.WriteLine("The sex is female");
                    Console.WriteLine("Hello");
                    break;

                case Sex.COUSTOM:
                    Console.WriteLine("The sex is coustom");
                    Console.WriteLine("Hello");
                    break;


                default:
                    Console.WriteLine("defaul");
                    break;
            }
            Console.WriteLine("Switch end...");


            int number = 5;
            switch ( number)
            {
                case 0:
                     
                    Console.WriteLine("Hello");
                    break;

                case 1:
                     
                    Console.WriteLine("Im potato");
                    break;

                case 126:
                    
                    Console.WriteLine("c# RULEZ");
                    break;


                default:
                    Console.WriteLine("defaul");
                    break;
            }
            Console.WriteLine("Switch end...");

        }
    }
}
