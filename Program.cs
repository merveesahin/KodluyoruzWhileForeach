using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // 1 den baslayarak console dan girilen sayiya kadar ortalama hesaplama (sayi dahil)
            Console.WriteLine("Sayi Giriniz!");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            // a dan z ye kadar tum harfleri console a yazdirma

            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character ++;
            }

            //Foreach

            string[] arabalar = {"bmw","mercedes","nissan"};
            foreach (var araba in arabalar)
            {
               Console.WriteLine(araba);
            }
        }
    }
}
