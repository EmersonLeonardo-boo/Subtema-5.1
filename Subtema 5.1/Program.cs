using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtema_5._1
{
    internal class Program
    {
        static string NombreArchivo = "ListaProductos.txt";
        static void Main(string[] args)
        {
            AgregarNuevoProducto();
        }
        static void AgregarNuevoProducto()
        {
            StreamWriter NuevoDocumento = new StreamWriter (NombreArchivo, true);
            Console.Write("Ingrese el nombre del producto a registrar: ");
            string producto = Console.ReadLine();
            NuevoDocumento.WriteLine (producto);
            NuevoDocumento.Close();
        }
    }
}
