using System;
using System.IO;

namespace TinyCRM
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\panag\devel\TinyCRM\TinyCrm\TinyCRM\productlist.csv";

            if (!File.Exists(path))
            {
                // Create a file to write to.
               string[] createText = { "Hello", "And", "Welcome" };
               File.WriteAllLines(path, createText);
            }

               // Open the file to read from.
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }

        }
    }
}
