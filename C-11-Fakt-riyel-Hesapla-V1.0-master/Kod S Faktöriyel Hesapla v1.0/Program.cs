using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Faktöriyel_Hesapla_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            double Sonuc = 1;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Sonuc *= i;
            }

            Console.WriteLine();

            Console.Write(n + "!=" + Sonuc);

            Console.ReadKey();
        }
    }
}
