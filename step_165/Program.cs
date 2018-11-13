using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_165
{
    class Program
    {
        static void Main(string[] args)
        {          
            try
            {
                Console.WriteLine("Please enter your age:");
                int userInput1 = Convert.ToInt32(Console.ReadLine());
                int currentYear = Convert.ToInt32(DateTime.Now.Year.ToString());
                int yearBorn = currentYear - userInput1;
                int yearBornAlternate = yearBorn - 1;
                Console.WriteLine("You were born in {0}/{1}", yearBornAlternate, yearBorn);
                if (userInput1 == 0)
                {
                    throw new ArgumentException();           
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Your age cannot be zero.");               
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number:");                            
            }    
            
            Console.ReadLine();

        }
    }
}
