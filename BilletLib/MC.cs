using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC:Baseklassen
    {
        public override int Pris()
        {
            if (Brobizz==true)
            {
                return 125 / 100 * 95;
            }
            else
            {
                return 125;
            }
        }

        public override string køretøj()
        {
            return "MC";
        }

    }
}
