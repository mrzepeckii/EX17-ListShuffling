using System;

namespace ListShuffling
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shuffle shuffle = new Shuffle();
            shuffle.ReadLists();
            shuffle.Shuffling();
        }
    }
}
