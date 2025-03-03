using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdevAcunMedya1.Interfaces;

namespace OdevAcunMedya1.Classes
{
    public class Mercedes : Araba, IYuzebilir, IUcabilir
    {
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
