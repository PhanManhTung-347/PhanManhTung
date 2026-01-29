using System;

namespace BaiTapMang
{
    public class Bai5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ten:Phan Manh Tung.");
            Console.WriteLine("MSV:2415053122347.");
            Console.Write("Nhap n: ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n <= 0)
            {
                Console.WriteLine("Mang rong!");
                return;
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                int.TryParse(Console.ReadLine(), out a[i]);
            }
            int demchan = 0;
            for (int i = 1; i < n; i++)
            {
                if (a[i] %2==0)
                {
                    demchan = demchan + 1;
                }
            }
            Console.WriteLine($"So luong so chan la: {demchan}");
        }
    }
}