using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos_de_texto__ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear / abrir el archivo 

            StreamWriter escritura = File.CreateText("ejemplo.txt");

            //Escribiendo en el archivo 

            escritura.WriteLine("Bienvenido a esta mini base de datos");
            escritura.WriteLine("Que felicidad");

            //Cerrar el archivo     
    
            escritura.Close();

            

        }
    }
}
