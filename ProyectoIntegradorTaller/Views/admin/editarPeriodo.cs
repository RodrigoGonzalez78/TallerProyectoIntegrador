using DraggingControl;
using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegradorTaller.logica;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class editarPeriodo : DraggablePanelUserControl
    {

        private int id_periodo;
        
        

        public editarPeriodo(int idPeriodo,DateTime desde,DateTime hasta)
        {
            InitializeComponent();
        
            id_periodo = idPeriodo;
            fecha_desde.Value = desde;
            fecha_hasta.Value = hasta;
            
            CBPeriodo.Texts =LogicaPeriodo.ObtenerPeriodoPorID(idPeriodo);
        }

        private void BVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Periodos unPeriodo = new Periodos();
            unPeriodo.Show();
           
        }

        

        private void botonPersonalisado1_Click(object sender, EventArgs e)
        {            
            LogicaPeriodo.InsertarPeriodo(id_periodo,this.fecha_desde.Value,this.fecha_hasta.Value);
         
            MessageBox.Show("Insercion echa exitosamente!", "insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            Periodos unPeriodo = new Periodos();
            unPeriodo.Show();

        }

        
    }


}
