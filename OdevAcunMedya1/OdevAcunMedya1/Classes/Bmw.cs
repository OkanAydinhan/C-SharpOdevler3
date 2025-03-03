using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdevAcunMedya1.Interfaces;

namespace OdevAcunMedya1.Classes
{
    public class Bmw : Araba, ICokHizliGidebilir, IYuzebilir, IUcabilir
    {
        public void cokHizliGit(string marka)
        {
            Console.WriteLine(marka + " cok hizli gidiyor...");
        }

        public void uc(string marka)
        {
            Console.WriteLine(marka + " havada ucuyor...");
        }

        public void yuz(string marka)
        {
            Console.WriteLine(marka + " denizde yuzuyor...");
        }
    }
}
