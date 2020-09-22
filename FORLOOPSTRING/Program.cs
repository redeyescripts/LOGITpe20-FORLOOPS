using System;

namespace FORLOOPSTRING
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //USERNAME
            //Shows the name vertically
            string name = "POTTER";
          

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i}. {name[i]}");
            }
        }
    }
}
