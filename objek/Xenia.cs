using System;
using System.Collections.Generic;
using System.Text;

namespace UAS.objek
{
    public class xenia : mobil
    {
        public override int Biaya()
        {
            return this.B_hari * this.J_hari ;
        }
    }
}
