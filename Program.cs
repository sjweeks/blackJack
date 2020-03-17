using System;
using System.Collections.Generic;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Game playGame = new Game();
            playGame.initialise();
        }
    }
}
