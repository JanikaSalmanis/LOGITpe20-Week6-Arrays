using System;
using System.Drawing;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = { "hat", "hoodie", "jeans", "dress", "shirt" };
            string[] color = { "red", "blue", "white", "green", "pink" };
            string[] patterns = { "flowery", "striped", "polka dot", "circles", "checkered" };
            /*The program asks if the user needs help with picking an outfift
             * If the users answer no, the console dispays "Farewell"
             * If users confirms, the program displays the combination of pattern, color and cholting intem "Today you should wear..*/
            Random rnd = new Random();
            Console.WriteLine("Would you like some fashio advice?");
            string userInput = Console.ReadLine();
            if(userInput == "no")
            {
                Console.WriteLine("Farewell!");
            }else
            {
                Console.WriteLine($"Today you should wear " +
                    $"{color[rnd.Next(0, color.Length)]} " +
                    $"{patterns[rnd.Next(0, patterns.Length)]} " +
                    $"{wardrobe[rnd.Next(0, wardrobe.Length)]}");
            }

        }
    }
}
