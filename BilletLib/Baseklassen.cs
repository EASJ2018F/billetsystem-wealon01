using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public abstract class Baseklassen
    {
        private string _nummerplade;
        private DateTime _dato;


        public virtual string Nummerplade
        {
            get { return this._nummerplade; }
            set { _nummerplade = value; }
        }

        public virtual DateTime Dato
        {
            get { return this._dato; }
            set { _dato = value; }
        }


        public abstract int Pris();
    
        public abstract string køretøj();




    }
}
