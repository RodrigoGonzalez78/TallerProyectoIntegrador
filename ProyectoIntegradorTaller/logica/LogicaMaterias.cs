using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class LogicaMaterias
    {
        public static materias ObtenerMateriaPorID(int id_materia)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var materiaElejida = db.materias.FirstOrDefault(m => m.id_materia == id_materia);
                return materiaElejida;
            }
        }
       
       
        public static IList ListarMateriasActivas()
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from materias in db.materias
                            where materias.activo == "SI"
                            select new
                            {
                                Id = materias.id_materia,
                                Materia = materias.materia,
                                Activo = materias.activo

                            };
                return  query.ToList();

            }
        }

        public static void AgregarMateria(string tmateria)
        {
            materias sub = new materias
            {
                materia = tmateria,
                activo = "SI"
            };
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                db.materias.Add(sub);
                db.SaveChanges();

            }
        }

        public static void MateriasCambiarEstado(string estado, int idMateria)
        {
            
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                 

                materias aulaDesactivar = db.materias.FirstOrDefault(u => u.id_materia == idMateria);

                if (aulaDesactivar != null)
                {
                    aulaDesactivar.activo = estado;
                    db.SaveChanges();

                }
            }
        }
        public static IList BuscarMateria(string valor)
        {
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var query = dbContext.materias
                    .Where(materia => materia.materia.Contains(valor) && materia.activo == "SI")
                    .Select(materia => new
                    {
                        Id = materia.id_materia,
                        Materia = materia.materia,
                        Activo = materia.activo
                    })
                    .ToList();

                return query;
            }
        }

        public static void ListarMateriasCBDS(ComboBoxPersonalisado CBMateria,reserva res)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                CBMateria.DisplayMember = "materia";
                CBMateria.ValueMember = "id_materia";
                CBMateria.DataSource= db.materias.ToList();
                CBMateria.SelectedItem = db.materias.FirstOrDefault(r => r.id_materia == res.id_materia);
            }
        }
        public static materias ListarMateriasCBSI( reserva res)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                return  db.materias.FirstOrDefault(r => r.id_materia == res.id_materia);
            }
        }
    }
}
