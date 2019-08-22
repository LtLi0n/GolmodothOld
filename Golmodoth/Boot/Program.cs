using Golmodoth.Engine;
using System;

namespace Golmodoth
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConsoleWindow().Construct(75, 50, 10, 15, ConsoleGameEngine.FramerateMode.MaxFps);
        }
    }
}
