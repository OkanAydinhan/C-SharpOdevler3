﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaOdev3.AbstractClass;
using AcunMedyaOdev3.Interface;

namespace AcunMedyaOdev3.Classes
{
    public class Mercedes : Araba, IYakitTuketimi
    {
        public double yakitTuketimi()
        {
            return 70.0;
        }
    }
}
    
       


