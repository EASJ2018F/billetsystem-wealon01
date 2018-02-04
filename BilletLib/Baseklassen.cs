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
        public DateTime _dato;
        public bool _brobizz;

        public virtual string Nummerplade
        {
            get { return _nummerplade; }
            set
            {
                if (value.Length>7)
                {throw new ArgumentException("nummberpladen må max være 7 tegn");}
                _nummerplade = value;
            }
        }
        
        public virtual DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public virtual bool Brobizz
        {
            get { return _brobizz; }
            set { _brobizz = value; }
        }


        public abstract int Pris();
    
        public abstract string køretøj();




    }
}
