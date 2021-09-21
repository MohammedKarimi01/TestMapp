using System;
using System.Numerics;

namespace Laboration_1_Mohammed_Karimi
{
    class Program
    {
        static void Main(string[] args)
        {
            string MainString = "29535123p48723487597645723645"; //Här har jag deklarerat min hårdkodade sträng "MainString"

            for (int i = 0; i < MainString.Length; i++)
            {
                if (Char.IsDigit(MainString[i])) // Denna del kollar om Strängen "MainString" har en siffra i sig
                {
                    for (int L = i + 1; L < MainString.Length; L++)
                    {
                        if (MainString[i] == MainString[L]) // Denna del kollar om den första hittade siffran matchar den andra hittade siffran. Och sedan skriver ut samt färgar de matchande delarna.
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(MainString.Substring(i, L - i + 1));
                            break;
                        }
                        else if (!Char.IsDigit(MainString[L]))// Denna del kollar om MainString[L] inte är en siffra, om den inte är det hoppar den tillbaka i loopen och fortsätter.
                        {
                            break;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
