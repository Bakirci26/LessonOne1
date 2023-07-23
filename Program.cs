using System;

namespace LessonOne1
{
    class Program
    {
        static void Main(string[] args)
        {   //type safety _ tip güvenliği
            //Do not repeat your self- Kendini tekrarlama
            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;

            double FaizOrani = 1.45;

            bool SistemGirisYapmısMi = false;

            double DolarDun = 20.00;

            double DolarBugün = 22.00;


            if (SistemGirisYapmısMi == true)
            {
                Console.WriteLine("Sisteme Giris Yapildi");
            }
            else
            {
                Console.WriteLine("Sisteme Giris Yapilmadi");
            }

            Console.WriteLine(kategoriEtiketi);

            if (DolarBugün > DolarDun)
                {
                    Console.WriteLine("Dolar Artmıs");
                }

                else if (DolarDun < DolarBugün)
                {
                    Console.WriteLine("Dolar Düsmüs");
                }
                else
                {
                    Console.WriteLine("Dolar Sabit");
                } 
            //Simule ettik için ,Eğitim için 
        }
    }
}
