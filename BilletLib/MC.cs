﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC
    {
        private string _nummerplade;
        private DateTime _dato;


        public string Nummerplade
        {
            get { return this._nummerplade; }
            set { _nummerplade = value; }
        }

        public DateTime Dato
        {
            get { return this._dato; }
            set { _dato = value; }
        }



        public int Pris()
        {
            return 125;
        }

        public string køretøj()
        {
            return "MC";
        }




    }
}
