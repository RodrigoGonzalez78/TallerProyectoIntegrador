using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.admin;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ProyectoIntegradorTaller.logica
{
    internal class ReporteLogica
    {
        private static void AgregarChart(Chart chart,IQueryable<HorarioList> query,int tipo)
        {
            chart.Series.Clear();
            

            if (tipo == 1)
            {
                try
                {
                    foreach (var reserva in query)
                    {
                        var series = new Series(reserva.campo);
                        series.ChartType = SeriesChartType.Column;
                        series.Points.AddXY(0, reserva.cantcampo);
                        chart.Series.Add(series);
                    }
                }catch(Exception ex) { }

            }
            else
            {
                int total = 10;
                try
                {


                    if (query != null && query.Any())
                    {
            
                        var suma = query.Sum(reserva => reserva.cantcampo);
                        if (suma != 0)
                        {
                            total = suma;
                 
                        }


                    }
                    var series = new Series("reserva");
                    series.ChartType = SeriesChartType.Doughnut;
                    foreach (var reserva in query)
                    {
                      
                        var porcentaje = (reserva.cantcampo * 100) / total;

                        series.Points.Add(new DataPoint { AxisLabel = $"{reserva.campo} ({porcentaje:F2})", YValues = new double[] { porcentaje } });

                    }
                    chart.Series.Add(series);
                }
                catch(Exception ex) { }

            }

        }
        public static Periodo obtenerPeriodo(string nombrePeriodo)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                return db.Periodo.FirstOrDefault(p=> p.periodo_nombre==nombrePeriodo);
            }
        }
        public static void ListarDias(Chart chart,int id_aula,string periodo)
        {

            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var periodoElejido = db.Periodo.FirstOrDefault(p=>p.periodo_nombre==periodo );
                var query = from reserva in db.reserva
                             join aula in db.aula on reserva.id_aula equals aula.id_aula
                             join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                             join Periodo in db.Periodo on  reserva.id_periodo equals Periodo.id_periodo
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario 
                            where aula.activa == "SI" && aula.id_aula == id_aula && reserva.activo=="SI" && usuario.id_tipoUsuario==4
                             && ((((Periodo.fecha_hasta <= periodoElejido.fecha_hasta && Periodo.fecha_desde >= periodoElejido.fecha_desde) || Periodo.id_periodo == 4) && periodoElejido.id_periodo == 1) ||
                                   (((Periodo.fecha_hasta >= periodoElejido.fecha_hasta && Periodo.fecha_desde <= periodoElejido.fecha_desde) || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 7))
                                   || ((Periodo.fecha_desde == periodoElejido.fecha_desde || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 6 || periodoElejido.id_periodo == 8))
                                   || ((Periodo.fecha_desde >= periodoElejido.fecha_desde || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 2))
                                   || (Periodo.fecha_hasta == periodoElejido.fecha_hasta && (periodoElejido.id_periodo == 9))
                                   || (((Periodo.fecha_desde <= periodoElejido.fecha_desde && Periodo.fecha_hasta >= periodoElejido.fecha_desde) || Periodo.fecha_hasta == periodoElejido.fecha_hasta) && (periodoElejido.id_periodo == 5))
                                   || ((Periodo.id_periodo == 1 || Periodo.id_periodo == 7 || Periodo.id_periodo == 3
                                      || Periodo.id_periodo == 2 || Periodo.id_periodo == 5 || Periodo.id_periodo == 8
                                      || Periodo.id_periodo == 10 || Periodo.id_periodo == 4) && periodoElejido.id_periodo == 4)
                                   || (Periodo.fecha_desde <= periodoElejido.fecha_hasta && periodoElejido.id_periodo == 3)
                                   || ((Periodo.fecha_desde >= periodoElejido.fecha_desde || periodoElejido.id_periodo == 4) && periodoElejido.id_periodo == 10))
                            group new {  reserva, aula, dias_semana }
                             by new { reserva.id_dia, aula.nombre, dias_semana.dias } into g
                             select new HorarioList
                             {
                                 cantcampo = g.Count(),
                                 campo = g.Key.dias.ToString(),
                                 aula = g.Key.nombre.ToString(),
                             };
                AgregarChart(chart,query,1);

            }
        }
        public static void ListarProfesores(Chart chart, int id_aula, string periodo)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var periodoElejido = db.Periodo.FirstOrDefault(p => p.periodo_nombre == periodo);
                var query = from reserva in db.reserva
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where  aula.activa=="SI"  && aula.id_aula == id_aula && usuario.id_tipoUsuario==4 &&  reserva.activo=="SI" && (((((Periodo.fecha_hasta <= periodoElejido.fecha_hasta && Periodo.fecha_desde >= periodoElejido.fecha_desde) || Periodo.id_periodo == 4) && periodoElejido.id_periodo == 1) ||
                                   (((Periodo.fecha_hasta >= periodoElejido.fecha_hasta && Periodo.fecha_desde <= periodoElejido.fecha_desde) || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 7))
                                   || ((Periodo.fecha_desde == periodoElejido.fecha_desde || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 6 || periodoElejido.id_periodo == 8))
                                   || ((Periodo.fecha_desde >= periodoElejido.fecha_desde || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 2))
                                   || (Periodo.fecha_hasta == periodoElejido.fecha_hasta && (periodoElejido.id_periodo == 9))
                                   || (((Periodo.fecha_desde <= periodoElejido.fecha_desde && Periodo.fecha_hasta >= periodoElejido.fecha_desde) || Periodo.fecha_hasta == periodoElejido.fecha_hasta) && (periodoElejido.id_periodo == 5))
                                   || ((Periodo.id_periodo == 1 || Periodo.id_periodo == 7 || Periodo.id_periodo == 3
                                      || Periodo.id_periodo == 2 || Periodo.id_periodo == 5 || Periodo.id_periodo == 8
                                      || Periodo.id_periodo == 10 || Periodo.id_periodo == 4) && periodoElejido.id_periodo == 4)
                                   || (Periodo.fecha_desde <= periodoElejido.fecha_hasta && periodoElejido.id_periodo == 3)
                                   || ((Periodo.fecha_desde >= periodoElejido.fecha_desde || periodoElejido.id_periodo == 4) && periodoElejido.id_periodo == 10)))
                            group new {reserva, usuario,aula }
                            by new { reserva.id_usuario, usuario.apellido,aula.nombre} into g
                            select new HorarioList
                            {
                                cantcampo = g.Count(),
                                campo = g.Key.apellido.ToString(),
                                aula = g.Key.nombre.ToString(),
                            };

                AgregarChart(chart, query, 2);

            }
        }
        public static void ListarMaterias(Chart chart, int id_aula,string periodo)
        {

            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var periodoElejido = db.Periodo.FirstOrDefault(p => p.periodo_nombre == periodo);
                var query = from reserva in db.reserva
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where aula.activa == "SI" &&  aula.id_aula == id_aula && reserva.activo=="SI" && ((((Periodo.fecha_hasta <= periodoElejido.fecha_hasta && Periodo.fecha_desde >= periodoElejido.fecha_desde) || Periodo.id_periodo == 4) && periodoElejido.id_periodo == 1) ||
                                   (((Periodo.fecha_hasta >= periodoElejido.fecha_hasta && Periodo.fecha_desde <= periodoElejido.fecha_desde) || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 7))
                                   || ((Periodo.fecha_desde == periodoElejido.fecha_desde || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 6 || periodoElejido.id_periodo == 8))
                                   || ((Periodo.fecha_desde >= periodoElejido.fecha_desde || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 2))
                                   || (Periodo.fecha_hasta == periodoElejido.fecha_hasta && (periodoElejido.id_periodo == 9))
                                   || (((Periodo.fecha_desde <= periodoElejido.fecha_desde && Periodo.fecha_hasta >= periodoElejido.fecha_desde) || Periodo.fecha_hasta == periodoElejido.fecha_hasta) && (periodoElejido.id_periodo == 5))
                                   || ((Periodo.id_periodo == 1 || Periodo.id_periodo == 7 || Periodo.id_periodo == 3
                                      || Periodo.id_periodo == 2 || Periodo.id_periodo == 5 || Periodo.id_periodo == 8
                                      || Periodo.id_periodo == 10 || Periodo.id_periodo == 4) && periodoElejido.id_periodo == 4)
                                   || (Periodo.fecha_desde <= periodoElejido.fecha_hasta && periodoElejido.id_periodo == 3)
                                   || ((Periodo.fecha_desde >= periodoElejido.fecha_desde || periodoElejido.id_periodo == 4) && periodoElejido.id_periodo == 10))
                            group new { aula, materias }
                            by new {  aula.nombre, materias.materia } into g
                            select new HorarioList
                            {
                                cantcampo = g.Count(),
                                campo = g.Key.materia.ToString(),
                                aula = g.Key.nombre.ToString(),
                            };
           
                AgregarChart(chart, query,2);

            }
        }
        public static void ListarHoras(Chart chart, int id_aula, string periodo)
        {
            chart.Series.Clear();
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var periodoElejido = db.Periodo.FirstOrDefault(p => p.periodo_nombre == periodo);
                var query = from reserva in db.reserva
                               join aula in db.aula on reserva.id_aula equals aula.id_aula
                               join horas in db.horas on reserva.id_hora equals horas.id_hora
                               join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where aula.activa == "SI" && aula.id_aula == id_aula  && reserva.activo == "SI" && ((((Periodo.fecha_hasta <= periodoElejido.fecha_hasta && Periodo.fecha_desde >= periodoElejido.fecha_desde) || Periodo.id_periodo == 4) && periodoElejido.id_periodo == 1) ||
                                   (((Periodo.fecha_hasta >= periodoElejido.fecha_hasta && Periodo.fecha_desde <= periodoElejido.fecha_desde) || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 7))
                                   || ((Periodo.fecha_desde == periodoElejido.fecha_desde || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 6 || periodoElejido.id_periodo == 8))
                                   || ((Periodo.fecha_desde >= periodoElejido.fecha_desde || Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 2))
                                   || (Periodo.fecha_hasta == periodoElejido.fecha_hasta && (periodoElejido.id_periodo == 9))
                                   || (((Periodo.fecha_desde <= periodoElejido.fecha_desde && Periodo.fecha_hasta >= periodoElejido.fecha_desde) || Periodo.fecha_hasta == periodoElejido.fecha_hasta) && (periodoElejido.id_periodo == 5))
                                   || ((Periodo.id_periodo == 1 || Periodo.id_periodo == 7 || Periodo.id_periodo == 3
                                      || Periodo.id_periodo == 2 || Periodo.id_periodo == 5 || Periodo.id_periodo == 8
                                      || Periodo.id_periodo == 10 || Periodo.id_periodo == 4) && periodoElejido.id_periodo == 4)
                                   || (Periodo.fecha_desde <= periodoElejido.fecha_hasta && periodoElejido.id_periodo == 3)
                                   || ((Periodo.fecha_desde >= periodoElejido.fecha_desde || periodoElejido.id_periodo == 4) && periodoElejido.id_periodo == 10))
                            group new { reserva, aula, horas }
                               by new { reserva.id_hora, aula.nombre, horas.horario } into g
                               select new HorarioList
                               {
                                   cantcampo = g.Count(),
                                   campo = g.Key.horario.ToString(),
                                   aula = g.Key.nombre.ToString(),
                               };

                AgregarChart(chart, query, 1 );

            }
        }

    }
}
