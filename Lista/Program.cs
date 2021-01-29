using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMostarArrayList Muestra = new clsMostarArrayList();
            //Muestra.Capturadatos();
            //Muestra.ImprimeDatos();
            //Muestra.BuscaDato();
            //Muestra.EliminaDato();
            bool continuar = true;
            do
            {
                Console.WriteLine("-----MENU------");
                Console.WriteLine("1) Ingresar Nombres.");
                Console.WriteLine("2) Imprimir Nombres.");
                Console.WriteLine("1) Buscar Nombre.");
                Console.WriteLine("3) Eliminar Nombre.");
                //seleccion = Console.ReadKey();
            } while (continuar);

        }
    }
}
