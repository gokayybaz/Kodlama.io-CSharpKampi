using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslem_CSharpTemelleri2
{
    public class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Girilen sayıların toplamı : "+toplam);
        }

        public void Cikar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Girilen sayıların çıkarma sonucu : "+sonuc);
        }

        public void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Girilen sayıların çarpımı : "+sonuc);
        }

        public void Bol(int sayi1, int sayi2) 
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("Girilen sayıların bölümü : "+sonuc);
        }
    }
}
