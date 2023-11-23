using DraggingControl;
using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.logica;
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

namespace ProyectoIntegradorTaller.views.admin

{
    public partial class ReservasPendientes : FormPersonalisado
    {
        public ReservasPendientes()
        {
            InitializeComponent();
            reservaLogica.listarReservas(dataGridView1,"NO");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "autorizar")
            {
                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere autorizar la reserva en el  " + (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value + "  ?", "Reservar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ask == MsgBoxResult.Yes)
                {
                    reservaLogica.reservaActiva("SI", dataGridView1, e);
                }

            }
        }
    }
}
