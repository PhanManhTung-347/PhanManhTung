using System;

namespace Bai5
{
    public class Bai5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ten:Phan Manh Tung.");
            Console.WriteLine("MSV:2415053122347.");
            Console.Write("Nhap vao so luong phan tu: ");
            int n=int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap a[{i}]: ");
                int.TryParse(Console.ReadLine(), out a[i]);
            }
            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"Gia tri lon nhat trong mang la: {max}");
        }
    }
}