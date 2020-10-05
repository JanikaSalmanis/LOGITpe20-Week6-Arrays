using System;

namespace Week6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = { "win a million", "lose your smartphone", "fall in love", "buy youtube premium", "join the darkside" };
            //Today you will...
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, predictions.Length);
            Console.WriteLine($"Today you will {predictions[randomIndex]}");
        }
    }
}
