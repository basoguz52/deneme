using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolOrnek
{
    internal class Ogrenci
    {
        public Ogrenci(string ad, string soyad,int yas,string meslek)
        {
            Console.WriteLine("\nKİŞİ   BİLGİLER");
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Meslek: " + meslek);

        }
    }
}
