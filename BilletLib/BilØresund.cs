using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class BilØresund:Baseklassen
    {

        public override int Pris()
        {
            if (Brobizz == true)
            {
                return 161;
            }

            return 410;
        }

        public override string køretøj()
        {
            return "Øresund Bil";
        }






    }
}
