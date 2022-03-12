using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ehe");
            KodeBuah kode = new KodeBuah();
            //string a = Console.ReadLine();

            Console.WriteLine("Kode Buah Apel adalah "+kode.getKodeBuah(KodeBuah.daftarEnum.Apel));
        }
    }
}
