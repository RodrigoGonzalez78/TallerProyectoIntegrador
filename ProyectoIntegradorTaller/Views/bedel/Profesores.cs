using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;
using ProyectoIntegradorTaller.views.profesor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class Profesores : FormPersonalisado
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.Name = "Editar"; // Name the column
            buttonColumn1.Text = "Editar";    // Text for buttons in the column
            buttonColumn1.UseColumnTextForButtonValue = true; // Display the Text value on buttons


            dataGridView1.DataSource=LogicaUsuarios.ListarUsuariosPorId(4);
            dataGridView1.Columns.Add(buttonColumn1);
        }

        private void BVolver_Click(object sender, EventArgs e)
        {

            BedelMenu menuBedel = new BedelMenu();
            menuBedel.Show();
            this.Hide();
        }

        private void BCrearProfesor_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearProfesor crearProfesor = new CrearProfesor();
            crearProfesor.Show();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rjTextBox1.Texts))
            {
                switch (CBFiltro.Texts)
                {
                    case "Nombre":
                        dataGridView1.DataSource = LogicaUsuarios.buscarNombre(4, rjTextBox1.Texts);
                        break;
                    case "Apellido":
                        dataGridView1.DataSource = LogicaUsuarios.buscarApellido(4, rjTextBox1.Texts);
                        break;
                    case "DNI":
                        dataGridView1.DataSource = LogicaUsuarios.buscarDNI(4, rjTextBox1.Texts);
                        break;
                    case "Correo":
                        dataGridView1.DataSource = LogicaUsuarios.buscarEmail(4, rjTextBox1.Texts);
                        break;
                  
                    default:
                       
                        break;
                }

            }
            else
            {
                dataGridView1.DataSource = LogicaUsuarios.BuscarUsuarioProfesor(rjTextBox1.Texts);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                this.Hide();

                CrearProfesor unprofesor = new CrearProfesor((int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value,
                    (string)dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value,
                    (string)dataGridView1.Rows[e.RowIndex].Cells["Apellido"].Value,
                    (int)dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value,
                    (string)dataGridView1.Rows[e.RowIndex].Cells["Email"].Value
              );

                unprofesor.Show();

            }
        }
    }
}
