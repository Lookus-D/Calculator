using System;
using System.Threading.Tasks.Sources;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate!");
            //Podaj pierwszą liczbę
            //Podaj drugą liczbę
            //Podaj numer operacji do wykonania
            Console.WriteLine(" ");
            Console.WriteLine("Give me your first number:");
            string first = Console.ReadLine();
            int chosenFirst = 0;
            Int32.TryParse(first, out chosenFirst);

            Console.WriteLine("Give me your second number:");
            string second = Console.ReadLine();
            int chosenSecond = 0;
            Int32.TryParse(second, out chosenSecond);

            Console.WriteLine("1. Addition");  // Dodawanie
            Console.WriteLine("2. Subtraction"); //Odejmowanie
            Console.WriteLine("3. Multiplication"); //Mnożenie
            Console.WriteLine("4. Dzielenie"); //Dzielenie

            string operation = Console.ReadLine();
            int chosenOperation = 0;
            Int32.TryParse(operation, out chosenOperation);

            int resultA = chosenFirst + chosenSecond;
            int resultB = chosenFirst - chosenSecond;
            int resultC = chosenFirst * chosenSecond;
            int resultD = chosenFirst / chosenSecond;

            if (chosenOperation == 1)
            {
                Console.WriteLine($"Addition score: {resultA}");
            }
            else if (chosenOperation == 2)
            {
                Console.WriteLine($"Subtraction score: {resultB}");
            }
            else if (chosenOperation == 3)
            {
                Console.WriteLine($"Multiplication score: {resultC}");
            }
            else if (chosenOperation == 4)
            {
                Console.WriteLine($"Division score: {resultD}");
            }
            else
            {
                Console.WriteLine($"Sorry! Choose another number.");
            }
        }
    }

}
