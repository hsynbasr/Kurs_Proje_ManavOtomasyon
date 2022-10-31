using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manav_otomasyon_güncel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList toptancimeyve = new ArrayList() { "ELMA", "ARMUT", "MUZ", "KİRAZ", "ŞEFTALİ", "ÇİLEK" };
            ArrayList toptancisebze = new ArrayList() { "MARUL", "LİMON", "HAVUÇ", "LAHANA", "PIRASA", "ISPANAK" };
            ArrayList manavmeyve = new ArrayList();
            ArrayList manavsebze = new ArrayList();
            ArrayList manavkilomeyve = new ArrayList();
            ArrayList manavkilosebze = new ArrayList();
            ArrayList musteri = new ArrayList();
            ArrayList musterikilo = new ArrayList();
            Console.WriteLine("*************MANAV OTOMASONU**************");
            Console.WriteLine("-------------------------------------------");


            while (true)
            {
                while (true)
                {
                    Console.WriteLine("********MEYVE SEBZE HALİNE HOŞGELDİNİZ*********");
                    Console.WriteLine("Meyve için M Sebze için S ye basınız?");
                    string toptansecim = Console.ReadLine().ToUpper();
                    if (toptansecim == "M")
                    {
                        Console.WriteLine("--------------------------------------------------");
                        foreach (var item in toptancimeyve)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Hangi Üründen amak istiyorsunuz?");
                        string manavcialisveris = Console.ReadLine().ToUpper();
                        if (toptancimeyve.IndexOf(manavcialisveris) >=0)
                        {
                            Console.Write("\nKaç kilo almak istiyorsunuz ?  >>>=  ");
                            int alisveriskilo = Convert.ToInt32(Console.ReadLine());

                            if (manavmeyve.IndexOf(manavcialisveris)>=0)
                            {
                                manavkilomeyve[manavmeyve.IndexOf(manavcialisveris)] = (int)manavkilomeyve[manavmeyve.IndexOf(manavcialisveris)] + alisveriskilo;
                                Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                                string evethayir = Console.ReadLine().ToUpper();
                                if (evethayir == "E")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                manavmeyve.Add(manavcialisveris);
                                manavkilomeyve.Add(alisveriskilo);
                                Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                                string evethayir = Console.ReadLine().ToUpper();
                                if (evethayir == "E")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Elimizde "+manavcialisveris+" yok maalesef efendim.");
                            Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                            string evethayir = Console.ReadLine().ToUpper();
                            if (evethayir == "E")
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                       
                        
                            
                        
                    }
                    else if (toptansecim=="S")
                    {
                        Console.WriteLine("--------------------------------------------------");
                        foreach (var item in toptancisebze)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Hangi Üründen amak istiyorsunuz?");
                        string manavcialisveris = Console.ReadLine().ToUpper();
                        if (toptancisebze.IndexOf(manavcialisveris) >= 0)
                        {
                            Console.Write("\nKaç kilo almak istiyorsunuz ?  >>>=  ");
                            int alisveriskilo = Convert.ToInt32(Console.ReadLine());

                            if (manavsebze.IndexOf(manavcialisveris) >= 0)
                            {
                                manavkilosebze[manavsebze.IndexOf(manavcialisveris)] = (int)manavkilosebze[manavsebze.IndexOf(manavcialisveris)] + alisveriskilo;
                                Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                                string evethayir = Console.ReadLine().ToUpper();
                                if (evethayir == "E")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                manavsebze.Add(manavcialisveris);
                                manavkilosebze.Add(alisveriskilo);
                                Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                                string evethayir = Console.ReadLine().ToUpper();
                                if (evethayir == "E")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Elimizde " + manavcialisveris + " yok maalesef efendim.");
                            Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                            string evethayir = Console.ReadLine().ToUpper();
                            if (evethayir == "E")
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }

                    }

                }
                while (true)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("\n********************MANAVA HOŞGELDİNİZ*******************");
                    Console.WriteLine("Meyve için M Sebze için S ye basınız?");
                    string manavsecim = Console.ReadLine().ToUpper();
                    if (manavsecim == "M")
                    {
                        Console.WriteLine("\n---------------------------------------------------");
                        foreach (var item in manavmeyve)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Hangi Üründen amak istiyorsunuz?");
                        string kiloilemanav = Console.ReadLine().ToUpper();
                        int istek = manavmeyve.IndexOf(kiloilemanav);
                        if (istek >= 0)
                        {
                            Console.WriteLine("\nKaç kilo almak istiyorsunuz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            if (kilo <= (int)manavkilomeyve[istek])
                            {
                                if (musteri.IndexOf(kiloilemanav) >= 0)
                                {
                                    musterikilo[musteri.IndexOf(kiloilemanav)] = (int)musterikilo[musteri.IndexOf(kiloilemanav)] + kilo;
                                    manavkilomeyve[istek] = (int)manavkilomeyve[istek] - kilo;
                                    if ((int)manavkilomeyve[istek] == 0)
                                    {
                                        manavmeyve.Remove(manavmeyve[istek]);
                                    }
                                    Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                                    string evethayir = Console.ReadLine().ToUpper();
                                    if (evethayir == "E")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    musteri.Add(manavmeyve[istek]);
                                    musterikilo.Add(kilo);

                                    manavkilomeyve[istek] = (int)manavkilomeyve[istek] - kilo;
                                    if ((int)manavkilomeyve[istek] == 0)
                                    {
                                        manavmeyve.Remove(manavmeyve[istek]);
                                    }
                                    Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                                    string evethayir = Console.ReadLine().ToUpper();
                                    if (evethayir == "E")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Maalesef elimizde " + (int)manavkilomeyve[istek] + " Kilo Kaldı");
                                Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                                string evethayir = Console.ReadLine().ToUpper();
                                if (evethayir == "E")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Maalesef bu ürün kalmadı");
                            Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                            string evethayir = Console.ReadLine().ToUpper();
                            if (evethayir == "E")
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                    else if (manavsecim == "S")
                    {
                        foreach (var item in manavsebze)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Hangi Üründen amak istiyorsunuz?");
                        string kiloilemanav = Console.ReadLine().ToUpper();
                        int istek = manavsebze.IndexOf(kiloilemanav);
                        if (istek >= 0)
                        {
                            Console.WriteLine("\nKaç kilo almak istiyorsunuz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            if (kilo <= (int)manavkilosebze[istek])
                            {
                                if (musteri.IndexOf(kiloilemanav) >= 0)
                                {
                                    musterikilo[musteri.IndexOf(kiloilemanav)] = (int)musterikilo[musteri.IndexOf(kiloilemanav)] + kilo;
                                    manavkilosebze[istek] = (int)manavkilosebze[istek] - kilo;
                                    if ((int)manavkilosebze[istek] == 0)
                                    {
                                        manavsebze.Remove(manavsebze[istek]);
                                    }
                                    Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                                    string evethayir = Console.ReadLine().ToUpper();
                                    if (evethayir == "E")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    musteri.Add(manavsebze[istek]);
                                    musterikilo.Add(kilo);

                                    manavkilosebze[istek] = (int)manavkilosebze[istek] - kilo;
                                    if ((int)manavkilosebze[istek] == 0)
                                    {
                                        manavsebze.Remove(manavsebze[istek]);
                                    }
                                    Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                                    string evethayir = Console.ReadLine().ToUpper();
                                    if (evethayir == "E")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Maalesef elimizde " + (int)manavkilosebze[istek] + " Kilo Kaldı");
                                Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                                string evethayir = Console.ReadLine().ToUpper();
                                if (evethayir == "E")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Maalesef bu ürün kalmadı");
                            Console.WriteLine("\nBaşka bir arzunu var mı? Evet E veya Hayır H");
                            string evethayir = Console.ReadLine().ToUpper();
                            if (evethayir == "E")
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                while (true)
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("--------MÜŞTERİ LİSTESİ");

                    for (int i = 0; i < musteri.Count; i++)
                    {
                        Console.WriteLine(musteri[i] + "---" + musterikilo[i] + " kilo");
                    }
                    break;
                }
                break;
            }


            Console.ReadLine();


        }
    }
}
