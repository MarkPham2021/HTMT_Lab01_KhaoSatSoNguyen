using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics;
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
        public static double BintoDec(string bit)
        {
            double kq = 0;
            int n = bit.Length;
            for(int i=0; i < n; i++)
            {
                kq += Math.Pow(2, n - i - 1) * int.Parse(bit.Substring(i, 1));
            }
            return kq;
        }
        public static double HextoDec(string chuoihex)
        {
            double kq = 0;
            int n = chuoihex.Length;
            for (int i = 0; i < n; i++)
            {
                string item = chuoihex.Substring(i, 1);
                int num;
                if (item == "A" || item == "a")
                {
                    num = 10;
                }
                else if (item == "B" || item == "b")
                {
                    num = 11;
                }
                else if (item == "C" || item == "c")
                {
                    num = 12;
                }
                else if (item == "D" || item == "d")
                {
                    num = 13;
                }
                else if (item == "E" || item == "e")
                {
                    num = 14;
                }
                else if (item == "F" || item == "f")
                {
                    num = 15;
                }
                else
                {
                    num = int.Parse(item);
                }
                kq += num*Math.Pow(16, n - 1 - i) ;
            }
            return kq;
        }
        public static string BintoHex(string chuoibit)
        {
            string kq = "";
            int n = chuoibit.Length;
            var tempstk = new Stack<string>();
            bool dung = (n == 0);
            do
            {
                int val = 0;
                for (int i = 0; i < 4; i++)
                {
                    n = n - 1;
                    if (n < 0)
                    {
                        dung = true;
                        break;
                    }
                    val += int.Parse(chuoibit.Substring(n, 1)) * (int)Math.Pow(2, i);

                }
                if (dung && val == 0)
                {
                    break;
                }
                else
                {
                    string item;
                    switch (val)
                    {
                        case 10:
                            item = "A";
                            break;
                        case 11:
                            item = "B";
                            break;
                        case 12:
                            item = "C";
                            break;
                        case 13:
                            item = "D";
                            break;
                        case 14:
                            item = "E";
                            break;
                        case 15:
                            item = "F";
                            break;
                        default:
                            item = val.ToString();
                            break;
                    }
                    tempstk.Push(item);
                }
            } while (!dung);

            while(tempstk.Count > 0)
            {
                kq += tempstk.Pop();
            }
            return kq;
        }
    }
}
