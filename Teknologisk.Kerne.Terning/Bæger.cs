﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.Kerne
{
    public class Bæger
    {
        private Terning[] terninger;

        public Bæger(int antal)
        {
            terninger = new Kerne.Terning[5];
            for (int i = 0; i < terninger.Length; i++)
            {
                terninger[i] = new Kerne.Terning();
            }
        
        }

        public Bæger() :this(5) // Calls the customer constructor
        {

        }

        public Bæger(params int[] værdier)
        {
            terninger = new Kerne.Terning[værdier.Length];
            for (int i = 0; i < terninger.Length; i++)
            {
                terninger[i] = new Kerne.Terning(værdier[i]);
            }

        }


        public string Skriv()
        {
            string tmp = "";
            foreach (var t in terninger)  // In a foreach, you could use both the variable type or var in front of the object
            {
                tmp += t.Skriv();                
            }
            return tmp;
        }

        public void Ryst()
        {
            foreach (Terning t in terninger) // In a foreach, you could use both the variable type or var in front of the object
            {
                t.Ryst();
            }
        }
        
    }
}
