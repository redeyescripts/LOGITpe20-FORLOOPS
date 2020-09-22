using System;

namespace BackwardsString
{
    class Program
    {
        static void Main(string[] args)
        {
           /// Console.WriteLine("Hello World!");
          //  Console.WriteLine("Hello, Whats your name?");
           //string Name;
            //Name = Console.ReadLine();
            //Console.WriteLine("Hello, " + Name);

            
            string name = "POTTER";
            Console.WriteLine(name[5]);
            
            

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);

            }
        }
    }
}
