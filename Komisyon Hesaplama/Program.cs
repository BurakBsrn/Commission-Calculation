using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komisyon_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double malFiyati = 0, komisyonMiktari = 0, toplamKomisyon = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}. Malın Fiyatını Giriniz : ", i + 1);
                malFiyati = Convert.ToDouble(Console.ReadLine());
                if (malFiyati > 50) komisyonMiktari = malFiyati * 0.02;
                else komisyonMiktari = malFiyati * 0.03;
                Console.WriteLine("{0}. Mal İçin Komisyon Miktarı : {1}", i + 1, komisyonMiktari);
                toplamKomisyon += komisyonMiktari;
            }
            Console.WriteLine("Toplam Komisyon Miktarı : {0}", toplamKomisyon);
        }
    }
}
