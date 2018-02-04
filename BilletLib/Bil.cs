using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil:Baseklassen
    {       
        public override string Nummerplade { get; set; }

        public override int Pris()  
        {
            if (Dato.DayOfWeek == DayOfWeek.Sunday || Dato.DayOfWeek == DayOfWeek.Saturday)
            {
                return 240 / 100 * 80;
            }
            if (Brobizz == true)
                {                   
                    return 240 / 100 * 95;
                }                
            else
            {
                return 240;
            }
        }

        public override string køretøj()
        {
            return "Bil";
        }

    }
}