using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_6_form_1
{
    internal class PhanSo
    {
        public int tu { get; set; }
        public int mau { get; set; }
        public PhanSo(int tu, int mau) { 
            this.tu = tu;
            this.mau= mau;
        }
        // nap chong toan tu
        public static PhanSo operator + (PhanSo a, PhanSo b)
        {
            int tuMoi = a.tu * b.mau + b.tu * a.mau;
            int mauMoi = a.mau * b.mau;
            return new PhanSo(tuMoi, mauMoi);   
        }
        public static PhanSo operator - (PhanSo a, PhanSo b)
        {
            int tuMoi = a.tu * b.mau - b.tu * a.mau;
            int mauMoi = a.mau * b.mau;
            return new PhanSo(tuMoi, mauMoi);
        }
        public static PhanSo operator * (PhanSo a, PhanSo b)
        {
            int tuMoi = a.tu * b.tu;
            int mauMoi = a.mau * b.mau;
            return new PhanSo(tuMoi, mauMoi);
        }
        public static PhanSo operator / (PhanSo a, PhanSo b)
        {
            int tuMoi = a.tu * b.mau;
            int mauMoi = a.mau * b.tu;
            return new PhanSo(tuMoi, mauMoi);
        }
        // nap chong toan tu to_String de in ra kq
        
    }
}
