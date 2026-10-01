using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Dictionary<int, string> telebe = new Dictionary<int, string>()
            //    {
            //    {1, "Ali"},
            //    {2, "Veli"},
            //    {3, "Ayse"},
            //    {4, "Fatma"},
            //    {5, "Mehmet"}
            //};
            //bool davam = true;
            //while(davam)
            //{
            //    Console.WriteLine("\n--- Tələbə Qeydiyyat Sistemi ---");
            //    Console.WriteLine("1. Tələbə əlavə et");
            //    Console.WriteLine("2. Tələbəni ID ilə axtar");
            //    Console.WriteLine("3. Bütün tələbələri göstər");
            //    Console.WriteLine("4. Çıxış");
            //    Console.Write("Seçiminizi daxil edin (1-4): ");

            //    string secim = Console.ReadLine();

            //    switch (secim)
            //    {
            //        case "1":
            //            Console.Write("Yeni tələbənin ID-sini (rəqəm) daxil edin: ");
            //            if (int.TryParse(Console.ReadLine(), out int id))
            //            {
            //                if (telebe.ContainsKey(id))
            //                {
            //                    Console.WriteLine("Bu ID ilə artıq tələbə mövcuddur!");
            //                }
            //                else
            //                {
            //                    Console.Write("Tələbənin adını daxil edin: ");
            //                    string ad = Console.ReadLine();
            //                    telebe.Add(id, ad);
            //                    Console.WriteLine("Tələbə uğurla əlavə olundu.");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Yanlış ID formatı!");
            //            }
            //            break;

            //        case "2":
            //            Console.Write("Axtarılacaq tələbənin ID-sini daxil edin: ");
            //            if (int.TryParse(Console.ReadLine(), out int searchId))
            //            {
            //                if (telebe.ContainsKey(searchId))
            //                {
            //                    Console.WriteLine($"Tapıldı -> ID: {searchId}, Ad: {telebe[searchId]}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Bu ID-yə uyğun tələbə tapılmadı.");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Yanlış ID formatı!");
            //            }
            //            break;

            //        case "3":
            //            Console.WriteLine("\nBütün tələbələr siyahısı:");
            //            foreach (KeyValuePair<int, string> item in telebe)
            //            {
            //                Console.WriteLine($"ID: {item.Key} | Ad: {item.Value}");
            //            }
            //            break;

            //        case "4":
            //            davam = false;
            //            Console.WriteLine("Proqramdan çıxılır...");
            //            break;

            //        default:
            //            Console.WriteLine("Yanlış seçim etdiniz, 1 və 4 arasında rəqəm seçin.");
            //            break;
            //    }
            //}

            //2
            Console.WriteLine("Seçmək istədiyiniz figura uyğun rəqəmi yazın:");
            Console.WriteLine("1. Dairə");
            Console.WriteLine("2. Düzbucaqlı");
            Console.WriteLine("3. Üçbucaq");
            Console.Write("Seçiminiz: ");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.Write("Dairənin radiusunu daxil edin: ");
                    if (double.TryParse(Console.ReadLine(), out double radius))
                    {
                        double sahe = Math.PI * Math.Pow(radius, 2);
                        Console.WriteLine($"Dairənin sahəsi: {Math.Round(sahe, 2)}");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış radius dəyəri daxil edildi!");
                    }
                    break;

                case "2":
                    Console.Write("Düzbucaqlının enini daxil edin: ");
                    if (double.TryParse(Console.ReadLine(), out double en))
                    {
                        Console.Write("Düzbucaqlının uzunluğunu daxil edin: ");
                        if (double.TryParse(Console.ReadLine(), out double uzunluq))
                        {
                            double duzbucaqliSahe = en * uzunluq;
                            Console.WriteLine($"Düzbucaqlının sahəsi: {Math.Round(duzbucaqliSahe, 2)}");
                        }
                        else
                        {
                            Console.WriteLine("Yanlış uzunluq dəyəri daxil edildi!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlış en dəyəri daxil edildi!");
                    }
                    break;

                case "3":
                    Console.Write("Üçbucağın 1-ci tərəfini daxil edin: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Üçbucağın 2-ci tərəfini daxil edin: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Üçbucağın 3-cü tərəfini daxil edin: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    double p = (a + b + c) / 2;

                    double ucbucaqsahe = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    Console.WriteLine($"Üçbucağın sahəsi: {Math.Round(ucbucaqsahe, 2)}"); 
                    break;

                default:
                    Console.WriteLine("Yanlış fiqur seçildi!");
                    break;
            }

            //3
            //List<int> ededler = new List<int>();
            //Console.WriteLine("10 ədəd daxil edin:");
            //for (int i = 0; i < 10; i++) 
            //{
            //    Console.Write($"{i + 1}-ci ədədi daxil edin: ");
            //    int eded = Convert.ToInt32(Console.ReadLine());
            //    ededler.Add(eded);
            //}
            //int enBoyuk = ededler[0];
            //int enKicik = ededler[0];
            //int cutSayi = 0;
            //int tekSayi = 0;

            //foreach (int eded in ededler)
            //{
            //    if (eded > enBoyuk) enBoyuk = eded;
            //    if (eded < enKicik) enKicik = eded;

            //    if (eded % 2 == 0)
            //    {
            //        cutSayi++;
            //    }
            //    else
            //    {
            //        tekSayi++;
            //    }
            //}

            //4
            //Console.WriteLine($"Ən böyük ədəd: {enBoyuk}");
            //Console.WriteLine($"Ən kiçik ədəd: {enKicik}");
            //Console.WriteLine($"Cüt ədədlərin sayı: {cutSayi}");
            //Console.WriteLine($"Tək ədədlərin sayı: {tekSayi}");

            //Random rnd = new Random();
            //int gizliEded = rnd.Next(0, 101); // 0 ilə 100 arasında təsadüfi ədəd
            //int texmin;

            //Console.WriteLine("0 ilə 100 arasında bir ədəd tutuldu");

            //do
            //{
            //    Console.Write("Təxmininizi daxil edin: ");
            //    texmin = Convert.ToInt32(Console.ReadLine());

            //    if (texmin > gizliEded)
            //    {
            //        Console.WriteLine("Daha kiçik ədəd cəhd edin!");
            //    }
            //    else if (texmin < gizliEded)
            //    {
            //        Console.WriteLine("Daha böyük ədəd cəhd edin!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Təbriklər! Ədədi düzgün tapdınız.");
            //    }

            //} while (texmin != gizliEded); 
        }
    }
}
