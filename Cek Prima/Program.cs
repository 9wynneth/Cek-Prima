using System;

namespace Cek_Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silahkan input suatu bilangan");
            int InputBilangan = Convert.ToInt32(Console.ReadLine());
            var Faktor = 0;
            for (int i=1;i<=InputBilangan;i++)
            {
                if (InputBilangan%i==0)
                {
                    Faktor++;
                }
            }
            if (Faktor==2)
            {
                Console.Write("Bilangan tersebut merupakan bilangan prima");
            }
            else
            {
                Console.Write("Bilangan tersebut BUKAN merupakan bilangan prima");
            }
           
        }
    }
}
