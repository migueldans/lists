using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class CantanteFamoso
    {
        private String nombre, discoConMasVentas;

        //public CantanteFamoso()
        //{

        //}

        public CantanteFamoso(string nombre, string discoConMasVentas)
        {
            this.nombre = nombre;
            this.discoConMasVentas = discoConMasVentas;
        }

        //get-set

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetdiscoConMasventas()
        {
            return discoConMasVentas;
        }
        public void SetdiscoConMasVentas(string discoConMasVentas)
        {
            this.discoConMasVentas = discoConMasVentas;
        }

        public static CantanteFamoso CreaCantante()
        {
            Console.WriteLine("Introduzca el nombre de un/a cantante famoso/a.");
            string introNombre = Console.ReadLine();

            Console.WriteLine("Introduzca el nombre de un/a cantante famoso/a.");
            string introDisco = Console.ReadLine();

            return new CantanteFamoso(introNombre, introDisco);
        }


    }
    


}

