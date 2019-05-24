using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Televizioni
{

  public abstract class RegjistroAbonimin_1 : RegjistroProgramin
    {
       
    }

    public class RegjistroAbonimin : RegjistroAbonimin_1
    {
        public RegjistroProgramin p { get; set; }

    }



}
