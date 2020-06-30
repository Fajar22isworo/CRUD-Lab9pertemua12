using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Class_Induk;

namespace CRUD.Class_Anak
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }

        public override double Gaji()
        {
            double Gaji = 0;
            Gaji = UpahPerJam * JumlahJamKerja;
            return Gaji;
        }
    }
}
