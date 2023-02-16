using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liet_ke_So_Nguyen_to
{
    internal class print_snt
    {
        public double so { get; set; }
        // in số nguyên tố
        public bool kiemTraSoNT (int so)
        {
            if (so < 2) return false;
            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0) return false;  
            }
            return true;
        }
    }
}
