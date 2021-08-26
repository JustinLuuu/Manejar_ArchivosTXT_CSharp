using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivo_conservando_datos_Existentes_TXT
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta, cadena, cadenaread;

            respuesta = "";
            cadena = "";
            cadenaread = "";

            //Crear / Abrir el archivo 

            StreamWriter escribir = File.AppendText("database.txt");

            do
            {
                
                Console.WriteLine("Ingresa un texto");
                cadena = Console.ReadLine() ;    

                //Escribir en el archivo

                escribir.WriteLine(cadena);

                Console.WriteLine("Deseas seguir escribiendo? (SI / NO)");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();
                        
            } while (respuesta.Equals("SI"));

            escribir.Close();

            StreamReader leer = File.OpenText("database.txt");
            cadenaread = leer.ReadLine();

            while (cadenaread != null)
            {
                Console.WriteLine(cadenaread);
                cadenaread = leer.ReadLine();

            }
         
            leer.Close();

                    Console.ReadKey();
        }
    }
}
