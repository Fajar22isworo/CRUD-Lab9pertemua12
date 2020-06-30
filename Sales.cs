using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Class_Induk;

namespace CRUD.Class_Anak
{
    public class Sales : Karyawan
    {

        public double JumlahPenjualan { get; set; }
        public double Komisi{ get; set; }

        public override double Gaji()
        {
            double Gaji = 0;
            Gaji = JumlahPenjualan * Komisi;
            return Gaji;
        }
    }
}
