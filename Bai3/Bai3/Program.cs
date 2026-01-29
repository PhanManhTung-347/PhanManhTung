using System;
using System.Linq;

class Program
{
    static bool KiemTraDoiXung(string chuoiVao)
    {
        if (chuoiVao == null) 
            return false;
        string chuoiSach = chuoiVao.Replace(" ", "").ToLower();
        if (chuoiSach.Length == 0) 
            return false;
        int dau = 0;
        int cuoi = chuoiSach.Length - 1;

        while (dau < cuoi)
        {
            if (chuoiSach[dau] != chuoiSach[cuoi])
                return false;

            dau++;
            cuoi--;
        }
        return true;
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập chuỗi: ");
        string noiDung = Console.ReadLine();

        if (KiemTraDoiXung(noiDung))
            Console.WriteLine("Chuỗi đối xứng");
        else
            Console.WriteLine("Không đối xứng");
    }

   
}