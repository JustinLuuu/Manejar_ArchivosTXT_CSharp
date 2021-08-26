using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicios_de_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.Contar el número de palabras de una frase. 

            Console.WriteLine("Escriba una frase :\n");
            string frase = Console.ReadLine();

            string[] arreglo = frase.Split(' ') ;

            Console.WriteLine($"La frase tiene {arreglo.Length} palabras");

            Console.ReadKey();

            */

            /* 2. Eliminar la última palabra de una frase. 

            Console.WriteLine("Escriba una frase :\n");
            string frase = Console.ReadLine();

            string[] arreglo = frase.Split(' ');

            arreglo[arreglo.Length - 1] = "";

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] +  " ");
            }

            Console.ReadKey();

    */

            /* 3. Eliminar la primera palabra de una frase. 

            Console.WriteLine("Escriba una frase :\n");
            string frase = Console.ReadLine();

            string[] arreglo = frase.Split(' ');

            arreglo[arreglo.Length - arreglo.Length] = "";

            for(int i =0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }

            Console.ReadKey();

               */


            /* 3. Contar el número de veces que aparece un carácter en un texto  // PENDIENTEEEE

            int contador = 0;

            Console.WriteLine("Escriba una frase :\n");
            string frase = Console.ReadLine();

            string[] arreglo = frase.Split(' ');

            arreglo[1] = "o";

            Console.WriteLine(arreglo);         
                         
            Console.ReadKey();

         */

            // EJERCICIOS CON FICHEROS 

            /* 1.Leer lineas de texto por teclado y escribirlas en un fichero de texto. 

            string frase = "";
            string respuesta = "";

            do
            {

                Console.WriteLine("Escribe una frase :");
                    frase = Console.ReadLine();
            
                StreamWriter escritor = File.AppendText("ejercicio1.txt");
                escritor.WriteLine(frase);
                escritor.Close();

                Console.WriteLine("Desea seguir escribiendo ? Diga S/N ");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();
                Console.Clear();

            } while(respuesta.Equals("S"));

              */


            /* 2. Leer lineas de texto por teclado y añadirlas al final de un fichero de texto 

            string respuesta = "";
            string frase = "";
            do
            {
                Console.WriteLine("Escriba una frase :");
                frase = Console.ReadLine();
              
                StreamWriter escritor = File.AppendText("ejercicio2.txt");
                escritor.Write(" " + frase);
                escritor.Close();

                Console.WriteLine("Desea seguir escribiendo ? S/N ");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();

            } while (respuesta.Equals("S"));

          */

            /* 3. Leer linea a linea el contenido de un fichero de texto y mostrarlo por pantalla. 

            Console.WriteLine("Escriba el nombre del txt que desea leer :");
            string nombre = Console.ReadLine();

            if (File.Exists(nombre + ".txt"))
            {
                string[] arreglo = File.ReadAllLines(nombre + ".txt");

                 for(int i = 0; i < arreglo.Length; i++)
                 {
                     Console.WriteLine(arreglo[i]);
                 }
            }

            else
            {
                Console.WriteLine("Ese txt no existe..");
            }


            Console.ReadKey();

                */


            /* 4. Leer carácter a carácter el contenido de un fichero de texto y mostrarlo por pantalla. 


            string nombre = "";
       
            Console.WriteLine("Escriba el txt que desea leer :");
            nombre = Console.ReadLine(); 

            if(File.Exists(nombre + ".txt"))
            {
                
                string[] arreglo = File.ReadAllLines(nombre + ".txt");

                string[] contenedor = new string[arreglo.Length];

                for(int i = 0; i < arreglo.Length; i++)
                {
                    contenedor[i] = arreglo[i];
                }

                for (int i = 0; i < contenedor.Length; i++)
                {
                    string verificante = string.Join(" ", contenedor[i].ToArray());
                    Console.WriteLine(verificante);
                }
            }

            else
            {
                Console.WriteLine("Ese txt no existe.. ");
            }

            Console.ReadKey();

             
            */


            /*    6. Leer un fichero de texto que contiene números enteros y mostrarlos por pantalla. 


            string contenedor = "";
            bool encontrado = false;
            int contador = 0;

            Console.WriteLine("Escriba el txt que desea leer");
            string nombre = Console.ReadLine();

            if (File.Exists(nombre + ".txt"))
            {

                StreamReader open = File.OpenText(nombre + ".txt");
                open.Close();

                string[] aux = File.ReadAllLines(nombre + ".txt");

                string[] backup = new string[aux.Length];

                for (int i = 0; i < aux.Length; i++)
                {
                    backup[i] = aux[i];
                }


                string[] arreglo = File.ReadAllLines(nombre + ".txt");

                for (int i = 0; i < arreglo.Length; i++)
                {
                    contenedor = arreglo[i];
                }

                string verificante = string.Join(" ", contenedor.ToArray());


                using (StreamWriter escritor = File.CreateText(nombre + ".txt"))
                {
                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        escritor.WriteLine(verificante);
                    }

                    escritor.Close();
                }


                string[] campos = new string[arreglo.Length];

                StreamReader abrir = File.OpenText(nombre + ".txt");

                string cadena = abrir.ReadLine();

                while (contador != campos.Length)
                {
                    campos = cadena.Split(' ');

                    if (campos[contador] == "1" || campos[contador] == "2" || campos[contador] == "3" ||
                        campos[contador] == "4" || campos[contador] == "5" || campos[contador] == "6" ||
                        campos[contador] == "7" || campos[contador] == "8" || campos[contador] == "9" ||
                        campos[contador] == "0")
                    {

                        Console.WriteLine(campos[contador]);
                        encontrado = true;

                    }
                   
                    contador++;
                    cadena = abrir.ReadLine();

                }

                abrir.Close();
                        

                if (encontrado == false)
                {
                    Console.WriteLine("No hay numeros");
                }

                using (StreamWriter again = File.CreateText(nombre + ".txt"))
                {
                    for (int i = 0; i < aux.Length; i++)
                    {
                        again.WriteLine(backup[i]);
                    }

                    again.Close();
                }


            }

            else
            {
                Console.WriteLine("Ese txt no existe.. ");
            }


            Console.ReadKey();


            */


            // CONTAR CARACTERES DE UNA PALABRA 

            Console.WriteLine("Escribe una palabra");
            string str = Console.ReadLine();

            int numCaracteres = 0;
            for (int i = 0; i < str.Length; i++)
            {
                numCaracteres++;
            }

            Console.WriteLine("Total de caracteres es: " + numCaracteres);

            Console.ReadKey();

           

            /*  8.Obtener la línea más larga y la más corta de un fichero de texto.  PENDIENTEEEEEE  

            
            string mayor = "";
            string menor = "";

            Console.WriteLine("Escriba el txt que desea leer:\n");
            string nombre = Console.ReadLine();

            if (File.Exists(nombre + ".txt"))
            {

                StreamReader open = File.OpenText(nombre + ".txt");
                open.Close();

                string[] arreglo = File.ReadAllLines(nombre + ".txt");

                if (arreglo.Length == 0)
                {
                    Console.WriteLine("El txt esta vacio");
                }

                else
                {

                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        if (arreglo[i].Length > mayor.Length)
                        {
                            mayor = arreglo[i];                            
                        }
                   
                      
                    }           

              

                  
                        Console.Clear();

                        Console.WriteLine("La cadena mas larga es :\n");

                        Console.WriteLine(mayor + "\n");

                        Console.WriteLine("La cadena mas corta es :\n");

                        Console.WriteLine(menor);
 
                }

            }

            else
            {
                Console.WriteLine("Ese txt no existe..");
            }

            Console.ReadKey();

             */


            /*  9. Buscar palabras y cadenas de texto en un archivo. 

            int contador = 0;  
            bool encontrado = false;

           
            Console.WriteLine("Escriba el nombre del txt :");
            string nombre = Console.ReadLine();

            if(File.Exists(nombre + ".txt"))
            {
                Console.WriteLine("Escriba la palabra que desea encontrar :");
                string palabra = Console.ReadLine();

                StreamReader open = File.OpenText(nombre + ".txt");

                string cadena = open.ReadLine();

               while(cadena != null)
               {
                    string[] campos = cadena.Split(' ');

                    for(int i =0; i < campos.Length; i++)
                    {
                        if(campos[i] == palabra)
                        {
                            encontrado = true;
                            contador++;
                           
                        }


                    }

                    cadena = open.ReadLine();

               }

                open.Close();

               if(encontrado == true)
               {
                   Console.WriteLine("Palabra: \"{0}\"  encontrada {1} veces..", palabra,contador);
               }

                else
                {
                    Console.WriteLine("Palabra: \"{0}\" no ha sido encontrada en el txt",palabra);
                }


            }

            else
            {
                Console.WriteLine("Ese txt no existe..");
            }

            Console.ReadKey();

            */

            /* 10. Crear un ficheo de texto con caracteres aleatorios. 

               
                   Console.WriteLine("Quiere llenar el txt de caracteres aleatorios ? S/N");
                   string respuesta = Console.ReadLine();
                   respuesta = respuesta.ToUpper();
                 
                   if (respuesta.Equals("S"))
                   {

                     here:
                       Console.WriteLine("Escriba [ 1 ] para letras o [ 2 ] para numeros " );
                       int opcion = Convert.ToInt32(Console.ReadLine());
                 
                       if(opcion != 2 && opcion != 1)
                       {
                           Console.Clear();
                           Console.WriteLine("Esa no es una opcion !!, presione una tecla para volver a responder :");
                           string volver = Console.ReadLine();
                 
                           if(volver== "whatever")
                           {
                              Console.Clear();
                             goto here;
                           }

                          else
                          {
                              Console.Clear();
                              goto here;
                          }

                       }


                      switch (opcion)
                      {
                 
                          case 1:
                 
                              StreamReader open = File.OpenText("ejercicio10.txt");
                              open.Close();
                 
                              string[] arreglo = { "a", "b", "c", "d", "e", "f", "g","h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                              "r", "s", "t", "u", "v", "w", "x", "y", "z"};

                        Random aleatorio = new Random();

                        StreamWriter escritor = File.AppendText("ejercicio10.txt");

                        for (int i = 0; i < 40; i++)
                        {
                            int numerito = aleatorio.Next(0, 26);

                            escritor.WriteLine(arreglo[numerito]);
                        }

                          escritor.Close();

                        for (int i = 0; i < 2500; i++)
                        {
                            Console.WriteLine("Proceso completo");
                        }
                              break;

                           case 2:

                        StreamReader open0 = File.OpenText("ejercicio10.txt");
                        open0.Close();

                        Random random = new Random();

                        StreamWriter writer = File.AppendText("ejercicio10.txt");

                        for(int i =0; i < 50; i++)
                        {
                            int numeros = random.Next(0, 100);

                            writer.WriteLine(numeros);
                        }

                        writer.Close();

                        for (int i = 0; i < 2500; i++)
                        {
                            Console.WriteLine("Proceso completo");
                        }
                               break;

                      } 
                                      
                   }
                 
                   else
                   {
                       for(int i = 0; i < 2500; i++)
                       {
                           Console.WriteLine("[ PROCESO CANCELAOD ]");
                       }
                   }
                 

                      */

        }
    }
}
