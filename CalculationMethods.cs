using System;
namespace Calculations
{

    public class MathStuff
    {
        bool extend1 = true;

        public void Menu()
        {
            while (extend1)
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

                    break;
                    case 'A':

                        break;
                    case 's':

                        break;
                    case 'S':

                        break;
                    case 'm':

                        break;
                    case 'M':

                        break;
                    case 'd':

                        break;
                    case 'D':

                        break;
                    case 'e':

                        break;
                    case 'E':

                        break;
                    default:
                        Console.WriteLine("Please enter one of the characters in the parenthesis");
                        break;
                }



            }
        }  
        
    }


}