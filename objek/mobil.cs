using System;

namespace UAS.objek
{
    public abstract class mobil
    {
        public string Plat;
        public string Nama;
        public string Warna;
        public int J_hari { get; set; } //Convert.ToInt32(Console.ReadLine())
        public int B_hari;        
        
        public abstract int Biaya();

    }
}