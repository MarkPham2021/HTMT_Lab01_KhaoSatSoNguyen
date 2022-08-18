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
            string bit1 = "11101001", bit2 = "00000101"; string sodu = "";
            Console.WriteLine($"so doi cua {bit1} = {CacPhepToanNhiPhan.LaySoDoi(bit1)}");
            Console.WriteLine($"{bit1} - {bit2} = {CacPhepToanNhiPhan.PhepTru(bit1, bit2)}");
            Console.WriteLine($"{bit1} * {bit2} = {CacPhepToanNhiPhan.PhepNhan(bit1, bit2)}");
            Console.WriteLine($"{bit1} / {bit2} = {CacPhepToanNhiPhan.PhepChia(bit1, bit2, out sodu)} du: {sodu}");
            Console.WriteLine($"{bit1} / {bit2} = {CacPhepToanNhiPhan.PhepChiaM(bit1, bit2, out sodu)} du: {sodu}");
        }
    }
}
