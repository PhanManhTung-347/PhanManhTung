using System;
namespace Bai4
{
    public class Bai4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ten:Phan Manh Tung.");
            Console.WriteLine("MSV:2415053122347.");
            int[] a;
            int n;
            Console.WriteLine("Nhap vao so luong phan tu cua mang:");
            int.TryParse(Console.ReadLine(), out n);
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i}:");
                int.TryParse(Console.ReadLine(), out a[i]);
            }
            int tong=0;
            for (int i = 0; i < n; i++)
            {
                tong = tong + a[i];
            }
            Console.WriteLine($"Tong cua cac phan tu trong mang la {tong}");
        }
    }
}