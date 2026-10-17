using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Subtema_5._1
{
    internal class Program
    {
        static string NombreArchivo = "ListaProductos.txt";
        static void Main(string[] args)
        {
            MenuPrincipal();
        }
        static void AgregarNuevoProducto()
        {
            StreamWriter NuevoDocumento = new StreamWriter (NombreArchivo, true);
            Console.Write("Ingrese el nombre del producto a registrar: ");
            string producto = Console.ReadLine();
            NuevoDocumento.WriteLine (producto);
            NuevoDocumento.Close();
        }

        static void GenerarReporte()
        {
            StreamReader LeerDocumento = new StreamReader(NombreArchivo);
            int contador = 0;
            string linea;
            string UltimoProducto = "";
            while ((linea = LeerDocumento.ReadLine()) != null)
            {
                Console.WriteLine("Productos: "+ linea);
                contador++;
                UltimoProducto = linea;
            }
            Console.WriteLine("El total de productos en el almacen es: " + contador);
            Console.WriteLine("El ultimo producto registrado es: " + UltimoProducto);
            LeerDocumento.Close ();
        }
        static void MenuPrincipal()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("================MENU PRINCIPAL================");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Mostrar la cantidad y la lista de productos");
            Console.WriteLine("3. Salir");
            opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    AgregarNuevoProducto();
                    break;

                case 2:
                    GenerarReporte();
                    break;

                case 3:
                    Console.WriteLine("3. Saliendo...");
                    break;

                default: Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}
