using System;
using CSharpExamples.Shared;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CSharpExamples
{
    class Testing
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return $"You're a terrible person";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var value = new[] { 1, 2, 3, 4, 5 };

            var index = value.BinarySearch(4);

            var game = new SnakeGame(70, 40);

            // TODO: use the game instance's start method to begin the game
            
            game.Start();
            
        }

        
    }
}
