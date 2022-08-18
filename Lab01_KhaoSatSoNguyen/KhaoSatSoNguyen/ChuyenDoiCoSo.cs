using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace KhaoSatSoNguyen
{
    public class ChuyenDoiCoSo
    {
        public static string DectoBin(int n)
        {
            var kq = "";

            if (n >=0)            
            {
                var tempstk= new Stack<int>();
                int du = 0;
                do
                {
                    du = n % 2;
                    tempstk.Push(du);
                    n = n / 2;
                } while (n > 0);
                kq+="0";
                while (tempstk.Count > 0)
                {
                    kq+=tempstk.Pop().ToString();
                }
            }            
            return kq;
        }


    }
}
