using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı tarafındna girilen n adet sayının tek olanları bir diziye cıft olanları
            //baska bir dızıye yerlestiren program
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dt = new int[n];
            int[] dc = new int[n];
            int st = 0;
            int sc = 0;
            for (int i = 0; i < n; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    dc[sc] = sayi;
                    sc++;
                }
                else
                {
                    dt[st] = sayi;
                    st++;
                }
            }
            Console.WriteLine("Cift Sayilar");
            for (int i = 0; i < sc; i++)
            {
                Console.Write(dc[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Tek Sayilar");
            for (int i = 0; i < st; i++)
            {
                Console.Write(dt[i] + " ");
            }
        }
    }
}
