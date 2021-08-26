using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lectura_de_un_archivo_txt
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader lectura;
            string cadena;

            lectura = File.OpenText("identificacion.txt");
            cadena = lectura.ReadLine();

            while (cadena != null)
            {
                
                Console.WriteLine(cadena);
                cadena = lectura.ReadLine();

            }

            lectura.Close();


            Console.ReadKey();

        }

    }


}
