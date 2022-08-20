using System;
using System.Collections.Generic;
using System.Text;

namespace KhaoSatSoNguyen
{
    public class Bai02
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bai 2: Thuc hien cac phep tinh voi chuoi nhi phan 8 bit so Nguyen co dau dang bu 2: ");
            string bit1 = "11101001", bit2 = "00000101"; string sodu = "";
            bool tieptuc =true;
            string c = "y";
            while (tieptuc)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("Nhap chuoi nhi phan thu nhat: ");
                bit1=Console.ReadLine();
                Console.WriteLine("Nhap chuoi nhi phan thu hai: ");
                bit2 = Console.ReadLine();
                Console.WriteLine($"{bit1} + {bit2} = {CacPhepToanNhiPhan.PhepCong(bit1, bit2)} \t Bi tran so (isOverFlow): {CacPhepToanNhiPhan.CoTranSoPhepCong(bit1, bit2)}");
                Console.WriteLine($"{bit1} - {bit2} = {CacPhepToanNhiPhan.PhepTru(bit1, bit2)} \t Bi tran so (isOverFlow): {CacPhepToanNhiPhan.CoTranSoPhepTru(bit1, bit2)}");
                Console.WriteLine($"{bit1} * {bit2} = {CacPhepToanNhiPhan.PhepNhan(bit1, bit2)}");
                Console.WriteLine($"{bit1} / {bit2} = {CacPhepToanNhiPhan.PhepChiaM(bit1, bit2, out sodu)} du: {sodu}");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("Tiep tuc thuc hien? (y/Y: de tiep tuc, phim khac de ket thuc)");
                c = Console.ReadLine();
                tieptuc = (c.ToLower() == "y");
            }            
        }
    }
}
