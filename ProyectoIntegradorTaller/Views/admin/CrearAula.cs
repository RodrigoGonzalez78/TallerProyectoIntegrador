using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ProyectoIntegradorTaller.views.admin
{
    public partial class CrearAula : DraggablePanelUserControl 
    {
        private int id_;
        private string ttipo;
        private int tcantPCs;
        private string tlugar;
        public CrearAula(int Id, string Name, int CapacidadMax, String Lugar , String Tipo,string wifi,string proyecto,string AC,string tv,int cantPCs)
        {
            InitializeComponent();
            id_ = Id;
            ttipo= Tipo;
            TNombre.Texts = Name;
            tlugar= Lugar;
            TCapacidad.Texts = CapacidadMax.ToString();
            TBCantidadPcs.Texts = cantPCs.ToString();
            tcantPCs = cantPCs;
   
            if (wifi == "SI")
            {
                CWifi.Checked=true;
            }
            if (AC == "SI")
            {
                CAireAcondicionado.Checked = true;
            }
            if (proyecto == "SI")
            {
                CProyector.Checked = true;
            }
            if (tv == "SI")
            {
                CTelevisor.Checked = true;
            }
            BEditarAula.Visible = true;
            BCrearAula.Visible = false;
            TBCantidadPcs.Visible = false;
            LPcs.Visible = false;

            TNombre.Enabled= false;// no se debe poder editar el nombre segun el profesor
            
        }
        public CrearAula()
        {
            InitializeComponent();
            TBCantidadPcs.Visible = false;
            LPcs.Visible = false;
            BEditarAula.Visible = false;
            BCrearAula.Visible = true;
            
        }
  




        private void BCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número (0-9), retroceso o una tecla de control.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprime la pulsación de tecla.
                e.Handled = true;
                MessageBox.Show("EL campo cantidad solo acepta valores numericos");
            }
        }

        private void BCrearAula_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.TNombre.Texts) || string.IsNullOrEmpty(CBUbicacion.Texts) || string.IsNullOrEmpty(TTipo.Texts) || string.IsNullOrEmpty(TCapacidad.Texts) || string.IsNullOrEmpty(TBCantidadPcs.Texts))
            {
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (LogicaClase.ValidarNombreAula(TNombre.Texts))
                {
                    LogicaClase.AgregarAula(this.TTipo.Texts, this.CBUbicacion.Texts, this.TNombre.Texts,this.TBCantidadPcs.Texts, this.TCapacidad.Texts, this.CAireAcondicionado.Checked, this.CWifi.Checked, this.CProyector.Checked, this.CTelevisor.Checked);
                    this.TCapacidad.Texts = this.TNombre.Texts = " ";
                    MessageBox.Show("se inserto el aula correctamente!", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    menuAdmin admin = new menuAdmin();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("el " + this.TNombre.Texts + " ya existe", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void TCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El campo Capacidad solo acepta valores numericos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
        }

       



        private void BVolver_Click(object sender, EventArgs e)
        {

            menuAdmin homeAdmin = new menuAdmin();
            homeAdmin.Show();
            this.Hide();
        }

        private void CBUbicacion_Load(object sender, EventArgs e)
        {
            ubicacion tuser = new ubicacion();
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                CBUbicacion.DataSource = db.ubicacion.Where(u=>u.activo=="SI").ToList();
                CBUbicacion.DisplayMember = "lugar"; // Specify the property to display in the ComboBox
                CBUbicacion.ValueMember = "id_ubicacion";
                CBUbicacion.SelectedItem = db.ubicacion.FirstOrDefault(ubi => ubi.lugar==tlugar);
            }
        }

        private void TTipo_Load(object sender, EventArgs e)
        {
           
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                TTipo.DataSource = db.tipoSala.ToList();
                TTipo.DisplayMember = "tipo"; // Specify the property to display in the ComboBox
                TTipo.ValueMember = "id_sala";
                TTipo.SelectedItem = db.tipoSala.FirstOrDefault(r=> r.tipo==ttipo);
          
                TBCantidadPcs.Texts = db.aula.FirstOrDefault(cant => cant.cantComputadoras == tcantPCs).cantComputadoras.ToString();
               
            }
            
        }

        private void BEditarAula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TNombre.Texts) || string.IsNullOrEmpty(CBUbicacion.Texts) || string.IsNullOrEmpty(TTipo.Texts) || string.IsNullOrEmpty(TCapacidad.Texts) || string.IsNullOrEmpty(TBCantidadPcs.Texts))
            {
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
        
                    LogicaClase.ActualisarAula(id_, this.TTipo.Texts, this.CBUbicacion.Texts, this.TNombre.Texts, this.TCapacidad.Texts,this.TBCantidadPcs.Texts, this.CAireAcondicionado.Checked, this.CWifi.Checked, this.CProyector.Checked, this.CTelevisor.Checked);
                    this.TCapacidad.Texts = this.TNombre.Texts = " ";
                    MessageBox.Show("se edito la clase correctamente correctamente!", "editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            }
            this.Hide();
            menuAdmin admin = new menuAdmin();
            admin.Show();
        }

      
        private void TTipo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (TTipo.Texts == "laboratorio")
            {
                TBCantidadPcs.Visible = true;
                LPcs.Visible = true;
            }
            else
            {
                TBCantidadPcs.Texts = 0.ToString();
                TBCantidadPcs.Visible = false;
                LPcs.Visible = false;
            }
        }

        private void cantPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número (0-9), retroceso o una tecla de control.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprime la pulsación de tecla.
                e.Handled = true;
                MessageBox.Show("EL campo Cantidad PCs solo acepta valores numericos");
            }
        }
    }
}