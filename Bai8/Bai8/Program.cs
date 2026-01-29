using System;
class ChuongTrinh
{
    static void Main()
    {
        Console.WriteLine("Ten:Phan Manh Tung.");
        Console.WriteLine("MSV:2415053122347.");
        Console.Write("Nhap vao mot cau: ");
        string chuoiVao = Console.ReadLine();

        if (string.IsNullOrEmpty(chuoiVao))
        {
            return;
        }
        string[] danhSachTu = chuoiVao.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (danhSachTu.Length == 0)
        {
            return;
        }
        string tuDaiNhat = "";
        foreach (string tu in danhSachTu)
        {
            if (tu.Length > tuDaiNhat.Length)
            {
                tuDaiNhat = tu;
            }
        }
        Console.WriteLine("Tu dai nhat la:" + tuDaiNhat);
    }
}