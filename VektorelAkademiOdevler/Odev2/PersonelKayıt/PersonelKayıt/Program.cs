using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelKayıt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "♣  Personel Takip Sistemi ♣";
            Console.WriteLine("***YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ***\n");
            string[] personelListe = new string[99];
            string[] personelDepartman = new string[99];
            int eklenen = 1;
            bool durum = true;
            while (durum)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("---------------------------------------\n" +
                               "\t 1- Personel Ekle \n" +
                              "\t 2- Personel Listele \n" +
                              "\t 3- çıkış\n" +
                               "---------------------------------------\n");
                char secim = Console.ReadKey(true).KeyChar;

                switch (secim)
                {
                    case '1':
                        Console.Write("Personel AD-SOYAD bilgisini giriniz: ");
                        string adSoyad = Console.ReadLine();
                        Console.Write("Personel DEPATRMAN bilgisini giriniz: ");
                        string departman = Console.ReadLine();

                        personelListe[eklenen] += $"{eklenen}   {adSoyad}  [{departman}]";

                        //Console.WriteLine(personelListe[eklenen]);
                        eklenen++;
                        break;
                    case '2':
                        if (eklenen == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Sisteme kayıtlı personel bulunamadı!!! ");
                        }
                        else
                        {

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("******* Sisteme ekli personel bilgi listesi*******\n");
                            //Console.WriteLine("    Ad-Soyad \tDepartman\n    ________ \t_________\n");
                            for (int i = 1; i < eklenen; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }

                                Console.WriteLine(personelListe[i]);
                            }
                        }
                        break;
                    case '3':
                        Console.WriteLine("ÇIKIŞ yapmak istediğinize emin misiniz? [E/H]");
                        Char cıkıs = Console.ReadKey(true).KeyChar;
                        if (cıkıs == 'e' || cıkıs == 'E')
                        {
                            durum = false;
                        }
                        break;
                    default:
                        Console.WriteLine("!!! LÜTFEN GEÇERLİ BİR İŞLEM SEÇİNİZ !!! ");
                        break;
                }
            }
            //Console.ReadKey();
        }
    }
}
