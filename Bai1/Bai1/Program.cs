using System;


namespace Bai1
{
    public class Bai1
    {
        public static void Main(string[] args)
        {

            Console.Write("Nhap Chuoi Ho Ten: ");
            string HoTen = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(HoTen))
            {
                Console.WriteLine("Lỗi: chuoi rong.");
            }
            else
            {
                HoTen = HoTen.Trim();
                string[] cacTu = HoTen.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < cacTu.Length; i++)
                {
                    string tu = cacTu[i];
                    if (tu.Length > 0)
                    {
                        tu = tu.Substring(0, 1).ToUpper() + tu.Substring(1).ToLower();
                        cacTu[i] = tu;
                    }
                }
                string ketQua = string.Join(" ", cacTu);
                Console.WriteLine("Chuỗi sau khi chuẩn hoá:");
                Console.WriteLine(ketQua);
            }
        }
    }
}