using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakit_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEĞİŞKENLERİN TANIMLANMASI BU ALANDA YAPILDI.
            double dizel = 3.12, benzin = 3.28, lpg = 1.78;
            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
            double satismiktari = 0;
            char anamenusecim = '0', altmanusecim = '0', akaryakitfiyatgüncelle = '0', akaryakitsatistipi = '0';

            MENU:
            Console.WriteLine("Akaryakıt Satış Takip");
            Console.WriteLine(".....................");
            Console.WriteLine("1-Birim Fiyat Göster");
            Console.WriteLine("2-Birim Fiyat Güncelle");
            Console.WriteLine("3-Akaryakıt Satışı Yap");
            Console.WriteLine("4-Depo Durumunu Göster");
            Console.WriteLine("5-Toplam Satışları Göster");
            Console.WriteLine("6-Çıkış");

            Console.WriteLine("Seçiminizi Yapınız? [1,2,3,4,5,6]");
            anamenusecim = Convert.ToChar(Console.ReadLine());
            if (anamenusecim=='1')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:1");
                Console.WriteLine("---Birim Fiyat Göster---");
                Console.WriteLine("Dizel (D):{0} TL/Litre", dizel);
                Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);
                Console.WriteLine("LPG (L):{0} TL/Litre", lpg);
                ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız! [1:Ana Menüye Dön//2:Programı Kapat]");
                altmanusecim = Convert.ToChar(Console.ReadLine());
                if (altmanusecim=='1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmanusecim=='2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim=='2')
            {
                Console.WriteLine(">>Seçiminiz:2");
                Console.WriteLine("---Birim Fiyat Güncelle");
                AKARYAKITTIPI:
                Console.WriteLine("Akarkayıt Tipini Seçiniz? [D/B/L]");
                akaryakitfiyatgüncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakitfiyatgüncelle=='D' || akaryakitfiyatgüncelle=='d')
                {
                    Console.WriteLine("Güncel Dizel Fiyat:{0} TL/Litre",dizel);
                    Console.WriteLine("Yeni Güncel Dizel Fiyatı Giriniz:");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Güncelleme başarı ile yapılmıştır.");
                    Console.WriteLine("Dizel (D) {0} TL/Litre", dizel);
                }
                else if (akaryakitfiyatgüncelle=='B' || akaryakitfiyatgüncelle=='b')
                {
                    Console.WriteLine("Güncel Benzin Fiyat:{0} TL/Litre", benzin);
                    Console.WriteLine("Yeni Güncel Benzin Fiyatı Giriniz:");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Güncelleme başarı ile yapılmıştır.");
                    Console.WriteLine("Benzin (B) Fiyat:{0} TL/Litre", benzin);
                }
                else if (akaryakitfiyatgüncelle=='L' || akaryakitfiyatgüncelle=='l')
                {
                    Console.WriteLine("Güncel LPG Fiyat:{0} TL/Litre", lpg);
                    Console.WriteLine("Yeni Güncel LPG Fiyatı Giriniz:");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Güncelleme başarı ile yapılmıştır.");
                    Console.WriteLine("LPG (L) Fiyat:{0} TL/Litre", lpg);
                }
                else
                {
                    Console.WriteLine("[D/B/L] Seçiminiz hatalıdır!");
                    goto AKARYAKITTIPI;
                }
                ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız! [1:Ana Menüye Dön//2:Programı Kapat]");
                altmanusecim = Convert.ToChar(Console.ReadLine());
                if (altmanusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmanusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim=='3')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:3");
                Console.WriteLine("Akaryakıt Satışı Yap");
                AKARYAKITTIPI:
                Console.WriteLine("[D,B,L] Akaryakıt Tipini Seçiniz?");
                akaryakitsatistipi = Convert.ToChar(Console.ReadLine());
                if (akaryakitsatistipi == 'D' || akaryakitsatistipi == 'd')
                {
                    if (dizeltank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç dizel yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else 
                    {
                        Console.WriteLine("Ne kadar dizel yakıt alınacak?");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (dizeltank<satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} Litre dizel yakıt vardır.İşlem Yapılamadı!", dizeltank);
                            goto MENU;
                        }
                        else if (satismiktari<=dizeltank)
                        {
                            dizeltank = dizeltank - satismiktari;
                            Console.WriteLine("Yakıt dolumu tamamlanmıştır.");
                            Console.WriteLine("Yakıt tankında {0} Litre dizel yakıt kalmıştır.", dizeltank);
                        }
                    }
                }

                else if (akaryakitsatistipi=='B' || akaryakitsatistipi=='b')
                {
                    if (benzintank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç benzin yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadar benzin yakıt alınacak?");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (benzintank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} Litre benzin yakıt vardır.İşlem Yapılamadı!", benzintank);
                            goto MENU;
                        }
                        else if (satismiktari <= benzintank)
                        {
                            benzintank = benzintank - satismiktari;
                            Console.WriteLine("Yakıt dolumu tamamlanmıştır.");
                            Console.WriteLine("Yakıt tankında {0} Litre benzin yakıt kalmıştır.", benzintank);
                        }
                    }
                }

                else if (akaryakitsatistipi == 'L' || akaryakitsatistipi == 'l')
                {
                    if (lpgtank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç LPG yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadar LPG yakıt alınacak?");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (lpgtank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} Litre LPG yakıt vardır.İşlem Yapılamadı!", lpgtank);
                            goto MENU;
                        }
                        else if (satismiktari <= lpgtank)
                        {
                            lpgtank = lpgtank - satismiktari;
                            Console.WriteLine("Yakıt dolumu tamamlanmıştır.");
                            Console.WriteLine("Yakıt tankında {0} Litre LPG yakıt kalmıştır.", lpgtank);
                        }
                    }
                }

                else
                {
                    Console.WriteLine("[D,B,L] Dışında hatalı bir seçim yaptınız!");
                    goto AKARYAKITTIPI;
                }
                ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız! [1:Ana Menüye Dön//2:Programı Kapat]");
                altmanusecim = Convert.ToChar(Console.ReadLine());
                if (altmanusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmanusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim=='4')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:4");
                Console.WriteLine("---Depo Durumunu Göster---");
                Console.WriteLine("Dizel Yakıt Durumu: %{0}", (dizeltank / 10));
                Console.WriteLine("Benzin Yakıt Durumu: %{0}", (benzintank / 10));
                Console.WriteLine("LPG Yakıt Durumu: %{0}", (lpgtank / 10));
                ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız! [1:Ana Menüye Dön//2:Programı Kapat]");
                altmanusecim = Convert.ToChar(Console.ReadLine());
                if (altmanusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmanusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim=='5')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:5");
                Console.WriteLine("---Toplam Satışları Göster---");
                Console.WriteLine("Satılan Toplam Dizel Yakıt:{0}", (1000 - dizeltank));
                Console.WriteLine("Satılan Dizel Yakıt Tutarı:{0}", (1000 - dizeltank) * dizel);
                Console.WriteLine("Satılan Toplam Benzin Yakıt:{0}", (1000 - benzintank));
                Console.WriteLine("Satılan Benzin Yakıt Tutarı:{0}", (1000 - benzintank) * benzin);
                Console.WriteLine("Satılan Toplam LPG Yakıt:{0}", (1000 - lpgtank));
                Console.WriteLine("Satılan LPG Yakıt Tutarı:{0}", (1000 - lpgtank) * lpg);
                Console.WriteLine("____________________________");
                Console.WriteLine("Toplam Satış Tutarı:{0}", ((1000 - dizeltank) * dizel) + ((1000 - benzintank) * benzin) + ((1000 - lpgtank) * lpg));
                ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız! [1:Ana Menüye Dön//2:Programı Kapat]");
                altmanusecim = Convert.ToChar(Console.ReadLine());
                if (altmanusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmanusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim=='6')
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış Seçim Yaptınız! [1,2,3,4,5,6]");
                goto MENU;
            }
        }
    }
}
