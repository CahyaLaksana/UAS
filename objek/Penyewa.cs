using System;
using System.Collections.Generic;
using System.Text;

namespace UAS.objek
{
    public class Penyewa : mobil
    {
        public string nama;
        public string alamat;

        public override int Biaya()
        {
            return this.B_hari * this.J_hari;
        }
    }
}
