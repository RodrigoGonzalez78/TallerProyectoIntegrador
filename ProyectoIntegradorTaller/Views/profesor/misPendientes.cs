using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;

namespace ProyectoIntegradorTaller.views.profesor
{
    public partial class misPendientes : FormPersonalisado
    {
        public misPendientes()
        {
            InitializeComponent();
            
            dataGridView1.DataSource= LogicaReserva.BusquedaReservasPorNombreAula("NO", Session.SessionCacheData.Id, "");
            dataGridView1.Columns[0].Visible = false;
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.Name = "Eliminar"; 
            buttonColumn1.Text = "Eliminar";    
            buttonColumn1.UseColumnTextForButtonValue = true; 


            dataGridView1.Columns.Add(buttonColumn1);
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeProfesor homeProfesor = new HomeProfesor();
            homeProfesor.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere eliminar la reserva en " + (string)dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value + "  ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ask == MsgBoxResult.Yes)
                {
                    int idreserva = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    LogicaReserva.EliminarReserva(idreserva);
                    dataGridView1.DataSource = LogicaReserva.BusquedaReservasPorNombreAula("NO", Session.SessionCacheData.Id, "");
                }

            }
        }

        private void BVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomeProfesor homeProfesor = new HomeProfesor();
            homeProfesor.Show();
        }

        private void TBBusqueda__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBBusqueda.Texts))
            {
                dataGridView1.DataSource = LogicaReserva.BusquedaReservasPorNombreAula("NO", Session.SessionCacheData.Id, "");
            }
            else
            {
                switch (CBFiltro.Texts)
                {
                    case "NombreAula":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasPorNombreAula("NO", Session.SessionCacheData.Id, TBBusqueda.Texts);
                        break;
                    case "Hora":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasPorHora("NO", Session.SessionCacheData.Id, TBBusqueda.Texts);
                        break;

                    case "Dia":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasPorDia("NO", Session.SessionCacheData.Id, TBBusqueda.Texts);
                        break;
                    case "Materia":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasMateria("NO", Session.SessionCacheData.Id, TBBusqueda.Texts);
                        break;
                    default:

                        break;
                }
            }
     
            
        }
    }
}
