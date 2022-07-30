using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 20;
            int sayi2 = 10;

            Generic(sayi1, sayi2);
            Console.WriteLine(Generic(sayi1, sayi2));
            Console.ReadLine();
        }
        public static string Generic<T, B>(T sayi1, B sayi2)
        {

           
            return sayi1.ToString() + sayi2.ToString();


       }
    }
}
