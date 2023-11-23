//using ProyectoIntegradorTaller.formularios;
using DraggingControl;
using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class Usuarios : FormPersonalisado
    {
        SqlConnection connection = new SqlConnection("");

        public Usuarios()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuAdmin homeAdmin = new menuAdmin();
            homeAdmin.Show();
        }

        private void BCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.Show();

        }


        private void Usuarios_Load(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.DataSource=LogicaUsuarios.ListarUsuarios(RBActivo.Checked);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    this.Hide();
                    int tipo = 1;
                    if ((string)dataGridView1.Rows[e.RowIndex].Cells["Tipo"].Value == "bedel")
                    {
                        tipo = 3;
                    }
                    // MessageBox.Show((string)dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value);
                    CrearUsuario usuario = new CrearUsuario((string)dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value,
                    (string)dataGridView1.Rows[e.RowIndex].Cells["Apellido"].Value,
                    (string)dataGridView1.Rows[e.RowIndex].Cells["Email"].Value,
                    (int)dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value,
                    tipo,
                    (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    usuario.Show();
                }

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Desactivar")
                {
                    string valorCelda = dataGridView1.Rows[e.RowIndex].Cells["Activo"].Value.ToString();
                    int idUsuario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    dataGridView1.Rows[e.RowIndex].Cells["Desactivar"].Value = valorCelda;

                    LogicaUsuarios.UsuarioCambiarEstado(valorCelda,idUsuario);
                    dataGridView1.DataSource=LogicaUsuarios.ListarUsuarios(RBActivo.Checked);
                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "blanquear")
                {

                    String dni = dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
                    int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                    LogicaUsuarios.CambiarPassword(dni, id);
                    MessageBox.Show("Se blanque la contraseña correctamente!", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void RBDesactivados_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogicaUsuarios.ListarUsuarios(RBActivo.Checked);
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rjTextBox1.Texts))
            {
                switch (CBFiltro.Texts)
                {
                    case "Nombre":
                        dataGridView1.DataSource = LogicaUsuarios.buscarNombre(RBActivo.Checked, rjTextBox1.Texts);
                        break;
                    case "Apellido":
                        dataGridView1.DataSource = LogicaUsuarios.buscarApellido(RBActivo.Checked, rjTextBox1.Texts);
                        break;
                    case "DNI":
                        dataGridView1.DataSource = LogicaUsuarios.buscarDNI(RBActivo.Checked, rjTextBox1.Texts);
                        break;
                    case "Correo":
                        dataGridView1.DataSource = LogicaUsuarios.buscarEmail(RBActivo.Checked, rjTextBox1.Texts);
                        break;
                    case "Tipo":
                        dataGridView1.DataSource = LogicaUsuarios.buscarTipo(RBActivo.Checked, rjTextBox1.Texts);
                        break;

                    default:
                        dataGridView1.DataSource = LogicaUsuarios.BuscarUsuario(this.rjTextBox1.Texts);
                        break;
                }
              
            }
            else
            {
                dataGridView1.DataSource = LogicaUsuarios.ListarUsuarios(RBActivo.Checked);
            }
            
        }


    }
}