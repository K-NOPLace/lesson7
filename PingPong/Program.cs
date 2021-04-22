using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping.GetPong += Pong.Game;
            Pong.GetPing += Ping.Game;
            Random mass = new Random();
            int number = mass.Next(0, 100);
            if (number > 10)
            {
                Ping.Game();
            }
            else
            {
                Pong.Game();
            }
        }
    }
}
