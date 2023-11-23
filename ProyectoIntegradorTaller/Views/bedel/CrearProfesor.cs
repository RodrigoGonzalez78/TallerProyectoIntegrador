using DraggingControl;
using ProyectoIntegradorTaller.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class CrearProfesor : DraggablePanelUserControl
    {
        private bool isEdit;
        private int _idprofesor;
        public CrearProfesor()
        {
            InitializeComponent();
            isEdit = false;
        }
        //editar profesor
        public CrearProfesor(int idprofesor,string nombre,string apellido,int dni,string mail)
        {
            InitializeComponent();
            this.TBNombre.Texts = nombre;
            this.TBApellido.Texts= apellido;
            this.TBDNI.Texts = dni.ToString();
            this.TBCorreo.Texts = mail;
            _idprofesor= idprofesor;
            this.BInicioSesion.Text = " editar profesor";
            isEdit= true;
        }
        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profesores profesores= new Profesores();
            profesores.Show();
            
        }

        private void BInicioSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBApellido.Texts) && string.IsNullOrEmpty(TBCorreo.Texts) && string.IsNullOrEmpty(TBDNI.Texts) && string.IsNullOrEmpty(TBNombre.Texts))
            {
                MessageBox.Show("Debe completar todos los campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            else {
                if (IsValidEmail(TBCorreo.Texts))
                {
                    string accion;
                    if (isEdit)
                    {
                        LogicaUsuarios.ActualisarUsuario(_idprofesor,int.Parse(TBDNI.Texts), TBApellido.Texts, TBCorreo.Texts, TBNombre.Texts,4 );
                        MessageBox.Show("editar");
                        accion = "edito";
                    }
                    else
                    {
                        LogicaUsuarios.AgregarUsuario(int.Parse(TBDNI.Texts), TBApellido.Texts, TBCorreo.Texts, TBNombre.Texts, 4);
                        accion = "agrego";
                    }

                    MessageBox.Show("Se "+accion+" un profesor con exito!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Profesores unprofe = new Profesores();
                    unprofe.Show();
                }
                else
                {

                    MessageBox.Show("El correo electronico ingresado no cumple el formato!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void BVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Profesores profesores = new Profesores();
            profesores.Show();

        }
        private void textBoxTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y teclas de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;  // Bloquear la entrada del usuario si no es letra o tecla de control
            }
        }

       
        public static bool IsValidEmail(string email)
        {
            // Define una expresión regular para validar direcciones de correo electrónico.
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Utiliza Regex.IsMatch para verificar si la cadena coincide con el patrón.
            return Regex.IsMatch(email, pattern);
        }

       

        private void TBDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprime la pulsación de tecla.
                e.Handled = true;
                MessageBox.Show("EL campo DNI solo acepta valores numericos");
            }
        }
    }
}
