using System;
using System.Numerics;

namespace Laboration_1_Mohammed_Karimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gjort av Mohammed Karimi - Labaration 1 
            // 2021-09-22

            string MainString = "29535123p48723487597645723645";
            string substring = string.Empty;                //Denna sträng sparars alla hittade tal.
            string FirstSubstringMatch = String.Empty;      //Denna sträng sparar de hittade talen innan den har hittat ett mönster.
            string SecondSubstringMatch = string.Empty;     //Denna sträng sparar de talen den hittar efter att den har hittat ett mönster.
            Decimal TotalAmount = 0;

            for (int i = 0; i < MainString.Length; i++)
            {
                int temp = 0;
                bool isNumber = int.TryParse(MainString[i] + "", out temp);
                if (isNumber == false)                      //Denna loop kollar om IsNumber Är ett nummer eller ej, om det är ett tal fortsätter programmet.
                {
                    continue;
                }

                for (int j = i + 1; j < MainString.Length; j++)
                {

                    if (!char.IsDigit(MainString[j]))       //Denna Loop kontrollerar om angivet tal i 'MainString' är inte en siffra, om det inte är det slutar loopen.
                    {
                        break;
                    }
                    if (MainString[i] == MainString[j])
                    {
                        substring = MainString.Substring(i, j - i + 1);//Denna Sträng sparar mönster som den hittat i substringen.

                        Decimal result;
                        Decimal.TryParse(substring, out result);
                        TotalAmount += result;  //Denna bit adderar de två olika talen och räknar ut summan på dem.

                        FirstSubstringMatch = MainString.Substring(0, MainString.IndexOf(substring)); //Denna del kollar alla de första siffrorna innan p:et, och sparar de hittade mönsterna och skriver ut den.
                        SecondSubstringMatch = MainString.Substring(substring.Length + FirstSubstringMatch.Length, (MainString.Length) - (substring.Length + FirstSubstringMatch.Length));
                        // Denna del åvan kollar de sista siffrorna efter p:et och sparar mönsterna samt skriver ner den.

                        //Denna bit färgar de olika delarna i strängen, och skriver ut dem.
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(FirstSubstringMatch);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(substring);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(SecondSubstringMatch);
                        break;
                    }
                }
            }
            //Denna bit skriver ut den totala summan av de två talen samt färgar dem lite snyggt.
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Den totala summan är: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(TotalAmount + "\n");
            Console.ResetColor();
        }
    }
}
