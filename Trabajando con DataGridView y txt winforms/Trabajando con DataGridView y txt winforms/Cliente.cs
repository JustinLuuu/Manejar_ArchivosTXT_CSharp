using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trabajando_con_DataGridView_y_txt_winforms
{
    class Cliente
    {
        private string nombre;
        private string apellido;
        private string cedula;

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
            
        public string APELLIDO
        {
            get { return apellido; }
            set { apellido = value.ToUpper(); }
        }

        public string CEDULA
        {
            get { return cedula; }
            set { cedula = value; }
        }



      private string[] separador;

        public void Agregar()
        {
            int id;
            bool existCedula = false;

            var numeroClientes = File.ReadAllLines("clientes.txt");

            foreach (string linea in numeroClientes )
            {
                separador = linea.Split('/');

                if(separador[3].Trim().Equals(CEDULA))
                {
                    existCedula = true;
                    break;
                }
            }

            if (existCedula == false)
            {
                id = numeroClientes.Length + 1;

                StreamWriter agregar = File.AppendText("clientes.txt");     
                agregar.WriteLine(id  + "/ " + NOMBRE + "/ " + APELLIDO + "/ " + CEDULA);
                agregar.Close();

                MessageBox.Show("Cliente agregado con exito");
                agregar.Close();
            }

            else
            {
                MessageBox.Show("YA EXISTE UN CLIENTE CON ESE NUMERO DE CEDULA !");
            }

        }

       
        public void Eliminar(int id)
        {
            List<string> lista = new List<string>();
            var contenedorTxt = File.ReadAllLines("clientes.txt");

            for (int i = 0; i < contenedorTxt.Length ; i++)
            {
                separador = contenedorTxt[i].Split('/');

                if (Convert.ToInt32(separador[0]).Equals(id))
                {
                    lista = contenedorTxt.ToList();
                    lista.RemoveAt(i);

                    using (StreamWriter crear = File.CreateText("clientes.txt"))
                    {
                        for(int e =0; e < lista.Count; e++)
                        {
                            crear.WriteLine(lista[e]);
                        }
                        crear.Close();
                    }
                    
                    break;
                }
            }

            MessageBox.Show("Cliente eliminado con exito !");
        }




    }
}
