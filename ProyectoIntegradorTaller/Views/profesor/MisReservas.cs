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
    public partial class MisReservas : FormPersonalisado
    {
        public MisReservas()
        {
            InitializeComponent();
            dataGridView2.DataSource= LogicaReserva.BusquedaReservasPorNombreAula("SI", Session.SessionCacheData.Id, "");
            dataGridView2.Columns[0].Visible = false;
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.Name = "Eliminar"; 
            buttonColumn1.Text = "Eliminar";   
            buttonColumn1.UseColumnTextForButtonValue = true;

            dataGridView2.Columns.Add(buttonColumn1);
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeProfesor homeProfesor = new HomeProfesor();
            homeProfesor.Show();
        }

       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere eliminar la reserva en " + (string)dataGridView2.Rows[e.RowIndex].Cells["Nombre"].Value + "  ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ask == MsgBoxResult.Yes)
                {
                    int idreserva = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Id"].Value);

                    LogicaReserva.EliminarReserva(idreserva);
                    dataGridView2.DataSource = LogicaReserva.BusquedaReservasPorNombreAula("SI", Session.SessionCacheData.Id, "");
                }

            }
        }

        private void TBBusqueda__TextChanged(object sender, EventArgs e)
        {
            switch (CBFiltro.Texts)
            {
                case "NombreAula":
                    dataGridView2.DataSource = LogicaReserva.BusquedaReservasPorNombreAula("SI", Session.SessionCacheData.Id, TBBusqueda.Texts);
                    break;
                case "Hora":
                    dataGridView2.DataSource = LogicaReserva.BusquedaReservasPorHora("SI", Session.SessionCacheData.Id, TBBusqueda.Texts);
                    break;
                case "Dia":
                    dataGridView2.DataSource = LogicaReserva.BusquedaReservasPorDia("SI", Session.SessionCacheData.Id, TBBusqueda.Texts);
                    break;
                case "Materia":
                    dataGridView2.DataSource = LogicaReserva.BusquedaReservasMateria("SI", Session.SessionCacheData.Id, TBBusqueda.Texts);
                    break;
                default:
                    break;
            }
        }
    }
}
