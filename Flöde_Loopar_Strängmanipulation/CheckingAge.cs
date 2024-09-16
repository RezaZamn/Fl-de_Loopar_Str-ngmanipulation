using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flöde_Loopar_Strängmanipulation
{
    internal class CheckingAge
    {

        public void CheckAge()
        {
            Console.WriteLine("Mata in hur gammal är du?");
            string age = Console.ReadLine();
            int parsedAge;

            if (int.TryParse(age, out parsedAge))   //Kollar ifall användaren skriver bokstäver istället for tal
            {
                 if (parsedAge < 5 || parsedAge > 100)
                {
                    if (parsedAge < 5)
                    {
                        Console.WriteLine("Barn: Gratis");

                    }

                    if (parsedAge > 100)
                    {
                        Console.WriteLine("Pensionär över 100 år: Gratis");

                    }
                }

                else if (parsedAge > 64)
                {
                    Console.WriteLine("Pensionärspris: 90kr");
                }

               

                else if (parsedAge < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr");
                }

                else
                {
                    Console.WriteLine("Standardpris: 120kr");
                }

            }

            else         
            {
                Console.WriteLine("You must input your age with number, Try Again. ");
            }

            Console.WriteLine();


        }
    }
}
