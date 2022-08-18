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
            r = PhepCong16(r, "0000000000000001");
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
            for (int i = 15; i >= 0; i--)
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
                kq = thanhghi.Substring(1);
            }
            else
                thanhghi = thanhghi.Substring(1);
                kq = LaySoDoi16(thanhghi);
            return kq;
        }
    }
}
