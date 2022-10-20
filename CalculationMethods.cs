using System;

namespace Calculations
{

    public class MathStuff
    {
        

        public static void Menu()
        
        {
            bool extend = true;
            while (extend)
            {
                Console.WriteLine("Add (A)");
                Console.WriteLine("Subtract (S)");
                Console.WriteLine("Multiply (M)");
                Console.WriteLine("Divide (D)");
                Console.WriteLine("Exit (E)");

                char choice = Console.ReadKey().KeyChar;

                switch(choice)
                {
                    case 'a':
                        Addition();
                        break;
                    case 'A':
                        Addition();
                        break;
                    case 's':
                        Subtraction();
                        break;
                    case 'S':

                        break;
                    case 'm':

                        break;
                    case 'M':
                        Multiplication();
                        break;
                    case 'd':

                        break;
                    case 'D':
                        Division();
                        break;
                    case 'e':
                        extend = false;
                        break;
                    case 'E':

                        break;
                    default:
                        Console.WriteLine("\nPlease enter one of the characters in the parenthesis");
                        break;
                }



            }
        }  

        public static double Addition()
        {
            double x,y;
            
            Console.WriteLine("\nEnter the first number");
            double.TryParse(Console.ReadLine(), out x);
            
            
            Console.WriteLine("Enter the second number");
            double.TryParse(Console.ReadLine(), out y);
            
            double result = x+y;
            Console.WriteLine("The result is " + result);
            return result;
        }

        public static double Subtraction()
        {
            double x, y;

            Console.WriteLine("\nEnter the first number");
            double.TryParse(Console.ReadLine(), out x);
            
            Console.WriteLine("Enter the second number");
            double.TryParse(Console.ReadLine(), out y);
            
            double result = x - y;
            Console.WriteLine("The result is " + result);
            return result;
        }

        public static double Multiplication()
        {
            double x, y;

            Console.WriteLine("\nEnter the first number");
            double.TryParse(Console.ReadLine(), out x);
            
            Console.WriteLine("Enter the second number");
            double.TryParse(Console.ReadLine(), out y);
            
            double result = x * y;
            Console.WriteLine("The result is " + result);
            return result;
        }

        public static double Division()
        {
            double x, y;

            Console.WriteLine("\nEnter the first number");
            double.TryParse(Console.ReadLine(), out x);
            
            Console.WriteLine("Enter the second number");
            double.TryParse(Console.ReadLine(), out y);
            
            double result = x / y;
            Console.WriteLine("The result is " + result);
            return result;
        }

        // method for square root 



        // menu for multiple numbers math
        
    }


}