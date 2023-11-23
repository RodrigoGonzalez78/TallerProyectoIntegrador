using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class LogicaLugares
    {

        public static void ListarLugaresAcivos(DataGridView datagrid)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from ubicacion in db.ubicacion
                            where ubicacion.activo == "SI"
                            select new
                            {
                                Id = ubicacion.id_ubicacion,
                                Lugar = ubicacion.lugar,

                            };
                datagrid.DataSource = query.ToList();

            }
        }

        public static void AgregarLugar(string tlugar)
        {
            ubicacion sub = new ubicacion
            {
                lugar = tlugar,
                activo = "SI"

            };
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                db.ubicacion.Add(sub);
                db.SaveChanges();

            }
        }

        public static void BuscarLugaresActivos(string valor, DataGridView dataGrid)
        {

            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var query = dbContext.ubicacion
                     .Where(lugar => lugar.lugar.Contains(valor) && lugar.activo == "SI")
                    .Select(lugar => new
                    {
                        Id = lugar.id_ubicacion,
                        Lugar = lugar.lugar
                    })
                    .ToList();

                dataGrid.DataSource = query;
            }
        }

        public static void DesactivarLugares(string estado, DataGridView dataGrid, DataGridViewCellEventArgs e)
        {

            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                int idLugar = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["Id"].Value); 

                ubicacion aulaDesactivar = db.ubicacion.FirstOrDefault(u => u.id_ubicacion == idLugar);
                if (aulaDesactivar != null)
                {
                    aulaDesactivar.activo = estado;
                    db.SaveChanges();

                }
            }
        }
    }
}
