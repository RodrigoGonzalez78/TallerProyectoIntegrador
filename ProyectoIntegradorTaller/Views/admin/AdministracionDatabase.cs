using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class AdministracionDatabase : FormPersonalisado
    {
        public AdministracionDatabase()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuAdmin unAdminMenu = new menuAdmin();
            unAdminMenu.Show();
        }

        private void BBuscarRuta_Click(object sender, EventArgs e)
        {


  
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();


            DialogResult result = folderBrowserDialog.ShowDialog();

            // Verificar si el usuario hizo clic en el botón Aceptar
            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;

                // Mostrar la ruta en el TextBox
                TBRutaExport.Texts = folderPath;
            }

        }

        private void BExportarDB_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(TBRutaExport.Texts))
            {
                MessageBox.Show("Por favor, cargue la ruta de la carpeta.");
                
            }
            else {
                string fechaActual = DateTime.Now.ToString("dd-MM-yyyy_HHmmss");

                string backupPath = Path.Combine(TBRutaExport.Texts, fechaActual + ".bak");

                LogicaAdministrarDB.RealizarBackup(backupPath);
               
            }

            
        }

        private void BBuscarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos .bak|*.bak";

            // Muestra el cuadro de diálogo para seleccionar un archivo .bak
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string rutaArchivo = openFileDialog.FileName;


                    // Muestra el contenido en el TextBox
                    TBRutaArchivo.Texts = rutaArchivo;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar el archivo .bak: " + ex.Message);
                }
            }
        }

        private void BRestaurarDB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBRutaArchivo.Texts))
            {
                MessageBox.Show("Por favor, cargue la ruta del archivo.");
            }
            else
            {
                LogicaAdministrarDB.RealizarRestauracion(TBRutaArchivo.Texts);
            }
        }
    }
    
}
