using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televizioni
{

    public partial class Televizioni
    {
        public static List<RegjistroProgramin> Programi = new List<RegjistroProgramin>();
        public static List<RegjistroAbonimin> Abonimi = new List<RegjistroAbonimin>();
    
    }
    public partial class Televizioni
    {
        public static bool RegjistroProgramin(RegjistroProgramin p)
        {
            try
            {
                Televizioni.Programi.Add(p);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool Regjistro_Abonimin(RegjistroAbonimin a)
        {


            try
            {
                Televizioni.Abonimi.Add(a);
                return true;
            }
            catch
            {
                return false;
            }

        }
        

        }
    }

