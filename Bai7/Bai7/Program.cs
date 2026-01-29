using System;

namespace BaiTapMang
{
    public class Bai5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ten:Phan Manh Tung.");
            Console.WriteLine("MSV:2415053122347.");
            Console.WriteLine("Nhap ho ten:");
            string hoten = Console.ReadLine();

            if (hoten != null)
            {
                string[] mang = hoten.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (mang != null)
                {
                    foreach (string tu in mang)
                    {
                        Console.WriteLine(tu);
                    }
                }
            }
        }
    }
}