using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
          while (true)
          {
                Console.WriteLine($"{name}, enter a number between 1 and 100.");
                int input = int.Parse(Console.ReadLine());

             if (input < 1 || input > 100)
             {
                Console.WriteLine("Input not valid. Only numbers from 1 to 100 accepted.");
                continue;
             }
                if (input % 2 != 0)
                {                    
                    if (input > 60)
                    {
                        Console.WriteLine($"{name}, the number {input} is Odd");
                    }
                    else if (input < 100)
                    {
                        Console.WriteLine("Odd");
                    }
                }

                if (input % 2 == 0)
                {
                    if (input <= 25 && input >= 2)
                    {
                        Console.WriteLine($"{name}, the number is even and less than 25.");
                    }
                    else if (input <= 60 && input >= 26)
                    {
                        Console.WriteLine($"{name}, the number is Even");
                    }
                    else if (input > 60)
                    {
                        Console.WriteLine($"{name}, the number {input} is Even");
                    }
                }


            Console.WriteLine("Do you wish to conitue?  (Y/N)");
            string answer = Console.ReadLine().ToLower();

                if (answer == "y" || answer == "yes")
                {
                    continue;
                }
                else if (answer == "n" || answer == "no")
                {
                    break;
                }             
          }
            
           Console.WriteLine("Thank you for participating");
           Console.ReadLine();
           
        }
    }
}

