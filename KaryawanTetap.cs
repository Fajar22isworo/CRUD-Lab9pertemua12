using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Class_Induk;

namespace CRUD.Class_Anak
{
    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }

   

        public override double Gaji()
        {
            double Gaji = 0;
            Gaji = GajiBulanan;
            return GajiBulanan;
        }
    }
}
