/*
 * NAMA  : RINALDI FITRAHUDA RADITYA
 * NIM   : 20.11.3378
 * KELAS : 20 IF 02
 */


using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3378
{
    class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public float GajiBulanan { get; set; }

        public void gajiawal()
        {

            Console.WriteLine("{0} {1}      {2}", Nik, Nama, GajiBulanan);

        }

        public void gajiakhir()
        {
            Console.WriteLine("{0} {1}      {2}", Nik, Nama, GajiBulanan + GajiBulanan * 10 / 100);
        }
    }
}
namespace ResponsiPemrograman3378
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan paijo = new Karyawan();
            Karyawan jono = new Karyawan();

            paijo.Nik = 190302123;
            paijo.Nama = "Paijo";
            paijo.GajiBulanan = 3000000;

            jono.Nik = 190302124;
            jono.Nama = "Jono";
            jono.GajiBulanan = 2000000;

            Console.WriteLine("Nik Nama                    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            paijo.gajiawal();
            jono.gajiawal();

            Console.WriteLine("\nAlhamdulillah dapat kenaikan gaji 10%\n\n");

            Console.WriteLine("Nik Nama                    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            paijo.gajiakhir();
            jono.gajiakhir();

            Console.ReadKey();
        }
    }
}