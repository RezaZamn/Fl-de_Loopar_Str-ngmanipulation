using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flöde_Loopar_Strängmanipulation
{
    internal class RepeatTenTimes
    {
        //En metod som skriver ut en mening tiå gångeran rad brytning
        public void StringRepeater()
        {
            Console.WriteLine("Mata in din text: ");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + "." + input + "." + " ");
            }
            Console.WriteLine();
        }
    }
}
