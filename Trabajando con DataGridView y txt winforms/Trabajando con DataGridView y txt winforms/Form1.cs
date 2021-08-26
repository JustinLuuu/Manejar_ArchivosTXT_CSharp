using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajando_con_DataGridView_y_txt_winforms
{
    public partial class Form1 : Form
    {
        Cargar cargar = new Cargar();

        public Form1()
        {
            InitializeComponent();
            CargarDataGridView();
            CargarComboBox();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {            
             if(txtApellido.Text != "" && txtCedula.Text != "" && txtNombre.Text != "")
             {
                if (txtCedula.Text.Length == 8)
                {
                    Cliente agregarCliente = new Cliente()
                    {
                        NOMBRE = txtNombre.Text,
                        APELLIDO = txtApellido.Text,
                        CEDULA = txtCedula.Text
                    };

                    agregarCliente.Agregar(); 
                    CargarDataGridView();
                    CargarComboBox();
                }

                else
                {
                    MessageBox.Show("La cedula debe tener 8 digitos ! ");
                }

             }

            else
            {
                MessageBox.Show("Imposible agregar cliente con campos vacios !");
            }

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(cmbClientes.Text != "Seleccionar un cliente")
            {
                Cliente eliminarCliente = new Cliente();
                int id;

                string[] sep = cmbClientes.Text.Split(' ');
                id = Convert.ToInt32(sep[3].Trim());
                eliminarCliente.Eliminar(id);


                CargarDataGridView();
                CargarComboBox();
            }

            else
            {
                MessageBox.Show("Imposible eliminar sin haber seleccionado el cliente !");
            }

        }


        private void cmbClientes_SelectedValueChanged(object sender, EventArgs e)
        {

        }


        void CargarDataGridView()
        {
            DataTable tabla = new DataTable();
            tabla = cargar.CargarDT();

            dgvListadoClientes.DataSource = tabla;
        }


        void CargarComboBox()
        {
            cargar.llenarCombo( ref cmbClientes);
        }

            
    }
}
