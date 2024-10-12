using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasando
{
    public class Direccion
    {
        public Direccion(string pais,string provincia,string ciudad,string direccion,int numeroCalle,string barrio)
        {
            Pais = pais;
            Provincia = provincia;
            Ciudad = ciudad;
            NombreCalle = direccion;
            NumeroCalle = numeroCalle;
            Barrio = barrio;

        }
        public string Pais { get; }
        public string Provincia { get; }
        public string Ciudad { get; }
        public string NombreCalle { get; }
        public int NumeroCalle { get; }

        public string Barrio { get; }
       

    }
}
