using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Trabajando_con_DataGridView_y_txt_winforms
{
    class Cargar
    {
       private string[] sep;
        
        public DataTable CargarDT()
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("ID");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");  
            tabla.Columns.Add("Cedula");

            StreamReader abrir = File.OpenText("clientes.txt");
            string leer = abrir.ReadLine();

            while(leer != null) 
            {
                DataRow fila = tabla.NewRow();

                sep = leer.Split('/');
                fila["ID"] = sep[0].Trim();
                fila["Nombre"] = sep[1].Trim();
                fila["Apellido"] = sep[2].Trim();
                fila["Cedula"] = sep[3].Trim();

                tabla.Rows.Add(fila);

                leer = abrir.ReadLine();
            }
            abrir.Close();

            return tabla;
        }


        public void llenarCombo(ref ComboBox combo)
        {
            combo.Items.Clear();

            StreamReader abrir = File.OpenText("clientes.txt");
            string leer = abrir.ReadLine();

            while (leer != null)
            {
                sep = leer.Split('/');
                combo.Items.Add($" ID [ {sep[0]} ] -  {sep[1].Trim()} ");    

                leer = abrir.ReadLine();
            }
            abrir.Close();
        }


    }

}
