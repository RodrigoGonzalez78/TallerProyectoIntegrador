using DraggingControl;
using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.admin;
using ProyectoIntegradorTaller.views.components;
using ProyectoIntegradorTaller.views.profesor;
using System;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin

{
    public partial class ReservasPendientes : FormPersonalisado
    {
        public ReservasPendientes()
        {
            InitializeComponent();
            dataGridView1.DataSource= LogicaReserva.ListarReservasPorEstado("NO");
            dataGridView1.Columns["Id"].Visible = false;
           

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Autorizar")
            {
                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere autorizar la reserva en el  " + (string)dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value + "  ?", "Reservar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ask == MsgBoxResult.Yes)
                {
                    var unaReserva = LogicaReserva.reservaDisponible((string)dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells["Periodo"].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells["Hora"].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells["Dia"].Value);
                    if (unaReserva.Count==0)
                    {
                        int idUsuario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                        LogicaReserva.ReservaActiva("SI", idUsuario);
                        dataGridView1.DataSource = LogicaReserva.ListarReservasPorEstado("NO");
                    }
                    else
                    {
                        MessageBox.Show("NO se puede autorizar esta solicitud debido a que ya existe una reserva en ese dia en ese  horario en ese Aula");
                    }
   
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere eliminar la reserva en el  " + (string)dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value + "  ?", "Reservar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ask == MsgBoxResult.Yes)
                {
                    int idReserva = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    LogicaReserva.EliminarReserva(idReserva);
                    dataGridView1.DataSource = LogicaReserva.ListarReservasPorEstado("NO");
                }
            }
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            BedelMenu bedel = new BedelMenu();
            bedel.Show();
        }

        private void TBBusqueda__TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(CBFiltro.Texts))
            {
                dataGridView1.DataSource = LogicaReserva.ListarReservasPorEstado("NO");
                dataGridView1.Columns["Id"].Visible = false;
            }
            else
            {
                switch (CBFiltro.Texts)
                {
                    case "NombreAula":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasPorNombreAula("NO",TBBusqueda.Texts);
                        break;
                    case "Hora":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasPorHora("NO",TBBusqueda.Texts);
                        break;
                    case "Usuario":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasPorUsuario("NO", TBBusqueda.Texts);
                        break;
                    case "Dia":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasPorDia("NO",TBBusqueda.Texts);
                        break;
                    case "Periodo":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasPeriodo("NO", TBBusqueda.Texts);
                        break;
                    case "Horas":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasHoras("NO", TBBusqueda.Texts);
                        break;
                    case "Materia":
                        dataGridView1.DataSource = LogicaReserva.BusquedaReservasMateria("NO",TBBusqueda.Texts);
                        break;
                    default:

                        break;
                }
            }


        }

        private void CBFiltro_OnSelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
    }
}
