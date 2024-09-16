using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Flöde_Loopar_Strängmanipulation
{
    internal class PriceCalculation
    {
        public void PriceCalculate()
        {
            // Alla variabler är nollställda från början
            int youth = 0;
            int pensioner = 0;
            int childAndPensioner = 0;
            int standard = 0;
            int totalBiljettPris = 0;

            Console.WriteLine("Mata in hur många personer är på besök:");
            int totalVisitor = int.Parse(Console.ReadLine());         //Matar in hur många personer är på besök



            for (int i = 0; i < totalVisitor; i++)
            {

                Console.WriteLine($"Mata in åldern för besökaren nummer " + (i + 1));
                int age = int.Parse(Console.ReadLine());            //Matar in åldern på alla besökaren genom loop


                if (age < 5 || age > 100)
                {
                    childAndPensioner = 0;
                }

                else if (age < 20)
                {
                    youth = youth + 80;                         //Biljett pris addas till för varje person
                }

                else if (age > 65)
                {
                    pensioner = pensioner + 90;
                }

                else if (!(age > 65 && age < 20))
                {
                    standard = standard + 120;
                }

                totalBiljettPris = youth + pensioner + standard + childAndPensioner;       //Sparar totalkostnaden                              

            }
            Console.WriteLine("Antal personer är: " + totalVisitor);
            Console.WriteLine("Totalkostnad för hela sällskapet är: " + totalBiljettPris + "kr");



        }

    }
}
