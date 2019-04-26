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
            string name= Console.ReadLine();
            while(true)
            {
                 Console.WriteLine(name + ", enter a number between 1 and 100.");
                 int input = int.Parse(Console.ReadLine());

                 if (input <1 || input >100)
                 {   
                    Console.WriteLine("Input not valid. Only numbers from 1 to 100 accepted.");
                    continue;
                 }
                                                                     
                 if (input % 2 != 0)
                 {
                    Console.WriteLine(name + ", the number " + input + " is "  + "Odd");
                 }
                 if(input%2 ==0 && input >= 2 && input < 25)
                 {
                     Console.WriteLine(name + ", the number is even and less than 25.");
                 }
                 if (input % 2 == 0 && input >= 26 && input <= 60)
                 {
                     Console.WriteLine(name + ", the number is even");
                 }
                 if (input % 2 == 0 && input > 60)
                 {
                      Console.WriteLine(name + ", the number" + input +" is " + "Even");
                 }
                 if ((input%2 !=0) && input > 60)
                 {
                    Console.WriteLine(name + ",the number " + input + " is " + "Odd");
                 }

             Console.WriteLine("Do you wish to conitue?  (Y/N)");
             string answer= Console.ReadLine();
                             
                if (answer =="Y" || answer=="yes" || answer=="y")
                {

                }
             
                else
                {
                  break;
                }

            }
            
           Console.WriteLine("Thank you for participating");
            Console.ReadLine();
           
        }
    }
}

