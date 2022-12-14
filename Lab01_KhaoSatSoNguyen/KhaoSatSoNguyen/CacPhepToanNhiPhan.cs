using System;
using System.Collections.Generic;
using System.Text;

namespace KhaoSatSoNguyen
{
    public class CacPhepToanNhiPhan
    {
        //Tat ca dua ve dinh dang chuoi 8 bit dang bu 2 cua so nguyen truoc khi tinh
        public static string DinhDangTamBit(string chuoi)
        {
            string s = "00000000";
            string r = chuoi;
            int l = chuoi.Length;
            if (l > 8)
            {
                r= chuoi.Substring(l-8, 8);
            }else if (l < 8)
            {
                r=s.Substring(0,8-l) +r;
            }
            return r;
        }
        public static string LaySoDoi(string chuoibit)
        {
            chuoibit = DinhDangTamBit(chuoibit);
            string r = "";
            r = chuoibit.Replace('0', '2');
            r = r.Replace('1', '0');
            r = r.Replace('2', '1');
            r = PhepCong(r, "1");
            return r;   
        }
        public static string LaySoDoi16(string chuoibit)
        {
            
            string r = "";
            r = chuoibit.Replace('0', '2');
            r = r.Replace('1', '0');
            r = r.Replace('2', '1');
            r = PhepCong16(r, "00000000000000001");
            return r;
        }
        public static bool LaSoAm(string chuoibit) 
        {
            chuoibit= DinhDangTamBit(chuoibit);
            return (chuoibit.Substring(0, 1) == "1");
        }

        public static string PhepCong(string bit1, string bit2)
        {
            bit1 = DinhDangTamBit(bit1);
            bit2 = DinhDangTamBit(bit2);
            string kq="";
            var tempstk = new Stack<int>();
            int c = 0;
            for(int i =7; i>=0; i--)
            {
                int a = int.Parse(bit1[i].ToString()) ;
                int b = int.Parse(bit2[i].ToString()) ;
                if (a + b + c == 0)
                {
                    c = 0;
                    tempstk.Push(0);
                }else if (a + b + c == 1)
                {
                    c = 0;
                    tempstk.Push(1);
                }
                else if (a + b + c == 2)
                {
                    c = 1;
                    tempstk.Push(0);
                }
                else if (a + b + c == 3)
                {
                    c = 1;
                    tempstk.Push(1);
                }
            }
            while (tempstk.Count > 0)
            {
                kq+= tempstk.Pop().ToString();
            }
            return kq;
        }
        public static string PhepCong16(string bit1, string bit2)
        {
            
            string kq = "";
            var tempstk = new Stack<int>();
            int c = 0;
            for (int i = 16; i >= 0; i--)
            {
                int a = int.Parse(bit1[i].ToString());
                int b = int.Parse(bit2[i].ToString());
                if (a + b + c == 0)
                {
                    c = 0;
                    tempstk.Push(0);
                }
                else if (a + b + c == 1)
                {
                    c = 0;
                    tempstk.Push(1);
                }
                else if (a + b + c == 2)
                {
                    c = 1;
                    tempstk.Push(0);
                }
                else if (a + b + c == 3)
                {
                    c = 1;
                    tempstk.Push(1);
                }
            }
            while (tempstk.Count > 0)
            {
                kq += tempstk.Pop().ToString();
            }
            return kq;
        }
        public static string PhepTru(string sobitru, string sotru)
        {
            string kq = PhepCong(sobitru,  LaySoDoi(sotru));
            return kq;
        }
        public static string PhepCongCoBitNho(string bit1, string bit2)
        {
            bit1 = DinhDangTamBit(bit1);
            bit2 = DinhDangTamBit(bit2);
            string kq = "";
            var tempstk = new Stack<int>();
            int c = 0;
            for (int i = 7; i >= 0; i--)
            {
                int a = int.Parse(bit1[i].ToString());
                int b = int.Parse(bit2[i].ToString());
                if (a + b + c == 0)
                {
                    c = 0;
                    tempstk.Push(0);
                }
                else if (a + b + c == 1)
                {
                    c = 0;
                    tempstk.Push(1);
                }
                else if (a + b + c == 2)
                {
                    c = 1;
                    tempstk.Push(0);
                }
                else if (a + b + c == 3)
                {
                    c = 1;
                    tempstk.Push(1);
                }
            }
            tempstk.Push(c);
            while (tempstk.Count > 0)
            {
                kq += tempstk.Pop().ToString();
            }
            return kq;
        }
        public static string SHL(string bit)
        {
            string con = bit.Substring(1);
            string kq = con + "0";
            return kq;
        }
        public static string SHR(string bit)
        {
            string con = bit.Substring(0,bit.Length-1);
            string kq = "0"+con;
            return kq;
        }
        public static string PhepNhan(string sobinhan, string sonhan)
        {
            string kq = "";
            sobinhan = DinhDangTamBit(sobinhan);
            sonhan = DinhDangTamBit(sonhan);
            int dau1, dau2, dau;
            if (LaSoAm(sobinhan))
            {
                dau1 = -1;
                sobinhan=LaySoDoi(sobinhan);
            }
            else
                dau1 = 1;
            if (LaSoAm(sonhan)) { 
                dau2 = -1;
                sonhan=LaySoDoi(sonhan);
            }else { dau2 = 1; }
            dau = dau1 * dau2;
            string thanhghi="000000000" + sonhan;
            int k = 8;
            string a, ca;
            char q;
            while (k > 0)
            {
                a = thanhghi.Substring(1, 8);
                q = thanhghi[16];
                if(q == '1')
                {
                    ca = PhepCongCoBitNho(a, sobinhan);
                    string con = thanhghi.Substring(9);
                    thanhghi= ca + con;
                }
                thanhghi=SHR(thanhghi);
                k--;
            }
            if (dau > 0)
            {
                kq = thanhghi;
            }
            else
                
                kq = LaySoDoi16(thanhghi);
            return kq;
        }
        //Phep chia theo giai thuat tren slide khong chia duoc khi so bi chia la so am
        //vi so am tru di so chia luon cho ket qua am nen thuong luon bang 0.
        public static string PhepChia(string sobichia, string sochia, out string sodu)
        {
            string kq = "";
            sobichia =DinhDangTamBit(sobichia);
            sochia =DinhDangTamBit(sochia);
            string thanhghi = "", a ="", hieu="", con="";
            int k = 8;
            if (LaSoAm(sobichia))
            {
                thanhghi="11111111"+sobichia;
            }
            else
            {
                thanhghi = "00000000" + sobichia;
            }
            
            while (k > 0)
            {
                thanhghi = SHL(thanhghi);
                a = thanhghi.Substring(0, 8);
                hieu = PhepTru(a, sochia);
                if (LaSoAm(hieu))
                {
                    con =thanhghi.Substring(0, 15);
                    thanhghi = con + "0";
                }
                else
                {                    
                    con = thanhghi.Substring(8, 7);
                    thanhghi =  hieu + con + "1";
                }                
                k--;
            }
            kq = thanhghi.Substring(8, 8);
            sodu = thanhghi.Substring(0, 8);
            return kq;
        }
        //nen dung phepchiaM: phep chia cai tien
        public static string PhepChiaM(string sobichia, string sochia, out string sodu)
        {
            string kq = "";
            sobichia = DinhDangTamBit(sobichia);
            sochia = DinhDangTamBit(sochia);
            int dausobichia, dausochia, dauketqua;
            string thanhghi = "", a = "", hieu = "", con = "";
            int k = 8;
            if (LaSoAm(sobichia))
            {
                dausobichia=-1;
                sobichia = LaySoDoi(sobichia);
            }
            else
            {
                dausobichia=1;
            }
            if (LaSoAm(sochia))
            {
                dausochia = -1;
                sochia = LaySoDoi(sochia);
            }
            else
            {
                dausochia = 1;
            }
            dauketqua=dausobichia*dausochia;
            thanhghi = "00000000" + sobichia;
            while (k > 0)
            {
                thanhghi = SHL(thanhghi);
                a = thanhghi.Substring(0, 8);
                hieu = PhepTru(a, sochia);
                if (LaSoAm(hieu))
                {
                    con = thanhghi.Substring(0, 15);
                    thanhghi = con + "0";
                }
                else
                {
                    con = thanhghi.Substring(8, 7);
                    thanhghi = hieu + con + "1";
                }
                k--;
            }
            kq = thanhghi.Substring(8, 8);
            sodu = thanhghi.Substring(0, 8);
            if (dauketqua == -1)
            {
                kq=LaySoDoi(kq);
            }
            
            return kq;
        }
        public static bool CoTranSoPhepCong(string bit1, string bit2)
        {
            bit1 = DinhDangTamBit(bit1);
            bit2 = DinhDangTamBit(bit2);
            int dau1 = 1, dau2 =1;
            if (LaSoAm(bit1)) dau1 = -1;
            if (LaSoAm(bit2)) dau2 = -1;
            int dau = dau1 + dau2;
            int daukq=1;
            if (LaSoAm(PhepCong(bit1, bit2))) { daukq = -1; };
            return (dau * daukq < 0);
        }
        public static bool CoTranSoPhepTru(string bit1, string bit2)
        {
            bool kq = false;
            bit1 = DinhDangTamBit(bit1);
            bit2 = DinhDangTamBit(bit2);
            int dau1 = 1, dau2 = 2;
            if (LaSoAm(bit1)) dau1 = -1;
            if (LaSoAm(bit2)) dau2 = -2;            
            int daukq = 1;
            if (LaSoAm(PhepTru(bit1, bit2))) { daukq = -1; };
            if ((dau1 < 0 && dau2 > 0 && daukq > 0)|| (dau1 > 0 && dau2 < 0 && daukq < 0)) { kq = true; }
            return kq;
        }
    }
}
