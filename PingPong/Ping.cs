using System;

namespace PingPong
{
    static class Ping
    {
        public delegate void EventHandler();
        public static event EventHandler GetPong;
        public static void Game()
        {
            Random mass = new Random();
            int number = mass.Next(0, 100);
            if (number > 10)
            {
                Console.WriteLine("PING");
                GetPong?.Invoke();
            }
            else
            {
                Console.WriteLine("0:1");
            }
        }

    }
}
