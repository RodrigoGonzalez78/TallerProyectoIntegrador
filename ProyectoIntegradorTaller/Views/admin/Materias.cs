using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using ProyectoIntegradorTaller.views.profesor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

using System.Runtime.Remoting.Messaging;
using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class Materias : FormPersonalisado
    {
        public Materias()
        {

            InitializeComponent();
  
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            
            DataGridViewButtonColumn buttonColumn4 = new DataGridViewButtonColumn();
            buttonColumn4.Name = "Eliminar"; // Name the column
            buttonColumn4.Text = "Eliminar";    // Text for buttons in the column
            buttonColumn4.UseColumnTextForButtonValue = true; // Display the Text value on buttons


            DataGridViewTextBoxColumn materias = new DataGridViewTextBoxColumn();
            materias.Name = "materia"; // Name the column
            materias.HeaderText = "materia";
            materias.DataPropertyName = "Materia";

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "id"; // Name the column
            id.HeaderText = "ID";
            id.DataPropertyName = "Id";

            dataGridView1.Columns.Add(id);
            dataGridView1.Columns.Add(materias);
            dataGridView1.Columns.Add(buttonColumn4);
            try
            {
                dataGridView1.DataSource=LogicaMaterias.ListarMateriasActivas();
               // LogicaMaterias.listarMaterias(dataGridView1);
                dataGridView1.Columns[0].Visible = false;
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
        

        private void BCrearAula_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearAula aula=new CrearAula();
            aula.Show();
        }

        

        private void BVolver_Click(object sender, EventArgs e)
        {

            switch (Session.SessionCacheData.IdProfile)
            {

                case 1:
                    menuAdmin homeAdmin = new menuAdmin();

                    homeAdmin.Show();
                    break;
                case 3:
                    BedelMenu menuBedel = new BedelMenu();
                    menuBedel.Show();
                    break;
                
            }

            this.Hide();

        }

       

        private void BAgregarMateria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TMateria.Texts))
            {
                LogicaMaterias.AgregarMateria(this.TMateria.Texts);
                    MessageBox.Show("materia ingresada correctamente!", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TMateria.Texts  = " ";

                dataGridView1.DataSource = LogicaMaterias.ListarMateriasActivas();
            }
            else
            {
                MessageBox.Show("El campo esta vacio!");
            }

        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= LogicaMaterias.BuscarMateria(TBBusqueda.Texts);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere eliminar la materia " + (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value + "  ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ask == MsgBoxResult.Yes)
                {
                    int idMateria = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    LogicaMaterias.MateriasCambiarEstado("NO", idMateria);
                    dataGridView1.DataSource = LogicaMaterias.ListarMateriasActivas();
                }

            }
        }

        private void TBBusqueda__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TBBusqueda.Texts))
            {
                dataGridView1.DataSource = LogicaMaterias.ListarMateriasActivas();
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                //hacer el busqueda
                dataGridView1.DataSource = LogicaMaterias.BuscarMateria(this.TBBusqueda.Texts);
            }
        }
    }
  
}
