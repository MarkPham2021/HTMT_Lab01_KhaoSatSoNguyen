using System;
using System.Collections.Generic;
using System.Text;

namespace KhaoSatSoNguyen
{
    public class Bai01
    {
        public static void ThucHien()
        {
            string c = "";
            int n=0;                       
            string bit = "";
            string hex = "";
            bool tieptuc = true;
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Bai 1: Chuyen Doi Co So doi voi so nguyen duong: ");
            while (tieptuc)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------");
                
                Console.WriteLine("Moi nhap mot so nguyen duong he thap phan: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine($"{n} (10) = {ChuyenDoiCoSo.DectoBin(n)} (2).");
                Console.WriteLine($"{n} (10) = {ChuyenDoiCoSo.DectoHex(n)} (16).");
                Console.WriteLine("Moi nhap mot chuoi bit he nhi phan: ");
                bit = Console.ReadLine();
                Console.WriteLine($"{bit} (2) = {ChuyenDoiCoSo.BintoDec(bit)} (10).");                
                Console.WriteLine($"{bit} (2) = {ChuyenDoiCoSo.BintoHex(bit)} (16).");
                Console.WriteLine("Moi nhap mot chuoi he thap luc phan (Hexa): ");
                hex = Console.ReadLine();
                Console.WriteLine($"{hex} (16) = {ChuyenDoiCoSo.HextoDec(hex)} (10).");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("Tiep tuc thuc hien chuyen doi co so (y/Y: de tiep tuc, phim khac de ket thuc)?");
                c = Console.ReadLine();
                tieptuc = (c.ToLower() == "y");                
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");
        }
    }
}
