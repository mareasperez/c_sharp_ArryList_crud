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
            bool continuar = true;
            char seleccion;
            do
            {

                Console.WriteLine("\n-----MENU------");
                Console.WriteLine("1) Ingresar Nombres.");
                Console.WriteLine("2) Imprimir Nombres.");
                Console.WriteLine("3) Buscar Nombre.");
                Console.WriteLine("4) Eliminar Nombre.");
                seleccion = Console.ReadLine().ToString()[0];
                switch (seleccion)
                {
                    case '1':
                        Muestra.Capturadatos();
                        break;
                    case '2':
                        Muestra.ImprimeDatos();
                        break;
                    case '3':
                        Muestra.BuscaDato();
                        break;
                    case '4':
                        Muestra.EliminaDato();
                        break;
                    default:
                        Console.WriteLine("Saliendo...");
                        continuar = false; break;
                }
            } while (continuar);

        }
    }
}
