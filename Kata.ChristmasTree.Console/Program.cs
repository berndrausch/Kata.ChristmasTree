using System;
using System.Linq;
using Kata.ChristmasTree.Logic;

namespace Kata.ChristmasTree.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            var lines = tree.GetLines(5, false);
            foreach( var line in lines)
            {
                Console.WriteLine(line);
            }
            
            Console.ReadLine();
        }
    }
}
