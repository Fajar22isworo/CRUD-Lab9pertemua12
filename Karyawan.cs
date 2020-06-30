using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CRUD.Class_Induk;

namespace CRUD.Class_Induk
{
    public abstract class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}