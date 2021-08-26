using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uso_de_Try.Parse_y_Out_en_sencillo_ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("En el numero entero hay " + funcion(number) + " pares");
            Console.ReadKey();
        }

        static int funcion(int numero)
        {
            int contador = 0;

            string conversor = numero.ToString();  //CONVIRTIENDO DE INT A STRING

           
            for (int i = 0; i < conversor.Length; i++)
            {
                int retenedor = 0;   // UNA VARIABLE QUE CAMBIARA SU VALOR A MEDIDA QUE EL BUCLE VAYA EJECUTANDO
                int.TryParse(conversor[i].ToString(), out retenedor);   // EL 'TRY.PARSE' CONVIERTE EL NUMERO REPRESENTADO POR UN 'STRING' o 'CHAR' A 'INT' Y SE ALMACENA EN LA VARIBLE RETENEDOR CON EL 'OUT', EN ESTE CASO ES UN CHAR , PERO COMO PODEMOS VER, AL RECORRER EL STRING, COMO EL STRING ES UN ARREGLO O COLECCION DE CHAR, AL RECORRERLO UNO POR UNO CADA POSICION CUENTA COMO UN CHAR, PERO EL TRY.PARSE ESTA DISEñADO PARA CONVERTIR DE STRING A INT POR ESO LE PONEMOS EL METODO CONVERTIDOR .ToSTRING() 

                if (retenedor % 2 == 0)  // UNA VEZ CONVERTIDO A INT ENTONCES SI CUENTA COMO INT, Y POSTERIORMENTE NOS ASEGURAMOS SI ES PAR Y LISTO
                {
                    contador++;  // CONTARA SOLO LOS NUMEROS QUE SON PARES
                }
            }


            return contador;

        }

    }
}
