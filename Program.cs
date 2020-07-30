using System;
using UAS.objek;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel.Design;

namespace UAS
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string opt;
            string YN;
            xenia xenia = new xenia();
            xenia.Plat = "AB 3536 DK";
            xenia.Nama = "Xenia";
            xenia.Warna = "Silver";
            xenia.B_hari = 100000;

            avanza avanza = new avanza();
            avanza.Plat = "AB 5232 LK";
            avanza.Nama = "Avanza";
            avanza.Warna = "Merah";
            avanza.B_hari = 110000;


           

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("========== Persewaan Mobil ===========");
            Console.WriteLine("======================================");
            Console.ReadKey();

            MenuCommand:
            Console.Clear();
            Console.WriteLine("\n========== Mobil Yang Disewa ===========");
            Console.WriteLine("1.Xenia\n2.Avanza");
            Console.Write("\nPilih Mobil Yang Disewa: ");
            opt = Console.ReadLine();

         
            if (opt == "1")
            {
                xenia:
                Console.Clear();
                Console.WriteLine("\n============Mobil=================");
                Console.WriteLine("Nama\t:{0}\nPlat\t:{1}\nWarna\t:{2}\nHarga\t:{3}/hari", xenia.Nama, xenia.Plat, xenia.Warna, xenia.B_hari);
                Console.Write("\nApakah anda ingin menyewa?(Y/N): ");
                YN = Console.ReadLine();
                
                if (YN == "Y"|| YN == "y")
                {
                    Console.Clear();
                    Console.WriteLine("\n============Angket=================");
                    Penyewa penyewa = new Penyewa();
                    Console.Write("Nama\t:");
                    penyewa.nama = Console.ReadLine();
                    Console.Write("Alamat\t:");
                    penyewa.alamat = Console.ReadLine();
                    Console.Write("Lama Sewa(hari)\t:");
                    penyewa.J_hari = Convert.ToInt32(Console.ReadLine());


                    Console.Clear();
                    strukX(xenia, penyewa);

                }else if(YN == "N" || YN == "n"){
                    goto MenuCommand;
                }else{
                    goto xenia;
                }

            }else if (opt == "2"){
                avanza:
                Console.Clear();
                Console.WriteLine("\n============Mobil=================");
                Console.WriteLine("Nama\t:{0}\nPlat\t:{1}\nWarna\t:{2}\nHarga\t:{3}/hari", avanza.Nama, avanza.Plat, avanza.Warna, avanza.B_hari);
                Console.Write("\nApakah anda ingin menyewa?(Y/N): ");
                YN = Console.ReadLine();


                if (YN == "Y" || YN == "y")
                {
                    Console.Clear();
                    Console.WriteLine("\n============Angket=================");
                    Penyewa penyewa = new Penyewa();
                    Console.Write("Nama\t:");
                    penyewa.nama = Console.ReadLine();
                    Console.Write("Alamat\t:");
                    penyewa.alamat = Console.ReadLine();
                    Console.Write("Lama Sewa(hari)\t:");
                    penyewa.J_hari = Convert.ToInt32(Console.ReadLine());


                    Console.Clear();
                    strukA(avanza, penyewa);

                }
                else if (YN == "N" || YN == "n")
                {
                    goto MenuCommand;
                }
                else
                {
                    goto avanza;
                }

            }


            static void strukX(xenia xenia, Penyewa penyewa)
            {
                Console.WriteLine("\n============Struk Penyewaan Mobil=================");
                Console.WriteLine("==================================================");
                Console.WriteLine("Nama\t:{0}\nPlat\t:{1}\nWarna\t:{2}\nHarga\t:{3}/hari", xenia.Nama, xenia.Plat, xenia.Warna, xenia.B_hari);
                Console.WriteLine("\nDisewakan kepada: ");
                Console.WriteLine("\nNama\t: {0}\nAlamat: {2}\nJangka Waktu: {1} hari", penyewa.nama, penyewa.J_hari, penyewa.alamat);
                penyewa.B_hari = xenia.B_hari;
                Console.WriteLine("=======================\nHARGA TOTAL: {0}", penyewa.Biaya());
                Console.ReadKey();

            }

            static void strukA(avanza avanza, Penyewa penyewa)
            {
                Console.WriteLine("\n============Struk Penyewaan Mobil=================");
                Console.WriteLine("==================================================");
                Console.WriteLine("Nama\t:{0}\nPlat\t:{1}\nWarna\t:{2}\nHarga\t:{3}/hari", avanza.Nama, avanza.Plat, avanza.Warna, avanza.B_hari);
                Console.WriteLine("\nDisewakan kepada: ");
                Console.WriteLine("\nNama\t: {0}\nAlamat: {2}\nJangka Waktu: {1} hari", penyewa.nama, penyewa.J_hari, penyewa.alamat);
                penyewa.B_hari = avanza.B_hari;
                Console.WriteLine("=======================\nHARGA TOTAL: {0}", penyewa.Biaya());
                Console.ReadKey();

            }
        }
       
    }
}
