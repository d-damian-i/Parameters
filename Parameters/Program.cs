using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters {
    class Program {
        static void Main(string[] args) {


            int pizzas = askInt("How many pizzas would you like");
            string name = askString("What is your name");
            double num = askDouble("Enter a double");
            char letter = askChar("Enter your favourite character");

        }

        static int askInt(string question) {

            while (true) {
                Console.Write(question + ": ");
                try {
                    int value = int.Parse(Console.ReadLine());
                    return value;
                } catch {

                    Console.WriteLine("Please enter an integer");

                }
            }

        }

        static string askString(string question) {
            while (true) {

                Console.Write(question + ": ");
                string name = Console.ReadLine();
                int numericalValue;

                if (int.TryParse(name, out numericalValue)) {

                    Console.WriteLine("Please dont enter numbers");
                } else {

                    return name;
                }
            }       
        }

        static double askDouble(string question) {

            while (true) {
                Console.Write(question + ": ");
                try {
                    double value = double.Parse(Console.ReadLine());
                    return value;
                } catch {

                    Console.WriteLine("That is not a double");

                }
            }
        }

        static char askChar(string question) {
            while (true) {
                Console.Write(question + ": ");
                try {
                    char value = char.Parse(Console.ReadLine());
                    return value;
                } catch {

                    Console.WriteLine("That is not a character dummy");

                }
            }
        }
    }
}
