using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MCØresund:Baseklassen
    {
        public override int Pris()
        {
            if (Brobizz==true)
            {
                return 73;
            }

            return 210;
        }

        public override string køretøj()
        {
            return "Øresund MC";
        }
    }
}
