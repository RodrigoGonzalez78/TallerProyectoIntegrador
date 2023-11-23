using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class Periodos : FormPersonalisado
    {
        public Periodos()
        {

            InitializeComponent();
  
        }

        private void Materias_Load(object sender, EventArgs e)
        {
  

            DataGridViewButtonColumn buttonColumn4 = new DataGridViewButtonColumn();
            buttonColumn4.Name = "Editar"; // Name the column
            buttonColumn4.Text = "Editar";    // Text for buttons in the column
            buttonColumn4.UseColumnTextForButtonValue = true; // Display the Text value on buttons


            DataGridViewTextBoxColumn per = new DataGridViewTextBoxColumn();
            per.Name = "periodo"; // Name the column
            per.HeaderText = "periodo";
            per.DataPropertyName = "Periodo";

            DataGridViewTextBoxColumn Desde = new DataGridViewTextBoxColumn();
            Desde.Name = "desde"; // Name the column
            Desde.HeaderText = "Desde";
            Desde.DataPropertyName = "Desde";

            DataGridViewTextBoxColumn hasta = new DataGridViewTextBoxColumn();
            hasta.Name = "hasta"; // Name the column
            hasta.HeaderText = "hasta";
            hasta.DataPropertyName = "Hasta";

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "id"; // Name the column
            id.HeaderText = "ID";
            id.DataPropertyName = "Id";

            dataGridView1.Columns.Add(id);
            dataGridView1.Columns.Add(per);
            dataGridView1.Columns.Add(Desde);
            dataGridView1.Columns.Add(hasta);
            dataGridView1.Columns.Add(buttonColumn4);
            try
            {
                dataGridView1.DataSource= LogicaPeriodo.ListarPeriodos();
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

       

        

        private void BBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogicaMaterias.BuscarMateria(TBBusqueda.Texts);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {

                this.Hide();
                editarPeriodo unPeriodo = new editarPeriodo((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value,
                                                             (DateTime)dataGridView1.Rows[e.RowIndex].Cells[2].Value,
                                                             (DateTime)dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                unPeriodo.Show();
            }
        }

        private void TBBusqueda__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TBBusqueda.Texts))
            {
                dataGridView1.DataSource = LogicaPeriodo.ListarPeriodos();
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                //hacer el busqueda
                dataGridView1.DataSource = LogicaPeriodo.BuscarPeriodo(this.TBBusqueda.Texts);
            }
        }
    }
  
}
