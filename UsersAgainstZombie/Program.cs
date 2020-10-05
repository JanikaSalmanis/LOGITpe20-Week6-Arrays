using System;

namespace UsersAgainstZombie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The programm asks the user to enter the names of
             five intems from the users bag.
            The program displays a random pick from the users bag
            to fight off zombies with.
            "In case of zombie apocalypse you will have to
            fight zombies with{random intem from the bag}"
            */
            string[] userBag = new string[5];
            int i = 0;
            while(i < userBag.Length)
            {
                Console.WriteLine("whats there in you bag?");
                userBag[i] = Console.ReadLine();
                i++;
            }
            Random rnd = new Random();
            Console.WriteLine($"In case of zombie apocalypse you will have to +" +
                $"fight zombies with{userBag[rnd.Next(0, userBag.Length)]}");
        }
    }
}
