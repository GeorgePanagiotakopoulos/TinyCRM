using System;

namespace TinyCRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me your AFM");
            IsValidAfm("9090");

        }
        public static bool IsValidAfm(string afm)
        { int numericafm;
        
        if (int.TryParse(afm))
            {

            }
         }
    }
}
