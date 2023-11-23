using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class LogicaAdministrarDB
    {

        public static void RealizarRestauracion(string backupPath)
        {
            string databaseName;
            string connectionString;

            using (var context = new classroom_managerEntities())
            {
                connectionString = context.Database.Connection.ConnectionString;
                databaseName = context.Database.Connection.Database;
            }

            try
            {
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlsingleuser = $"ALTER DATABASE {databaseName} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    using(SqlCommand singleusercommand= new SqlCommand(sqlsingleuser,connection))
                    {
                        singleusercommand.ExecuteNonQuery();
                    }
                    string sqlUseMaster = "USE master;";
                    using (SqlCommand useMasterCommand = new SqlCommand(sqlUseMaster, connection))
                    {
                        useMasterCommand.ExecuteNonQuery();
                    }
                    string sqlRestore = $"RESTORE DATABASE {databaseName} FROM DISK = '{backupPath}';";

                    using (SqlCommand restoreCommand = new SqlCommand(sqlRestore, connection))
                    {
                        restoreCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Restauración completada con éxito.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al restaurar la base de datos: " + ex.Message);
            }
        }

        public static void RealizarBackup(string backupPath)
        {
            string backupQuery;
            string connectionString;

            using (var context = new classroom_managerEntities())
            {
                connectionString = context.Database.Connection.ConnectionString;
                string databaseName = context.Database.Connection.Database;
               
                backupQuery = $"BACKUP DATABASE {databaseName} TO DISK = '{backupPath}'";

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(backupQuery, connection))
                {
                    try
                    {
                        // Abre la conexión antes de ejecutar el comando
                        connection.Open();

                        command.ExecuteNonQuery();

                        MessageBox.Show("Backup realisado con exito!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
