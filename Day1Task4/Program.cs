using System;

namespace Day1Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "ade", "bode", "casey", "dash" };
            for(int i = 0; i<arr.Length; i++)
            {
                if(arr[i] == "casey")
                {
                    Console.WriteLine("Hello, I'm Casey");
                    break;

                } else if(arr[i] == "ade")
                {
                    Console.WriteLine("Hello, I'm Ade");

                } else if(arr[i] == "bode")
                {
                    Console.WriteLine("Hello, I'm Bode");
                    continue;

                }
                Console.WriteLine("{0} is a Genie", arr[i]);
            }
        }
    }
}