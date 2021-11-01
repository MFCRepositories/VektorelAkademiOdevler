using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrentGame
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Title = "\t ÖLÜMCÜL LABİRENT \t";
            Console.WriteLine("\t ♣♣♣ÖLÜMCÜL LABİRENT OYUNU♣♣♣ \t\n----------------------------------------------------------------");
            Console.WriteLine("Oyuna Başlamak İçin Bilgilerinizi Eksiksiz Olarak  Giriniz:\n");
            Console.Write("Adınız--->\t");
            string ad = Console.ReadLine();
            Console.Write("Soyadınız--->\t");
            string soyad = Console.ReadLine();
            Console.Write("Yaşınız--->\t");
            int can = 3;

            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("UYARI--->Bu oyuna giriş için 18+ olmalısınız!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine($"\t\t MERHABA : {ad} {soyad} \t\n----------------------------------------------------------------\n \t\t ÖLÜMCÜL LABİRENTTESİN \t \n\t Seni burdan çıkarıcak en iyi seçimi yapmalısın \n \t \t \tseçimin ya ÖLÜME \t \n \t \t\t  ya da\t \t \n\t Labirentten ÇIKIŞA açılan kapın olacak! \n \n \t\t oyun can  sayın: ♣ ♥ ♫ \n\n ");

                oyun(can);
            }


            Console.ReadKey();
        }

        private static void oyun(int can)
        {
            while (can > 0)
            {
                string kalp = "";
                for (int i = 0; i < can; i++)
                {
                    kalp = kalp + "♥";
                }

                string tire = "";
                for (int i = 0; i < 70 - can; i++)
                {
                    tire = tire + "-";
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{tire}{kalp}");
                Console.WriteLine($"\t\t -->1<--   -->2<--   -->3<-- \t                    {can}");
                Console.WriteLine($"{tire}{kalp}");
                // Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine();

                char secim = Console.ReadKey(true).KeyChar;
                if (secim == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(
                        "\t Seçimin seni tehlikeli bir yola sürükledi!\t \n\tIzdırap verenlerin yuvasının bulunduğu yerdesin..\n \tBurdan kurtulabilmek için en doğru olanı yap !!!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine(
                        "\t -->1-Solundaki sarmaşığın içindeki haritayı al <--\n  \t \t -->2-Çığlık at ve sesini duyur<--\n   \t-->3-Sarmaşıklardan duvara koruma yap ve saklan<-- \t");
                    Console.WriteLine("----------------------------------------------------------------");
                    char secim1 = Console.ReadKey(true).KeyChar;
                    if (secim1 == '1')
                    {
                        // Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(
                            "\tHarita yemdi! dokunduğun anda sensörler devreye girdi.\n \t\tbulunduğun zemin açıldı içine düştün. \n \tDuvarlar sağ ve soldan 3 dk içinde seni ezerek öldürecek!!! \n\t\t\tBY BYYY!!\t\t\t");
                        can--;
                    }
                    else if (secim1 == '2')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(
                            "Başarabilirdin!!!\n Çığlık atmak seni ölüme dahada yaklaştırdı ÜZGÜNÜM  ızdırap verenler yerini tespit etti \n Parçalanarak öldün!!");
                        can--;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Yaptığın sarmaşık seni saklamakta başarılı oldu");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("\t -->1-orda bekle<--   -->2-) bulunduğun yerden tırmanmaya başla<--   ");
                        Console.WriteLine("----------------------------------------------------------------");

                        char secim2 = Console.ReadKey(true).KeyChar;
                        Console.WriteLine("--------------------------------");
                        if (secim2 == '1')
                        {
                            Console.WriteLine(" beklerken bulunduğun yerden dev bıçak çıktı ve kesilerek ÖLDÜN !!!");
                            can--;
                        }
                        else if (secim2 == '2')
                        {
                            Console.WriteLine(
                                "Tırmanmayı başardın bir helikopter gelip seni alarak labirentten çıkışını sağlayacak  !! ");
                            youWin();
                        }
                    }
                }
                else if (secim == '2')
                {
                    // Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("\t ALEVLİ KAPIYI SEÇTİN VE YANARAK ÖLDÜN\t");
                    Console.WriteLine("----------------------------------------------------------------");
                    can--;
                }
                else if (secim == '3')
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t\t Girdiğin kapı günlük güneşlik :)\n\t\t  yol ayrımına kadar tehlike yok ! YÜRÜ");
                    Console.WriteLine("\t\t Yol ayrımına geldin seçimini yap");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("\t\t -->1-SAĞ<--   -->2-SOL<-- \t ");
                    char secim3 = Console.ReadKey(true).KeyChar;
                    Console.WriteLine("----------------------------------------------------------------");
                    if (secim3 == '1')
                    {
                        // Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Yanlış seçim zehirli duman odasına geldin kurtuluş yok zehirlenerek ÖLDÜN");
                        can--;
                    }
                    else if (secim3 == '2')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\tSİLAH ODASINA GELDİN SİLAHINI SEÇ VE İLERLE ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine(" \t -->1-BIÇAK<--   -->2-OK<--    -->3-TABANCA<--  ");
                        Console.WriteLine("----------------------------------------------------------------");

                        char secim4 = Console.ReadKey(true).KeyChar;
                        if (secim4 == '1')
                        {
                            // Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("önüne Pitongillerden bir yılan çıktı bıçak seni koruyamadı boğularak öldün ");
                            can--;
                        }
                        else if (secim4 == '2')
                        {
                            //Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("*************************************************************");
                            Console.WriteLine(
                                "\t\tÖnüne Pitongillerden bir yılan çıktı!!\t \n\t\tOk atışın iyimiş oyunu başarıyla TAMAMLADIN\t\n  \t\t\tTebrikler !!!!\t\t \n \t\t Seni çıkış için almaya gelcekler\t\n  " +
                                "\t\t---------->KURTULDUNNN:))><------------\t\t");
                            Console.WriteLine("*************************************************************");
                            youWin();
                        }
                        else if (secim4 == '3')
                        {
                            //Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("önüne Pitongillerden bir yılan çıktı mermini kullanamadın ve BOĞULARAK ÖLDÜN");
                            can--;
                        }
                    }
                }


                if (can == 0)
                {
                    Console.Clear();
                    GameOver();
                    Secim();
                    //break;
                }

            }

        }

        private static void youWin()
        {
            //kazandığında
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\t\t\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t\t    YY     YY  OOOOOOOOO  UU     UU");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t     YY   YY   OO     OO  UU     UU");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t      YY YY    OO     OO  UU     UU");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t       YYY     OO     OO  UU     UU");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t       YY      OO     OO  UU     UU");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t       YY      OO     OO  UU     UU");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t       YY      OO     OO  UU     UU");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t       YY      OOOOOOOOO  UUUUUUUUU");
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\tWW             WW  IIIIIIIIIIIII  NNN     NN");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\tWW             WW       III       NN NN   NN");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tWW     WWWW    WW       III       NN  NN  NN");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tWW    WW  WW   WW       III       NN   NN NN");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\tWW   WW    WW  WW       III       NN    NNNN");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\tWW WW       WW WW       III       NN     NNN");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tWWWW         WWWW  IIIIIIIIIIIII  NN      NN");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Secim();
        }

        private static void Secim()
        {
            Console.WriteLine("\n\tçıkış için [1] ya basın  devam etmek için [2] basın ");
            char secimCıkıs = Console.ReadKey(true).KeyChar;

            switch (secimCıkıs)
            {
                case '1':
                    Environment.Exit(0);
                    break;
                case '2':
                    Console.Clear();
                    oyun(3);
                    break;
                default:
                    Console.WriteLine("Geçerli bir tuşa basınız[e/q]:");
                    break;
            }
        }

        private static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("GGGGGGGGGG    AAAAAAAAAA   MMMM     MMMM   EEEEEEEEEE    OOOOOOOOOO  VVVV           VVVV  EEEEEEEEEE  RRRRRRRRRR ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("GG            AA      AA   MMMMM   MMMMM   EE            OO      OO   VVVV         VVVV   EE          RR     RR");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("GG            AA      AA   MMMMMM MMMMMM   EE            OO      OO    VVVV       VVVV    EE          RR    RR");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("GGGGGGGGGG    AAAAAAAAAA   MMMM  M  MMMM   EEEEEEEEEE    OO      OO     VVVV     VVVV     EEEEEEEEE   RRRRR ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("GG      GG    AA      AA   MMM       MMM   EE            OO      OO      VVVV   VVVV      EE          RR     RRR ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("GG      GG    AA      AA   MMM       MMM   EE            OO      OO       VVVV VVVV       EE          RR      RRR ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("GGGGGGGGGG    AA      AA   MMM       MMM   EEEEEEEEEE    OOOOOOOOOO        VVVVVVV        EEEEEEEEEE  RR       RRR");


        }

    }
}
