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
        public static string DectoHex(int n)
        {
            var kq = "";

            if (n >= 0)
            {
                var tempstk = new Stack<int>();
                int du = 0;
                do
                {
                    du = n % 16;
                    tempstk.Push(du);
                    n = n / 16;
                } while (n > 0);
                
                while (tempstk.Count > 0)
                {
                    int c = tempstk.Pop();
                    switch (c)
                    {
                        case 10:
                            kq += "A";
                            break;
                        case 11:
                            kq += "B";
                            break;
                        case 12:
                            kq += "C";
                            break;
                        case 13:
                            kq += "D";
                            break;
                        case 14:
                            kq += "E";
                            break;
                        case 15:
                            kq += "F";
                            break;
                        default:
                            kq += c.ToString();
                            break;
                    }                     
                }
            }
            return kq;
        }
        public static int BintoDec(string bit)
        {
            int kq = 0;
            
            return kq;
        }
    }
}
