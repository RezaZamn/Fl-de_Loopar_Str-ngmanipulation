using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Flöde_Loopar_Strängmanipulation
{
    internal class TheThirdWord
    {
        public void PickingTheThirdWord()
        {
            Console.WriteLine("Mata in din text: ");
            var input = Console.ReadLine();          //Matar in text
            string[] storedText = input.Split(' ');  //Lagrar inmatade texten in en Array

            //Kollar villkoren att texten är mer än tre ord och att texten innehåller bara bokstäver
            if (IsWord(input) && (storedText.Length >= 3))
            {
                Console.WriteLine("Tredje ordet i texten är: " + storedText[2]);  //Skriver ut tredje orden av texten
                Console.WriteLine("Texten inehåller " + storedText.Length + " ord");  //Skriver ut antal orden i texten
            }
            else
            {
                 
                Console.WriteLine("You must input words,the text contains non-letter characters.Try again!");
            }

        }
        //En metod som kollar om att texten innehåller bara bokstäver
        public static bool IsWord(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }

            }
            return true;

        }

    }
}