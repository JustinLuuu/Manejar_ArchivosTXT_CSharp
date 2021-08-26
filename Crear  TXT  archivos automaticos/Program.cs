using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Preview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtiene la ruta para poner los archivos! - en este caso el Directorio/Desktop
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Variables a utilizar

            string word, fileName, filePath;


            //Pide el nombre en la consola1
            Console.WriteLine("Dime tu Nombre:");

            //Lee El Nombre de la consola
            word = Console.ReadLine();

            //Crea el nombre del archivo, que en este caso sería nombre.txt (Felix.txt  en caso que ponga mi nombre es Felix.)
            fileName = word + ".txt";
            //Ruta donde se va a poner el Archivo!
            filePath = folderPath + "\\" + fileName;

            //Esto es un IF para preguntar si el archivo ya existe, es decir si ya había otro Felix O si estoy usando el programa por segunda vez.
            if (File.Exists(filePath))
            {
                //UTILIZAR LA LOGICA DE ARCHIVO QUE YA EXISTE. En tu caso sería leer las peliculas que tienen el usuario!
            }

            //CREAR EL ARCHIVO
            using (StreamWriter outputFile = new StreamWriter(filePath))
                // ESCRIBIR EN EL ARCHIVO! EN ESTE CASO SE ESTA ESCRIBIENDO EL NOMBRE
                outputFile.WriteLine(word);

            // Se Imprime en consola que se ha creado el Archivo!
            Console.WriteLine("File Created with File Name:" + fileName);
            Console.ReadKey();
           
        }
    }
}