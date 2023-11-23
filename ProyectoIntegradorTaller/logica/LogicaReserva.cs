using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec.wmf;
using iTextSharp.text.pdf.draw;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.admin;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace ProyectoIntegradorTaller.logica
{
    public class LogicaReserva
    {
        public static string ListarProfesoresComboBoxSI( reserva res)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                return db.usuario
                .Where(r => r.id_usuario == res.id_usuario)
                .Select(p => new { fullname = p.nombre + " " + p.apellido })
                .FirstOrDefault().ToString();


            }
        }
        public static void ListarProfesoresComboBoxDS(ComboBoxPersonalisado CBPRofesor,reserva res)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                CBPRofesor.DisplayMember = "fullname";
                CBPRofesor.ValueMember = "id_usuario";
                
                CBPRofesor.DataSource=db.usuario
                    .Where(r => r.id_tipoUsuario == 4).Select(p => new { fullname = p.nombre + " " + p.apellido }).ToList();
                CBPRofesor.SelectedItem = db.usuario
                .Where(r => r.id_usuario == res.id_usuario)
                .Select(p => new { fullname = p.nombre + " " + p.apellido })
                .FirstOrDefault();




            }
        }


        public static horas ObtenerHorarioPorID(int idHorario)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var horario = db.horas.FirstOrDefault(h => h.id_hora == idHorario);
                return horario;
            }
        }

        public static reserva BuscarReservaPorId(int idReserva)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                try
                {
                    var reservaEncontrada = db.reserva.FirstOrDefault(r => r.id_reserva == idReserva);

                    return reservaEncontrada;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public static dias_semana ObtenerDiaPorID(int idDia)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var dia = db.dias_semana.FirstOrDefault(d => d.id_dias == idDia);
                return dia;
            }
        }

        public static Periodo ObtenerPeriodoPorNombre(string nombrePeriodo)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                return db.Periodo.FirstOrDefault(p => p.periodo_nombre == nombrePeriodo);
            }
        }

        public static Periodo ObtenerPeriodoPorId(int idPeriodo)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var periodo = db.Periodo.FirstOrDefault(p => p.id_periodo == idPeriodo);
                return periodo;
            }
        }



        public static reserva BuscarReservaParaGrilla(int idDia, int idHora, int idAula, int idPeriodo,string estado)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                var reserva1 = db.reserva.FirstOrDefault(
                    r => r.id_hora == idHora
                    && r.id_dia == idDia
                    && r.id_aula == idAula
                    && (((r.id_periodo == 1 || r.id_periodo == 3 || r.id_periodo == 6 || r.id_periodo == 7 || r.id_periodo == 4 || r.id_periodo == 5 || r.id_periodo == 10) && (idPeriodo == 1 || idPeriodo == 3))
                       || ((r.id_periodo == 1 || r.id_periodo == 3 || r.id_periodo == idPeriodo) && (idPeriodo == 6 || idPeriodo == 7))
                        || ((r.id_periodo == 2 || r.id_periodo == 4 || r.id_periodo == 8 || r.id_periodo == 9 || r.id_periodo == 5 || r.id_periodo == 10) && (idPeriodo == 2 || idPeriodo == 4 || idPeriodo == 5))
                        || ((r.id_periodo == 2 || r.id_periodo == 4 || r.id_periodo == idPeriodo) && (idPeriodo == 8 || idPeriodo == 9))
                        || ((r.id_periodo == 1 || r.id_periodo == 2 || r.id_periodo == 3 || r.id_periodo == 6 || r.id_periodo == 7 || r.id_periodo == 4 || r.id_periodo == 5 || r.id_periodo == 8 || r.id_periodo == 9 || r.id_periodo == 10) && (idPeriodo == 10))
                       )
                    && r.activo == estado);

                return reserva1;

            }
        }


        public static void MostrarGrillaDeReservas(int id_aula, DataGridView dataGrid, string periodo)
        {
            List<reserva> reservas;

            string[,] grillaHorarios = new string[7, 7] {
            { "8:00-10:00", "" ,"","","","",""},
            { "10:00-12:00", "" ,"","","","",""},
            { "12:00-14:00", "" ,"","","","",""},
            { "14:00-16:00", "" ,"","","","",""},
            { "16:00-18:00", "" ,"","","","",""},
            { "18:00-20:00", "" ,"","","","",""},
            { "20:00-22:00", "" ,"","","","",""}
            };


            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var periodoElejido = db.Periodo.FirstOrDefault(p => p.periodo_nombre == periodo);

                if (periodoElejido != null)
                {


                    var reservas1 = db.reserva
                        .Where(r => r.id_aula == id_aula && r.activo == "SI")
                        .AsEnumerable()
                        .Join(db.Periodo, reserva => reserva.id_periodo, p => p.id_periodo, (reserva, p) => new { Reserva = reserva, Periodo = p }
                           ).Where
                           (r => (((r.Periodo.fecha_hasta <= periodoElejido.fecha_hasta && r.Periodo.fecha_desde >= periodoElejido.fecha_desde) || r.Periodo.id_periodo == 4) && periodoElejido.id_periodo == 1) ||
                                   (((r.Periodo.fecha_hasta >= periodoElejido.fecha_hasta && r.Periodo.fecha_desde <= periodoElejido.fecha_desde) || r.Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 7))
                                   || ((r.Periodo.fecha_desde == periodoElejido.fecha_desde || r.Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 6 || periodoElejido.id_periodo == 8))
                                   || ((r.Periodo.fecha_desde >= periodoElejido.fecha_desde || r.Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 2))
                                   || (r.Periodo.fecha_hasta == periodoElejido.fecha_hasta && (periodoElejido.id_periodo == 9))
                                   || (((r.Periodo.fecha_desde <= periodoElejido.fecha_desde && r.Periodo.fecha_hasta >= periodoElejido.fecha_desde) || r.Periodo.fecha_hasta == periodoElejido.fecha_hasta) && (periodoElejido.id_periodo == 5))
                                   || ((r.Periodo.id_periodo == 1 || r.Periodo.id_periodo == 7 || r.Periodo.id_periodo == 3
                                      || r.Periodo.id_periodo == 2 || r.Periodo.id_periodo == 5 || r.Periodo.id_periodo == 8
                                      || r.Periodo.id_periodo == 10 || r.Periodo.id_periodo == 4) && periodoElejido.id_periodo == 4)
                                   || (r.Periodo.fecha_desde <= periodoElejido.fecha_hasta && periodoElejido.id_periodo == 3)
                                   || ((r.Periodo.fecha_desde >= periodoElejido.fecha_desde || periodoElejido.id_periodo == 4) && periodoElejido.id_periodo == 10)).Select(r => r.Reserva).ToList();


                    foreach (var res in reservas1)
                    {
                        var m = db.materias.FirstOrDefault(ma => ma.id_materia == res.id_materia);
                        var p = db.usuario.FirstOrDefault(pr => pr.id_usuario == res.id_usuario);
                        int dia = res.id_dia;
                        int horario = res.id_hora;


                        grillaHorarios[horario, dia] = m.materia + "( " + p.nombre + " " + p.apellido + " )";
                    }
                }
                else
                {

                }
            }
            dataGrid.Rows.Clear();

            for (int i = 0; i < 7; i++)
            {

                dataGrid.Rows.Add(grillaHorarios[i, 0], grillaHorarios[i, 1], grillaHorarios[i, 2], grillaHorarios[i, 3], grillaHorarios[i, 4], grillaHorarios[i, 5], grillaHorarios[i, 6]);

            }


        }

        public static void EliminarReserva(int idReserva)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var reserva = db.reserva.FirstOrDefault(r => r.id_reserva == idReserva);

                if (reserva != null)
                {
                    // Elimina la reserva
                    db.reserva.Remove(reserva);
                    db.SaveChanges();
                }

            }
        }


        public static void ReservaActiva(string estado, int idUsuario)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                reserva reservaDesactivar = db.reserva.FirstOrDefault(u => u.id_reserva == idUsuario);
                if (reservaDesactivar != null)
                {
                    reservaDesactivar.activo = estado;
                    db.SaveChanges();

                }
            }
        }

        public static void ImprimirComprobante(int id)
        {
            reserva reserva1 = LogicaReserva.BuscarReservaPorId(id);
            usuario usuario1 = LogicaUsuarios.ObtenerUsuarioPorID(reserva1.id_usuario);
            string materia = LogicaMaterias.ObtenerMateriaPorID(reserva1.id_materia).materia;
            Document document = new Document();

            try
            {
                string folderPath;

                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();


                DialogResult result = folderBrowserDialog.ShowDialog();

                // Verificar si el usuario hizo clic en el botón Aceptar
                if (result != DialogResult.OK)
                {
                    return;
                }

                folderPath = folderBrowserDialog.SelectedPath;

                string ruta = Path.Combine(folderPath, "reserva" + reserva1.id_reserva + ".pdf");



                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(ruta, FileMode.Create));

                // Abrir el documento
                document.Open();



                // Fuente y formato para el título
                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                titleFont.Color = BaseColor.BLUE;

                // Título
                Paragraph title = new Paragraph("Comprobante de Reserva", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // Línea separadora
                document.Add(new Chunk(new LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)));

                // Espacio en blanco
                document.Add(Chunk.NEWLINE);

                // Crear los objetos BaseColor para los colores
                BaseColor colorAzul = new BaseColor(17, 97, 238);
                BaseColor colorBlanco = BaseColor.WHITE;

                // Crear la tabla
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 3, 7 }); // Ancho de las columnas

                // Función para crear celdas con fondo de color
                PdfPCell CreateColoredCell(string label, BaseColor backgroundColor)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(label));
                    cell.BackgroundColor = backgroundColor;
                    return cell;
                }

                // Agregar las celdas a la tabla
                table.AddCell(CreateColoredCell("ID de Reserva:", BaseColor.LIGHT_GRAY));
                table.AddCell(CreateColoredCell(reserva1.id_reserva.ToString(), BaseColor.WHITE));
                table.AddCell(CreateColoredCell("Hora:", BaseColor.LIGHT_GRAY));
                table.AddCell(CreateColoredCell(LogicaReserva.ObtenerHorarioPorID(reserva1.id_hora).horario, BaseColor.WHITE));
                table.AddCell(CreateColoredCell("Día:", BaseColor.LIGHT_GRAY));
                table.AddCell(CreateColoredCell(LogicaReserva.ObtenerDiaPorID(reserva1.id_dia).dias, BaseColor.WHITE));
                table.AddCell(CreateColoredCell("Nombre:", BaseColor.LIGHT_GRAY));
                table.AddCell(CreateColoredCell(usuario1.nombre, BaseColor.WHITE));
                table.AddCell(CreateColoredCell("Apellido:", BaseColor.LIGHT_GRAY));
                table.AddCell(CreateColoredCell(usuario1.apellido, BaseColor.WHITE));
                table.AddCell(CreateColoredCell("DNI:", BaseColor.LIGHT_GRAY));
                table.AddCell(CreateColoredCell(usuario1.dni.ToString(), BaseColor.WHITE));
                table.AddCell(CreateColoredCell("Materia:", BaseColor.LIGHT_GRAY));
                table.AddCell(CreateColoredCell(materia, BaseColor.WHITE));

                document.Add(table);
                // Espacio en blanco
                document.Add(Chunk.NEWLINE);

                // Pie de página
                Paragraph footer = new Paragraph("Gracias por su reserva. ¡Esperamos verlo pronto!");
                footer.Alignment = Element.ALIGN_CENTER;
                document.Add(footer);
                MessageBox.Show("Se creo comprobante en la ruta " + ruta);
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                MessageBox.Show("Error al crear el PDF: " + ex.Message);
            }
            finally
            {
                // Cerrar el documento
                if (document.IsOpen())
                    document.Close();

            }

        }


        public static IList listarPeriodo()
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                return db.Periodo.ToList();
            }
        }
        public static IList CBMateriasListar()
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                return db.materias.Where(m => m.activo == "SI").ToList();
            }
        }

        public static IList CBPRofesorListar()
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                return db.usuario
                 .Where(r => r.id_tipoUsuario == 4).Select(p => new { fullname = p.nombre + " " + p.apellido, id_usuario = p.id_usuario }).ToList();

            }
        }
        public static void EditarReserva(int idReserva, int idHora, string CBMateria, string CBProfesor, int idDia, string periodo, string estado)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                // Obtener la reserva a editar
                var reserva = db.reserva.FirstOrDefault(r => r.id_reserva == idReserva);
                var periodoElegido = db.Periodo.FirstOrDefault(p => p.periodo_nombre == periodo);
                if (reserva != null)
                {
                    var names = CBProfesor.Split(' ');
                    var nombre = names[0];
                    var apellido = names.Length > 1 ? names[1] : string.Empty;

                    // Obtener los objetos asociados a los nombre
                    var materiaElegida = db.materias.FirstOrDefault(m => m.materia == CBMateria);
                    var usuarioProfesor = db.usuario.FirstOrDefault(usuario => usuario.nombre == nombre && usuario.apellido == apellido);


                    // Actualizar los campos de la reserva con los nuevos valores
                    reserva.id_hora = idHora;
                    reserva.id_materia = materiaElegida.id_materia;
                    reserva.id_usuario = usuarioProfesor.id_usuario;
                    reserva.id_dia = idDia;
                    reserva.activo = estado;
                    reserva.id_periodo = periodoElegido.id_periodo;

                    // Guardar los cambios en la base de datos
                    db.SaveChanges();
                }

            }
        }
        public static void DesactivarReserva(int idReserva)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var reserva = db.reserva.FirstOrDefault(r => r.id_reserva == idReserva);

                if (reserva != null)
                {
                    reserva.activo = "NO";


                    db.SaveChanges();
                }

            }
        }
        public static IList reservaDisponible(string aula, string periodo, string horario, string dia)
        {

            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var id_aula = db.aula.Where(a => a.activa == "SI").FirstOrDefault(a=> a.nombre==aula).id_aula;
                var periodoElejido = db.Periodo.FirstOrDefault(p => p.periodo_nombre == periodo);
                var diaElegido = db.dias_semana.FirstOrDefault(d => d.dias == dia);
                var horarioElegido = db.horas.FirstOrDefault(h => h.horario == horario);
                return db.reserva
                     .Where(r => r.id_aula == id_aula && r.activo == "SI" && r.id_hora == horarioElegido.id_hora && r.id_dia == diaElegido.id_dias)
                     .AsEnumerable()
                     .Join(db.Periodo, reserva => reserva.id_periodo, p => p.id_periodo, (reserva, p) => new { Reserva = reserva, Periodo = p }
                 ).Where
                            (r => (((r.Periodo.fecha_hasta <= periodoElejido.fecha_hasta && r.Periodo.fecha_desde >= periodoElejido.fecha_desde) || r.Periodo.id_periodo == 4) && periodoElejido.id_periodo == 1) ||
                                    (((r.Periodo.fecha_hasta >= periodoElejido.fecha_hasta && r.Periodo.fecha_desde <= periodoElejido.fecha_desde) || r.Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 7))
                                    || ((r.Periodo.fecha_desde == periodoElejido.fecha_desde || r.Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 6 || periodoElejido.id_periodo == 8))
                                    || ((r.Periodo.fecha_desde >= periodoElejido.fecha_desde || r.Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 2))
                                    || (r.Periodo.fecha_hasta == periodoElejido.fecha_hasta && (periodoElejido.id_periodo == 9))
                                    || (((r.Periodo.fecha_desde <= periodoElejido.fecha_desde && r.Periodo.fecha_hasta >= periodoElejido.fecha_desde) || r.Periodo.fecha_hasta == periodoElejido.fecha_hasta) && (periodoElejido.id_periodo == 5))
                                    || ((r.Periodo.id_periodo == 1 || r.Periodo.id_periodo == 7 || r.Periodo.id_periodo == 3
                                       || r.Periodo.id_periodo == 2 || r.Periodo.id_periodo == 5 || r.Periodo.id_periodo == 8
                                       || r.Periodo.id_periodo == 10 || r.Periodo.id_periodo == 4) && periodoElejido.id_periodo == 4)
                                    || (r.Periodo.fecha_desde <= periodoElejido.fecha_hasta && periodoElejido.id_periodo == 3)
                                    || ((r.Periodo.fecha_desde >= periodoElejido.fecha_desde || periodoElejido.id_periodo == 4) && periodoElejido.id_periodo == 10)).Select(r => r.Reserva).ToList();
            }
        }
        public static IList reservaDisponible(int id_aula,Periodo periodoElejido,horas horarioElegido,dias_semana diaElegido )
        {
            using (classroom_managerEntities db= new classroom_managerEntities())
            {
                return db.reserva
                     .Where(r => r.id_aula == id_aula && r.activo == "SI" && r.id_hora == horarioElegido.id_hora && r.id_dia == diaElegido.id_dias)
                     .AsEnumerable()
                     .Join(db.Periodo, reserva => reserva.id_periodo, p => p.id_periodo, (reserva, p) => new { Reserva = reserva, Periodo = p }
                 ).Where
                            (r => (((r.Periodo.fecha_hasta <= periodoElejido.fecha_hasta && r.Periodo.fecha_desde >= periodoElejido.fecha_desde) || r.Periodo.id_periodo == 4) && periodoElejido.id_periodo == 1) ||
                                    (((r.Periodo.fecha_hasta >= periodoElejido.fecha_hasta && r.Periodo.fecha_desde <= periodoElejido.fecha_desde) || r.Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 7))
                                    || ((r.Periodo.fecha_desde == periodoElejido.fecha_desde || r.Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 6 || periodoElejido.id_periodo == 8))
                                    || ((r.Periodo.fecha_desde >= periodoElejido.fecha_desde || r.Periodo.id_periodo == 4) && (periodoElejido.id_periodo == 2))
                                    || (r.Periodo.fecha_hasta == periodoElejido.fecha_hasta && (periodoElejido.id_periodo == 9))
                                    || (((r.Periodo.fecha_desde <= periodoElejido.fecha_desde && r.Periodo.fecha_hasta >= periodoElejido.fecha_desde) || r.Periodo.fecha_hasta == periodoElejido.fecha_hasta) && (periodoElejido.id_periodo == 5))
                                    || ((r.Periodo.id_periodo == 1 || r.Periodo.id_periodo == 7 || r.Periodo.id_periodo == 3
                                       || r.Periodo.id_periodo == 2 || r.Periodo.id_periodo == 5 || r.Periodo.id_periodo == 8
                                       || r.Periodo.id_periodo == 10 || r.Periodo.id_periodo == 4) && periodoElejido.id_periodo == 4)
                                    || (r.Periodo.fecha_desde <= periodoElejido.fecha_hasta && periodoElejido.id_periodo == 3)
                                    || ((r.Periodo.fecha_desde >= periodoElejido.fecha_desde || periodoElejido.id_periodo == 4) && periodoElejido.id_periodo == 10)).Select(r => r.Reserva).ToList();
            }
               
        }
        public static void InsertarReserva(int id_aula, string CBHora, string CBMateria, string CBPRofesor, string CBDia, string periodo, string Estado)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var names = CBPRofesor.Split(' ');
                var nombre = names[0];
                var apellido = names.Length > 1 ? names[1] : string.Empty;

                var periodoElejido = db.Periodo.FirstOrDefault(p => p.periodo_nombre == periodo);
                var usuarioProfesor = db.usuario.FirstOrDefault(usuario => usuario.nombre == nombre && usuario.apellido == apellido);
                var materiaElegida = db.materias.FirstOrDefault(materia => materia.materia == CBMateria);
                var diaElegido = db.dias_semana.FirstOrDefault(dia => dia.dias == CBDia);
                var horarioElegido = db.horas.FirstOrDefault(horario => horario.horario == CBHora);

                var reservas1 = reservaDisponible(id_aula, periodoElejido, horarioElegido, diaElegido);

                if (reservas1.Count == 0)
                {


                    reserva unaReserva = new reserva()
                    {
                        id_hora = horarioElegido.id_hora,
                        id_usuario = usuarioProfesor.id_usuario,
                        id_materia = materiaElegida.id_materia,
                        id_dia = diaElegido.id_dias,
                        id_aula = id_aula,
                        activo = Estado,
                        id_periodo = periodoElejido.id_periodo,
                    };

                    db.reserva.Add(unaReserva);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("no se puede elejir el periodo " + periodoElejido.periodo_nombre + " debido a que entraria en conflicto con otra reserva echa en otro periodo");

                }


            }
        }

        public static IList ListarReservasBusqueda(string estado, string terminoBusqueda)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            where reserva.activo == estado && (usuario.nombre.Contains(terminoBusqueda) || materias.materia.Contains(terminoBusqueda))
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre,
                                materia = materias.materia,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,
                            };

                return query.ToList();
            }
        }

        public static IList ListarReservasPorEstado(string estado)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where reserva.activo == estado
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " "+usuario.apellido,
                                periodo= Periodo.periodo_nombre,

                                materia = materias.materia,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }
        public static IList BusquedaReservasHoras(string estado, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where reserva.activo == estado
                            && horas.horario.Contains(valor)
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                periodo = Periodo.periodo_nombre,
                                materia = materias.materia,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }
        public static IList BusquedaReservasPeriodo(string estado, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where reserva.activo == estado
                            && Periodo.periodo_nombre.Contains(valor)
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                periodo = Periodo.periodo_nombre,
                                materia = materias.materia,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }
        public static IList BusquedaReservasPorNombreAula(string estado, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where reserva.activo == estado 
                            && aula.nombre.Contains(valor)
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                periodo=Periodo.periodo_nombre,
                                materia = materias.materia,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }
        public static IList BusquedaReservasPorNombreAula(string estado, int id, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            where reserva.activo == estado && reserva.id_usuario == id
                            && aula.nombre.Contains(valor)
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                materia = materias.materia,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }
        public static IList BusquedaReservasPorDia(string estado, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where reserva.activo==estado &&  dias_semana.dias.Contains(valor)
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                materia = materias.materia,
                                periodo=Periodo.periodo_nombre,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }
        public static IList BusquedaReservasPorDia(string estado, int id, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            where reserva.activo == estado && reserva.id_usuario == id
                            && dias_semana.dias.Contains(valor)
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                materia = materias.materia,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }
        public static IList BusquedaReservasPorHora(string estado,  string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where reserva.activo == estado && horas.horario.Contains(valor)
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                materia = materias.materia,
                                periodo=Periodo.periodo_nombre,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }
        public static IList BusquedaReservasPorHora(string estado, int id, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            where reserva.activo == estado && reserva.id_usuario == id
                            && horas.horario.Contains(valor)
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                materia = materias.materia,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }

        public static IList BusquedaReservasMateria(string estado, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where reserva.activo == estado 
                            && materias.materia.Contains(valor)
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                materia = materias.materia,
                                periodo=Periodo.periodo_nombre,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }
        public static IList BusquedaReservasMateria(string estado, int id, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            where reserva.activo == estado && reserva.id_usuario == id
                            && materias.materia.Contains(valor)
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                materia = materias.materia,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }

        public static IList BusquedaReservasPorUsuario(string estado, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var names = valor.Split(' ');
                var nombre = names[0];
                var apellido = names.Length > 1 ? names[1] : string.Empty;


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where reserva.activo == estado && usuario.nombre.Contains(nombre) && usuario.apellido.Contains(apellido)
                           
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre + " " + usuario.apellido,
                                materia = materias.materia,
                                periodo=Periodo.periodo_nombre,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };

                return query.ToList();
            }
        }



    }

}
