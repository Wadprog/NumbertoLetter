using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string _ProgramLife = "";
            // Pause the program untill you enter "Exit"
            while (_ProgramLife != "exit")
            {
                Console.WriteLine("Enter a number: ");
                string number = Console.ReadLine();
                Console.WriteLine(NumberToLetter(number));
                _ProgramLife = number;
            }
        }

        private static string NumberToLetter(string number) {
            string[] Units = { "Zero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ochp", "Nueve" }; ;
            string[] ThenthLowerThanTwentyOnes = {"Diez","Once","Doze","Treze","Catorze","Quince","Diecisiete", "Diecisiete", "Dieciocho","Diecinueve","Veinte"};
            const string TwentyOneOver = "Venti";
            string[] TenthOvertwenty={"Treinta", "Cuarenta","Cicuenta","Sesenta","Setenta","Ochenta","Noventa"};
              string[] categories = {
                "Units","Tenth","Hundreds","Thousands","Ten-Thousands","hundred-thousands",
                "Million","Ten-millions","Hundred-millions","Thousands-millions","Ten-thousands-millions","Hundred-thousands-millions",
                "Billions","Ten-Billions","Hundred-billions","Thousand-billions","Ten-thousands-billions","Hundred-thousands-billions",
                "TOO-BIG"
            };
            string letterValue = "";
            switch (NumberClassifier(number)){

                case "Units":
                    letterValue = Units[Convert.ToInt32(number)];
                    break;

                case "Tenth":
                    int numberValue = Convert.ToInt32(number);
                    if (numberValue <= 20) letterValue = ThenthLowerThanTwentyOnes[numberValue - 10];
                    else if (numberValue <= 29) letterValue = TwentyOneOver + Units[numberValue % 10];
                    else letterValue = TenthOvertwenty[numberValue / 10 - 3] + "-y-" + Units[numberValue % 10];
                    break;
                case "Hundreds":
                    letterValue = "working on it ";
                    break;

                default:
                    letterValue = "none";
                    break;
            }
            return letterValue;
        }
        private static string NumberClassifier(string number)
        {
            int numSize = number.Length;
            string[] categories = {
                "Units","Tenth","Hundreds","Thousands","Ten-Thousands","hundred-thousands",
                "Million","Ten-millions","Hundred-millions","Thousands-millions","Ten-thousands-millions","Hundred-thousands-millions",
                "Billions","Ten-Billions","Hundred-billions","Thousand-billions","Ten-thousands-billions","Hundred-thousands-billions",
                "TOO-BIG"
            };
            return categories[numSize-1];

        }
    }
}
