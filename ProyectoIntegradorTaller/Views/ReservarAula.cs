using DraggingControl;
using ProyectoIntegradorTaller.models;
using System;
using System.Windows.Forms;
using ProyectoIntegradorTaller.logica;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoIntegradorTaller.views.admin
{

    public partial class ReservarAula : DraggablePanelUserControl
    {
 
        private int id_aula;
        private reserva res;
        

        public ReservarAula(int idAula,int idHora, int idDia,string nombre)
        {
            InitializeComponent();
            CBHora.Texts = LogicaReserva.ObtenerHorarioPorID(idHora).horario;
            CBDia.Texts = LogicaReserva.ObtenerDiaPorID(idDia).dias;
            Periodo.Texts = nombre;
            id_aula = idAula;
            
            CBMateria.DataSource = LogicaReserva.CBMateriasListar();
            CBMateria.DisplayMember = "materia";
            CBMateria.ValueMember = "id_materia";
            CBMateria.SelectedIndex = 1;
          
           
            BEliminar.Visible = false;
            this.BReservarAula.Click += new System.EventHandler(this.botonPersonalisado1_Click);
            this.BImprimir.Visible= false;

            if (Session.SessionCacheData.IdProfile == 1 || Session.SessionCacheData.IdProfile == 3)
            {
                CBPRofesor.DataSource = LogicaReserva.CBPRofesorListar();
                CBPRofesor.DisplayMember = "fullname";
                CBPRofesor.ValueMember = "id_usuario";
                CBPRofesor.SelectedIndex = 1;
            }
            else
            {
                CBPRofesor.Texts = Session.SessionCacheData.Name + " " + Session.SessionCacheData.LastName;

                BReservarAula.Visible = true;
                BReservarAula.Text = "Solicitar Reserva";
                BEliminar.Visible = false;
                BImprimir.Visible = false;
            }
        }



        //Editar aula
        public ReservarAula(reserva reserva1)
        {
            InitializeComponent();
            CBHora.Texts = LogicaReserva.ObtenerHorarioPorID(reserva1.id_hora).horario;
            CBDia.Texts = LogicaReserva.ObtenerDiaPorID(reserva1.id_dia).dias;
            
            Periodo.Texts = LogicaReserva.ObtenerPeriodoPorId(reserva1.id_periodo).periodo_nombre;
            id_aula = reserva1.id_aula;
            res = reserva1;

            LogicaMaterias.ListarMateriasCBDS(CBMateria,res);
           
       
            BReservarAula.Text = "Editar Reserva";
            BReservarAula.Click += new System.EventHandler(this.editar_Click);
            if (Session.SessionCacheData.IdProfile == 1 || Session.SessionCacheData.IdProfile == 3)
            {

               LogicaReserva.ListarProfesoresComboBoxDS(CBPRofesor,res);
            
            }
            else
            {
                CBPRofesor.Texts = Session.SessionCacheData.Name + " " + Session.SessionCacheData.LastName;

       
                BEliminar.Visible = false;
                BReservarAula.Visible = false;
                BImprimir.Visible = false;
            }
        }

        
        private void BVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            VerReservas reservas = new VerReservas(id_aula);
            reservas.Show();
           
        }

        

        private void botonPersonalisado1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.CBHora.Texts) || string.IsNullOrEmpty(this.CBMateria.Texts) ||       string.IsNullOrEmpty(CBPRofesor.Texts) || string.IsNullOrEmpty(this.CBDia.Texts))
            {
               
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string estado;
                if(Session.SessionCacheData.IdProfile == 1 || Session.SessionCacheData.IdProfile ==3)
                {
                    estado = "SI";
                }
                else
                {
                    estado = "NO";
                }
                LogicaReserva.InsertarReserva(id_aula,this.CBHora.Texts,this.CBMateria.Texts,this.CBPRofesor.Texts,this.CBDia.Texts,this.Periodo.Texts,estado);
                MessageBox.Show("Insercion echa exitosamente!", "insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                VerReservas reservas = new VerReservas(id_aula);
                reservas.Show();
            }
            
        }

       

        
        // Editar Aula
        private void editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.CBHora.Texts) || string.IsNullOrEmpty(this.CBMateria.Texts) || string.IsNullOrEmpty(CBPRofesor.Texts) || string.IsNullOrEmpty(this.CBDia.Texts))
            {

                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                LogicaReserva.EditarReserva(res.id_reserva, res.id_hora, CBMateria.Texts, CBPRofesor.Texts, res.id_dia, this.Periodo.Texts, "SI");
                MessageBox.Show("Se edito con exito la reserva!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                VerReservas reservas = new VerReservas(id_aula);
                reservas.Show();
            }

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            LogicaReserva.EliminarReserva(res.id_reserva);
            this.Hide();
            VerReservas reservas = new VerReservas(id_aula);
            reservas.Show();
        }

        

        private void BImprimir_Click(object sender, EventArgs e)
        {
            LogicaReserva.ImprimirComprobante(res.id_reserva);
        }

        
    }
}
