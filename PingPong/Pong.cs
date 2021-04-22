using System;

namespace PingPong
{
    static class Pong
    {
        public delegate void EventHandler();
        public static event EventHandler GetPing;
        public static void Game()
        {
            Random mass = new Random();
            int number = mass.Next(0, 100);
            if (number > 10)
            {
                Console.WriteLine("PONG");
                GetPing?.Invoke();
            }
            else
            {
                Console.WriteLine("1:0");
            }
        }

    }
}
