using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter05Assignment
{
    internal class Aquarium
    {
        public static int FindPhLevel(int foundPh)
        {

            bool askAgain = true;


            
            
            while (askAgain == true)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Battery Acid");
                        askAgain = false;
                        return 0;
                    case "1":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Gastric Acid");
                        askAgain = false;
                        return 1;
                    case "2":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Lemon Juice");
                        askAgain = false;
                        return 2;
                    case "3":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Apple Juice");
                        askAgain = false;
                        return 3;
                    case "4":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Tomato Juice");
                        askAgain = false;
                        return 4;
                    case "5":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Black Coffee");
                        askAgain = false;
                        return 5;
                    case "6":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Milk");
                        askAgain = false;
                        return 6;
                    case "7":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Water");
                        askAgain = false;
                        return 7;
                    case "8":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Egg");
                        askAgain = false;
                        return 8;
                    case "9":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Baking Soda");
                        askAgain = false;
                        return 9;
                    case "10":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Milk of Magnesia");
                        askAgain = false;
                        return 10;
                    case "11":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Ammonia");
                        askAgain = false;
                        return 11;
                    case "12":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Soap");
                        askAgain = false;
                        return 12;
                    case "13":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Bleach");
                        askAgain = false;
                        return 13;
                    case "14":
                        Console.WriteLine("\nYour Water PH is equivalent to: ");
                        Console.WriteLine("Drain Cleaner");
                        askAgain = false;
                        return 14;
                    default:
                        Console.WriteLine("ERROR,Please pick an integer between 0-14: ");
                        break;
                }
            }
            return foundPh;
        }

    }
}
