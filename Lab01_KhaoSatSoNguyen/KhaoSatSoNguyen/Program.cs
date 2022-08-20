using System;

namespace KhaoSatSoNguyen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 252;
            string bit = "1001";
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Bai 1: Chuyen Doi Co So doi voi so nguyen duong: ");
            Console.WriteLine($"{n} (10) = {ChuyenDoiCoSo.DectoBin(n)} (2).");
            Console.WriteLine($"{n} (10) = {ChuyenDoiCoSo.DectoHex(n)} (16).");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Bai 2: Thuc hien cac phep tinh voi chuoi nhi phan 8 bit so Nguyen co dau dang bu 2: ");
            string bit1 = "11101001", bit2 = "00000101"; string sodu = "";
            
            Console.WriteLine($"{bit1} + {bit2} = {CacPhepToanNhiPhan.PhepCong(bit1, bit2)}");
            Console.WriteLine($"{bit1} - {bit2} = {CacPhepToanNhiPhan.PhepTru(bit1, bit2)}");
            Console.WriteLine($"{bit1} * {bit2} = {CacPhepToanNhiPhan.PhepNhan(bit1, bit2)}");
            Console.WriteLine($"{bit1} / {bit2} = {CacPhepToanNhiPhan.PhepChia(bit1, bit2, out sodu)} du: {sodu}");
            Console.WriteLine($"{bit1} / {bit2} = {CacPhepToanNhiPhan.PhepChiaM(bit1, bit2, out sodu)} du: {sodu}");
            Console.WriteLine("---------------------------------------------------------------------------------------");
        }
    }
}
