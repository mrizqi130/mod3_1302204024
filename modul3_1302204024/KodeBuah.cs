﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204024
{
    public class KodeBuah
    {
        //public string g;
        public enum daftarEnum { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka}

        public string getKodeBuah(daftarEnum buah)
        {
            //Console.WriteLine("ini geKodebuah");
            string[] daftar = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
            return daftar[(int)buah];
        }
    }
}
