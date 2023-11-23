using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
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
    public partial class CrearUsuario : DraggablePanelUserControl
    {
        public int id_;
        public bool isEdit;
        public CrearUsuario()
        {
            InitializeComponent();
            isEdit = false;
        }
        public CrearUsuario(string nombre, string apellido, string mail, int dni, int tipo, int id)
        {
            InitializeComponent();
            this.TNombre.Texts = nombre;
            this.TApellido.Texts = apellido;
            this.TEmail.Texts = mail;
            this.TDni.Texts = dni.ToString();
            this.CBTipo.ValueMember = tipo.ToString();
            isEdit = true;
            id_ = id;

            BInicioSesion.Text = "  Editar Usuario";
            this.BInicioSesion.Image = global::ProyectoIntegradorTaller.Properties.Resources.edit;
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void BInicioSesion_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(this.TNombre.Texts) || string.IsNullOrEmpty(this.TApellido.Texts) || string.IsNullOrEmpty(this.TDni.Texts) || string.IsNullOrEmpty(this.TEmail.Texts) || string.IsNullOrEmpty(this.CBTipo.Texts))
            {
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!IsValidEmail(this.TEmail.Texts))
                {

                    MessageBox.Show("El correo electronico no es valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    int tipoU = 3;
                    if (this.CBTipo.Texts == "Admin")
                    {
                        tipoU = 1;
                    }
                    else if (this.CBTipo.Texts == "bedel")
                    {
                        tipoU = 3;
                    }
                    else if (this.CBTipo.Texts == "profesor")
                    {
                        tipoU = 4;
                    }


                    if (!isEdit)
                    {
                        LogicaUsuarios.AgregarUsuario(int.Parse(TDni.Texts), this.TApellido.Texts, this.TEmail.Texts, this.TNombre.Texts, tipoU);
                        MessageBox.Show("se inserto el usuario correctamente!", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        LogicaUsuarios.ActualisarUsuario(id_, int.Parse(TDni.Texts), this.TApellido.Texts, this.TEmail.Texts, this.TNombre.Texts, tipoU);
                        MessageBox.Show("se edito al usuario correctamente!", "editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.TDni.Texts = this.TApellido.Texts = this.TEmail.Texts = this.TNombre.Texts = " ";
                    this.Close();
                    Usuarios usuarios = new Usuarios();
                    usuarios.Show();
                }
            }


        }

        public static bool IsValidEmail(string email)
        {
            // Define una expresión regular para validar direcciones de correo electrónico.
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Utiliza Regex.IsMatch para verificar si la cadena coincide con el patrón.
            return Regex.IsMatch(email, pattern);
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El campo Capacidad solo acepta valores numericos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void CBTipo_Load(object sender, EventArgs e)
        {
            LogicaUsuarios.CBTipoListar(CBTipo);
        }

    }

}

