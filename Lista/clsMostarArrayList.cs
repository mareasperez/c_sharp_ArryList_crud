using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public class clsMostarArrayList
    {
        ArrayList Lista;
        public clsMostarArrayList()
        {
            Lista = new ArrayList();
        }
        public void Capturadatos()
        {
            string cadena;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el elemento {0}: ", i + 1);
                cadena = Console.ReadLine();
                Lista.Add(cadena);
            }
        }
        public void BuscaDato()
        {
            string busqueda;
            Console.WriteLine("Ingrese el Nombre a buscar");
            busqueda = Console.ReadLine();
            if (Lista.Contains(busqueda))
            {
                Console.WriteLine("El Nombre: " + busqueda + " se encontro en la lista");
            }
            else
            {
                Console.WriteLine("El Nombre: " + busqueda + " no se encontro en la lista");
            }
            //Console.ReadKey();
        }

        public void ImprimeDatos()
        {
            Console.WriteLine("Imprimiendo Datos de la lista");
            foreach (string item in Lista)
            {
                Console.WriteLine(item);
            }
            //Console.ReadKey();
        }
        public void EliminaDato()
        {
            string busqueda;
            Console.WriteLine("Ingrese el Nombre a eliminar");
            busqueda = Console.ReadLine();
            if (Lista.Contains(busqueda))
            {
                Lista.Remove(busqueda);
                Console.WriteLine("Se elimino: " + busqueda);
                ImprimeDatos();
            }
            else
            {
                Console.WriteLine("El Nombre: " + busqueda + " no se encontro en la lista");
                Console.WriteLine("La lista de elementos disponibles es la liguiente:");
                ImprimeDatos();
            }
        }

    }
}
