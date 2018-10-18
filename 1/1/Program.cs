using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)

            ////+++++++++++++++++++++++++++++++++++++ejercicio 1++++++++++++++++++++++++++++
        //{
        //    List<string> compra = new List<string>();
        //    CrearLista(compra);
        //    foreach (String x in compra)
        //    {
        //        Console.WriteLine(x);
        //    }
        //    OrdenarLista(compra);
        //    foreach (String x in compra)
        //    {
        //        Console.WriteLine(x);
        //    }
        //    BorrarDeLaLista(compra);

        //    foreach (String x in compra)
        //    {
        //        Console.WriteLine(x);
        //    }
        //    ContarElementos(compra);
        //    Console.ReadLine();
        //}
        //public static void CrearLista(List<string> compra)
        //{
        //    compra.Add("tomate");
        //    compra.Add("pera");
        //    compra.Add("pepino");
        //    compra.Add("remolacha");
        //    compra.Add("guisantes");
        //    compra.Add("calabacines");
        //}

        //public static void OrdenarLista(List<string>compra)
        //{
        //    compra.Sort();
        //}

        //public static void BorrarDeLaLista(List<string>compra)
        //{
        //    compra.Remove("pera");
        //}

        //public static void ContarElementos(List<string>compra)
        //{
        //    Console.Write(compra.Count());
        //}
        ////++++++++++++++++++++++++++++++++++++++++ejercicio 2++++++++++++++++++++++++++++++++
        //{

        //    List<double> decimales = new List<double>();
        //    List<double> enteros = new List<double>();


        //    bool negativo = false;
        //    try
        //    {
        //        while (negativo == false)
        //        {
        //            Console.WriteLine("Introduzca un numero");

        //            double numero = Convert.ToDouble(Console.ReadLine());
        //            string checkNumero = numero.ToString();
        //            {
        //                if (numero < 0)
        //                {
        //                    negativo = true;
        //                }
        //                else if (checkNumero.Contains(","))
        //                {
        //                    decimales.Add(numero);
        //                }
        //                else
        //                {
        //                    int nochecknumero = Convert.ToInt32(numero);
        //                    enteros.Add(nochecknumero);
        //                }
        //            }
        //        }
        //    }
        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine("El caracter introducido no es un numero.");
        //    }

        //    foreach (double x in decimales)
        //    {
        //        Console.WriteLine(x);
        //    }

        //    foreach (int x in enteros)
        //    {
        //        Console.WriteLine(x);
        //    }
        //    Console.ReadLine();

        //    Console.WriteLine(decimales.Sum()+enteros.Sum());
        //    double suma = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine(decimales.Count() + enteros.Count());
        //    int cuenta = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(suma / cuenta);
        //    Console.ReadLine();



        //}
        ////+++++++++++++++++++++++++++++++Ejericio 3+++++++++++++++++++++++++++++++++
        {
            CantanteFamoso cantante1 = new CantanteFamoso("David Hasselhof", "Looking for Freedom");
            CantanteFamoso cantante2 = new CantanteFamoso("Emilio Aragón", "Te Huelen los Pies");

            //CantanteFamoso cantantes = new CantanteFamoso();


            List<CantanteFamoso> listaCantantesFamosos = new List<CantanteFamoso>
            {
                cantante1,
                cantante2
            };

            Show(listaCantantesFamosos);

            bool salir = false;
            while(salir == false)
                {
                Console.WriteLine("¿Desea seguir?");
                string respuesta = Console.ReadLine();
                     if (respuesta.ToUpper() =="SI")
                     {
                     listaCantantesFamosos.Add(CantanteFamoso.CreaCantante());
                     }
                     else if(respuesta.ToUpper() == "NO")
                     {
                     salir = true;
                     
                     }
                }

            Show(listaCantantesFamosos);

        }
        public static void Show(List<CantanteFamoso>listaCantantesFamosos)
        {
            foreach(CantanteFamoso cantante in listaCantantesFamosos)
            {
                Console.WriteLine(cantante.GetNombre() + ", " + cantante.GetdiscoConMasventas());
            }
            Console.ReadLine();
        }

        //public static CantanteFamoso CreaCantante()
        //{
        //    Console.WriteLine("Introduzca el nombre de un/a cantante famoso/a.");
        //    string introNombre = Console.ReadLine();

        //    Console.WriteLine("Introduzca el nombre de un/a cantante famoso/a.");
        //    string introDisco = Console.ReadLine();

        //    CantanteFamoso cIntro = new CantanteFamoso(introNombre, introDisco);

        //    return cIntro;
        //}
    }
}
