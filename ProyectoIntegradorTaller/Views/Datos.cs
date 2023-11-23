using DraggingControl;
using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.logica;
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

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class Datos :DraggablePanelUserControl
    {
        
        public Datos()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            switch (Session.SessionCacheData.IdProfile)
            {

                case 1:
                    menuAdmin homeAdmin = new menuAdmin();
                    homeAdmin.Show();
                    this.Hide();
                    break;
                case 3:
                    BedelMenu menuBedel = new BedelMenu();
                    menuBedel.Show();
                    this.Hide();
                    break;
                default:
                    HomeProfesor homeProfesor = new HomeProfesor();
                    homeProfesor.Show();
                    this.Hide();
                    break;

            }

        }
      

        private void BLogOut_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere deslogearse?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ask == MsgBoxResult.Yes)
            {
                this.Close();
                LogIn log = new LogIn();
                Session.SessionCacheData = null;
                log.Show();
            }
        }

        private void BCambiarPassword_Click(object sender, EventArgs e)
        {
            string nuevaContrasena = TBContrasena.Texts;
            string confirmarContrasena = TBRepetirContrasena.Texts;

            // Verificar que las contraseñas coincidan
            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                return;
            }

            // Verificar que la contraseña cumpla con ciertos criterios de seguridad (ejemplo: longitud mínima)
            int longitudMinima = 8; // Cambia este valor según tus criterios
            if (nuevaContrasena.Length < longitudMinima)
            {
                MessageBox.Show($"La contraseña debe tener al menos {longitudMinima} caracteres.");
                return;
            }

            LogicaUsuarios.CambiarPassword(nuevaContrasena,Session.SessionCacheData.Id);
            MessageBox.Show("Se cambio correctamente la contraseña del usuario!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
