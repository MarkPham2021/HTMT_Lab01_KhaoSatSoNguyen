using System;

namespace KhaoSatSoNguyen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = 30;
            //Console.WriteLine($"{n} (10) = {ChuyenDoiCoSo.DectoBin(n)} (2).");
            //string bit1 = "00000110", bit2 = "10000110";
            //Console.WriteLine($"{bit1} + {bit2} = {CacPhepToanNhiPhan.PhepCong(bit1, bit2)}");
            string bit1 = "00001001", bit2 = "11001001";
            Console.WriteLine($"so doi cua {bit1} = {CacPhepToanNhiPhan.LaySoDoi(bit1)}");
            Console.WriteLine($"{bit1} - {bit2} = {CacPhepToanNhiPhan.PhepTru(bit1, bit2)}");
            Console.WriteLine($"{bit1} * {bit2} = {CacPhepToanNhiPhan.PhepNhan(bit1, bit2)}");
        }
    }
}
