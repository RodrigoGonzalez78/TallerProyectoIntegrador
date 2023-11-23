using ProyectoIntegradorTaller.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace ProyectoIntegradorTaller.logica
{
    internal class LogicaPeriodo
    {
        public static IList ListarPeriodos()
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from Periodo in db.Periodo
                            select new
                            {
                                Id = Periodo.id_periodo,
                                periodo = Periodo.periodo_nombre,
                                desde = Periodo.fecha_desde,
                                hasta = Periodo.fecha_hasta
                            };
                return query.ToList();

            }
        }

        public static void InsertarPeriodo(int id_periodo, DateTime desde, DateTime hasta)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                var periodo = db.Periodo.FirstOrDefault(r => r.id_periodo == id_periodo);
                if (periodo != null)
                {
                    periodo.fecha_desde = desde;
                    periodo.fecha_hasta = hasta;

                    if (periodo.id_periodo == 1 || periodo.id_periodo == 3 || periodo.id_periodo == 6 || periodo.id_periodo == 10)
                    {
                        var pperiodo = db.Periodo.FirstOrDefault(r => r.id_periodo == 1);
                        var periodo2 = db.Periodo.FirstOrDefault(r => r.id_periodo == 3);
                        var periodo3 = db.Periodo.FirstOrDefault(r => r.id_periodo == 6);
                        var periodo4 = db.Periodo.FirstOrDefault(r => r.id_periodo == 10);
                        periodo2.fecha_desde = periodo3.fecha_desde = periodo4.fecha_desde = pperiodo.fecha_desde = desde;

                    }
                    if (periodo.id_periodo == 1 || periodo.id_periodo == 7)
                    {

                        var periodo2 = db.Periodo.FirstOrDefault(r => r.id_periodo == 7);
                        var periodo3 = db.Periodo.FirstOrDefault(r => r.id_periodo == 1);

                        periodo2.fecha_hasta = periodo3.fecha_hasta = hasta;
                    }
                    if (periodo.id_periodo == 2 || periodo.id_periodo == 8)
                    {
                        var periodo2 = db.Periodo.FirstOrDefault(r => r.id_periodo == 2);
                        var periodo3 = db.Periodo.FirstOrDefault(r => r.id_periodo == 8);

                        periodo2.fecha_desde = periodo3.fecha_desde = desde;
                    }
                    if (periodo.id_periodo == 2 || periodo.id_periodo == 5 || periodo.id_periodo == 9 || periodo.id_periodo == 10)
                    {
                        var pperiodo = db.Periodo.FirstOrDefault(r => r.id_periodo == 2);
                        var periodo2 = db.Periodo.FirstOrDefault(r => r.id_periodo == 5);
                        var periodo3 = db.Periodo.FirstOrDefault(r => r.id_periodo == 9);
                        var periodo4 = db.Periodo.FirstOrDefault(r => r.id_periodo == 10);
                        periodo2.fecha_desde = periodo3.fecha_desde = periodo4.fecha_desde = pperiodo.fecha_desde = hasta;

                    }
                    db.SaveChanges();
                }



            }
        }
        public static string ObtenerPeriodoPorID(int id_periodo)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                return db.Periodo.FirstOrDefault(r => r.id_periodo == id_periodo).periodo_nombre;
            }
        }


        public static IList BuscarPeriodo(string valor)
        {


            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from Periodo in db.Periodo
                            where Periodo.periodo_nombre.Contains(valor)
                            select new
                            {
                                Id = Periodo.id_periodo,
                                Periodo = Periodo.periodo_nombre,
                                Desde = Periodo.fecha_desde,
                                Hasta = Periodo.fecha_hasta
                            };

                return query.ToList();



            }
        }
    }
}