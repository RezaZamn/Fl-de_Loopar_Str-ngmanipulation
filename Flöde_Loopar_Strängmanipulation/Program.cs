namespace Flöde_Loopar_Strängmanipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = true;

            do         
            {      //Programmets menyval
                Console.WriteLine("Det här är huvudmenyn,ni kan komma åt funktioner nedan med tillhörande nummer." +
                    "\n - - - - - - - - - - - - - - - - - - - - - - - -" +
                       "\n1: Biljett priser" +
                       "\n2: Räknar ut totala kostnaden" +
                       "\n3: Upprepar tio gånger en text" +
                       "\n4: Hittar Det tredje ordet i en text" +
                       "\n0: Slutar programmet" + 
                    "\n - - - - - - - - - - - - - - - - - - - - - - - -");

                Console.WriteLine("Mata i ett av nummret ovan för att starta programmet:");
                string input = Console.ReadLine();
                int parsedInput;                       

                switch (input)
                {
                    case "0":
                     isAlive = false;
                        break;

                    case "1":
                        CheckingAge menyval1 = new CheckingAge();
                        menyval1.CheckAge();
                        break;


                    case "2":
                        PriceCalculation menyval2 = new PriceCalculation();
                        menyval2.PriceCalculate();
                        break;

                    case "3":
                        RepeatTenTimes menyval3 = new RepeatTenTimes();
                        menyval3.StringRepeater();
                        break;

                    case "4":
                        TheThirdWord menyval4 = new TheThirdWord();
                        menyval4.PickingTheThirdWord();
                        break;

                    default:               //Kollar ifall användaren inte matar in ett relevant värde
                        if (!int.TryParse(input, out parsedInput) || parsedInput > 5)
                        {
                            Console.WriteLine("You must input a number between 0 to 4, Try Again! ");

                        }
                        break;

                }
                
              Console.WriteLine();
            } while (isAlive);          //Programmet körs tills användaren avslutar programmet

        }
    }
}
