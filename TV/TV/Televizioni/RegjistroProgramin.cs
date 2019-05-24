using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Televizioni
{
  public class RegjistroProgramin
    {
        
        public Pakoja Pako;
        public int NumriProgramit, NumriPersonal, Kontakti ;
        public string EmriProgramit, Shkurtesa, EmriAbonuesit, MbiemriAbonuesit, Adresa, Abonimi;
        public DateTime DataFillimit, DataMbarimit;
        public enum Pakoja
        {
            Familjare,
            Premium,
            FamiljareHD,
            PremiumHD,
            Sport
                
        }
        public abstract class Grupi1
        {
            public abstract string grupi5();

        }
        public class G : Grupi1
        {
            public override string grupi5()
            {
                return "Grupi 5";
            }
        }
        public enum lloji
            {
                Sportiv,
                Argetues,
                Dokumentar,
                Informues,
                Animuar,
   
            }
            public lloji Grupi;
           public int llojet;

        public override string ToString()
        {
            string lista_Programeve;
             lista_Programeve = "";
           foreach (RegjistroProgramin p in Televizioni.Abonimi)
                    {

                        lista_Programeve = lista_Programeve + p.NumriProgramit.ToString() + ". " + p.Shkurtesa.ToString() +/* "Nr Personal: " + p.NumriPersonal.ToString() + "Emri dhe Mbiemri : " + p.EmriAbonuesit.ToString() + " " + p.MbiemriAbonuesit.ToString() + ", Adresa : " + p.Adresa.ToString() + ", Nr. Telefoni : " + p.Kontakti.ToString() + " , Pakoja : " + p.Pako.ToString() + " Data e Fillimit: "*/ Environment.NewLine;
                    }
            return lista_Programeve;
           
        }

        public virtual string lista_Programeve
        {
            get
            {
                return "Numri i Programit : " + NumriProgramit +
                       " \nEmri i Programit : " + EmriProgramit +
                       " \nShkurtesa : " + Shkurtesa +
                       "\nLloji : " + (lloji)llojet;
                      
                       }
        }


             public virtual string Lista_Abonimeve
        {
            get
            {
                return "Numri Personal  : " + NumriPersonal +
                       " \nEmri dhe Mbiemri Abonuesit : " + EmriAbonuesit + " "+ MbiemriAbonuesit +
                       "\nPakoja : " + (Pakoja)llojet +
                "\nData e Fillimit  : " + DataFillimit.ToShortDateString() +
                       " \nData e Mbarimit : " + DataMbarimit.ToShortDateString();
            }
        }

    }
    }
