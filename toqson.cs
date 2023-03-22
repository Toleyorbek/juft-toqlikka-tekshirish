using System;
using System.Collections.Immutable;

namespace dotnetuz
{
    public class Program
    {
        public static void Main(string[] args)
        {
           

            Console.WriteLine("SON KIRITING");
            int son=int.Parse(Console.ReadLine());
            if (son == 0) 
            {
                Console.WriteLine("0 toq ham juft ham emas");
            }
            if (son!=0&&son % 2 == 0)
            {
                Console.WriteLine("JUFT SON");
            }
            if (son % 2==1) 
            {
                Console.WriteLine("toq son");
            }





        }
    }
}
