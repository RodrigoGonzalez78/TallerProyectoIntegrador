using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.admin;
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

namespace ProyectoIntegradorTaller.views
{
    public partial class VerReservas : FormPersonalisado
    {

        private int id_aula;
      
       
        public VerReservas(int id)
        {

            id_aula = id;
            
            InitializeComponent();
        }

       
        private void Reservas_load(object sender, EventArgs e)
        {

            Periodo.DataSource = LogicaReserva.listarPeriodo();
           
            Periodo.DisplayMember = "periodo_nombre";
            Periodo.ValueMember = "id_periodo";
     
            LogicaReserva.MostrarGrillaDeReservas(id_aula, DGHorarios,this.Periodo.Texts);
                       
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1) // Asegúrate de que se hizo clic dentro de una celda válida
            {
                int idDia = e.ColumnIndex; // Obtén el indice de la columna
                int idHora = e.RowIndex; // obten el indice de la fila, sumamos uno para corregir el indice
                
                SeleccionarReserva(idDia, idHora);
            }
        }

        private void SeleccionarReserva(int idDia, int idHora)
        {


            this.Hide();
            var periodo = LogicaReserva.ObtenerPeriodoPorNombre(this.Periodo.Texts);
            reserva reserva1 = LogicaReserva.BuscarReservaParaGrilla(idDia, idHora, id_aula,periodo.id_periodo,"SI");
            reserva reserva2 = LogicaReserva.BuscarReservaParaGrilla(idDia, idHora, id_aula, periodo.id_periodo, "NO");
            if (reserva1 == null)
            {
                if(reserva2 != null && Session.SessionCacheData.IdProfile==4) {
                    DialogResult dialogResult =MessageBox.Show("Este turno de reserva fue solicitado por otro profesor, ¿Esta seguro que desea reservarlo? ","Conflicto Solicitud",MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ReservarAula reserva = new ReservarAula(id_aula, idHora, idDia, periodo.periodo_nombre);
                        reserva.Show();
                    }
                    else
                    {
                        this.Show();
                    }
                }
                else
                {
                    ReservarAula reserva = new ReservarAula(id_aula, idHora, idDia, periodo.periodo_nombre);
                    reserva.Show();
                }


            }
            else
            {
                
                ReservarAula reserva = new ReservarAula(reserva1);
                reserva.Show();
            }
           
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
                default:
                    HomeProfesor homeProfesor = new HomeProfesor();
                    homeProfesor.Show();

                    break;

            }
            this.Hide();

        }

        private void Periodo_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            LogicaReserva.MostrarGrillaDeReservas(id_aula, DGHorarios, this.Periodo.Texts);

        }
    }
}
