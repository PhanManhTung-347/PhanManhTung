using System;
namespace Bai2
{
    public class Bai2
    {
        public static void Main(string[] args)
        {
            String? chuoi;
            Console.WriteLine("Nhap vao chuoi ho ten:");
            chuoi = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(chuoi))
            {
                Console.WriteLine("Loi! Chuoi rong");
                Console.WriteLine("So tu trong chuoi: 0");
            }
            else
            {
                tring[] mangTu = chuoi.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine($"So tu torng chuoi {chuoi} la:" + mangTu.Length);
            }
        }
    }s

    }
