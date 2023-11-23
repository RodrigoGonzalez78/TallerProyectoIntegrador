using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.admin;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class LogicaClase
    {
        public static void AulaActiva(string estado, int idUsuario)
        {

            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                aula aulaDesactivar = db.aula.FirstOrDefault(u => u.id_aula == idUsuario);

                if (aulaDesactivar != null)
                {
                    aulaDesactivar.activa = estado;
                    db.SaveChanges();

                }
            }
        }


        public static string NombreAula(int id_aula)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var aula= db.aula.FirstOrDefault(u => u.id_aula==id_aula);
                return aula.nombre;
            }
        }


        public static IList ListarAula()
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
             
                var query = from aula in db.aula
                            join ubicacion in db.ubicacion on aula.id_ubicacion equals ubicacion.id_ubicacion
                            join tipoSala in db.tipoSala on aula.id_tipo equals tipoSala.id_sala

                            where aula.activa == "SI"
                            select new
                            {
                                Id = aula.id_aula,
                                Name = aula.nombre,
                                CapacidadMax = aula.capacidad,
                                Lugar = ubicacion.lugar, 
                                Tipo = tipoSala.tipo, 
                                Cantidad_PCs=aula.cantComputadoras,
                                Wifi = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 4 && r.id_aula == aula.id_aula).disponible,
                                Proyector= db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 3 && r.id_aula == aula.id_aula).disponible,
                                AC= db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 2 && r.id_aula == aula.id_aula).disponible,
                                Televisor= db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 1 && r.id_aula == aula.id_aula).disponible,
                            };


                return query.ToList();

            }
        }
       

       

        public static IList BusquedaAulaPorNombre(string valor)
        {
            
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from aula in db.aula
                            join ubicacion in db.ubicacion on aula.id_ubicacion equals ubicacion.id_ubicacion
                            join tipoSala in db.tipoSala on aula.id_tipo equals tipoSala.id_sala
                            where aula.activa == "SI" && aula.nombre.Contains(valor)
                            select new
                            {
                                Id = aula.id_aula,
                                Name = aula.nombre,
                                CapacidadMax = aula.capacidad,
                                Lugar = ubicacion.lugar,
                                Tipo = tipoSala.tipo,
                                Cantidad_PCs = aula.cantComputadoras,
                                Wifi = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 4 && r.id_aula == aula.id_aula).disponible,
                                Proyector = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 3 && r.id_aula == aula.id_aula).disponible,
                                AC = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 2 && r.id_aula == aula.id_aula).disponible,
                                Televisor = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 1 && r.id_aula == aula.id_aula).disponible,
                            };

                return query.ToList();


            }
        }

        public static IList BusquedaAulaPorCapacidad(string valor)
        {
            int valorInt = 0;


            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                int.TryParse(valor, out valorInt);


                var query = from aula in db.aula
                            join ubicacion in db.ubicacion on aula.id_ubicacion equals ubicacion.id_ubicacion
                            join tipoSala in db.tipoSala on aula.id_tipo equals tipoSala.id_sala
                            where aula.activa == "SI" && aula.capacidad >= valorInt 
                            select new
                            {
                                Id = aula.id_aula,
                                Name = aula.nombre,
                                CapacidadMax = aula.capacidad,
                                Lugar = ubicacion.lugar,
                                Tipo = tipoSala.tipo,
                                Cantidad_PCs = aula.cantComputadoras,
                                Wifi = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 4 && r.id_aula == aula.id_aula).disponible,
                                Proyector = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 3 && r.id_aula == aula.id_aula).disponible,
                                AC = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 2 && r.id_aula == aula.id_aula).disponible,
                                Televisor = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 1 && r.id_aula == aula.id_aula).disponible,
                            };

                return query.ToList();


            }
        }

        public static IList BusquedaAulaPorLugar(string valor)
        {
            

            using (classroom_managerEntities db = new classroom_managerEntities())
            {
              
                var query = from aula in db.aula
                            join ubicacion in db.ubicacion on aula.id_ubicacion equals ubicacion.id_ubicacion
                            join tipoSala in db.tipoSala on aula.id_tipo equals tipoSala.id_sala
                            where aula.activa == "SI" && ubicacion.lugar.Contains(valor)
                            select new
                            {
                                Id = aula.id_aula,
                                Name = aula.nombre,
                                CapacidadMax = aula.capacidad,
                                Lugar = ubicacion.lugar,
                                Tipo = tipoSala.tipo,
                                Cantidad_PCs = aula.cantComputadoras,
                                Wifi = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 4 && r.id_aula == aula.id_aula).disponible,
                                Proyector = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 3 && r.id_aula == aula.id_aula).disponible,
                                AC = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 2 && r.id_aula == aula.id_aula).disponible,
                                Televisor = db.aula_equipamiento.FirstOrDefault(r => r.id_equipamiento == 1 && r.id_aula == aula.id_aula).disponible,
                            };

                return query.ToList();


            }
        }

        public static void ActualisarAula(int id, string ttipo,string CBubicacion, string tnombre, string tcapacidad,string tcantPCs, bool CBAire, bool CBWIFI, bool CBProyector, bool CBTelevisor)
        {
            List<aula_equipamiento> aula_equi = new List<aula_equipamiento>();
            List<string> equipamiento = new List<string>();
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var tipoSala = dbContext.tipoSala.FirstOrDefault(tipoS => tipoS.tipo ==ttipo);
                var ubicacion = dbContext.ubicacion.FirstOrDefault(tipoU => tipoU.lugar == CBubicacion);
            
                equipamiento.Add(CBAire ? "SI" : "NO");
                equipamiento.Add(CBWIFI ? "SI" : "NO");
                equipamiento.Add(CBProyector ? "SI" : "NO");
                equipamiento.Add(CBTelevisor ? "SI" : "NO");


                for (int i = 0; i < 4; i++)
                {
                    aula_equi.Add(new aula_equipamiento()
                    {
                        id_aula = id,
                        id_equipamiento = i+1,
                        disponible = equipamiento[i],
                        
                    });
           
                }
           

                var entityToUpdate = dbContext.aula.Find(id);
                var entityToUpdate1 = dbContext.aula_equipamiento.Where(ae => ae.id_aula==id);
                if (entityToUpdate != null)
                {
                    entityToUpdate.nombre = tnombre;
                    entityToUpdate.capacidad = int.Parse(tcapacidad);
                    entityToUpdate.id_ubicacion = ubicacion.id_ubicacion;
                    entityToUpdate.id_tipo = tipoSala.id_sala;
                    entityToUpdate.cantComputadoras = int.Parse(tcantPCs);
                    for (int i = 0; i < 4; i++)
                    {
                        //var property = entityToUpdate1.GetType().GetProperty("aula_equi"+i);
                        var equipToUpdate = entityToUpdate1.FirstOrDefault(ae=> ae.id_equipamiento==i+1);
                        if(equipToUpdate != null)
                        {
                            equipToUpdate.disponible = aula_equi[i].disponible;
                            //property.SetValue(entityToUpdate1, aula_equi[i]);
                        }
                        
                    }
                    dbContext.SaveChanges();
                
                }
            }
        }
        public static bool ValidarNombreAula(string tnombre)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var nomaula = db.aula.FirstOrDefault(nom => nom.nombre == tnombre && nom.activa == "SI");
                if (nomaula == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static void AgregarAula(string ttipo,string CBubicacion,string tnombre,string tcantPCs,string tcapacidad,bool CBAire,bool CBWIFI,bool CBProyector,bool CBTelevisor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var tipoSala = db.tipoSala.FirstOrDefault(tipoS => tipoS.tipo == ttipo);
                var ubicacion = db.ubicacion.FirstOrDefault(tipoU => tipoU.lugar == CBubicacion);
                var  nomaula=db.aula.FirstOrDefault(nom=> nom.nombre == tnombre && nom.activa=="SI");
             


                    aula aula1 = new aula()
                    {
                        nombre = tnombre,
                        capacidad = int.Parse(tcapacidad),
                        id_ubicacion = ubicacion.id_ubicacion,
                        id_tipo = tipoSala.id_sala,
                        cantComputadoras=int.Parse(tcantPCs),
                        activa = "SI",
                    };


                    List<aula_equipamiento> aula_equi = new List<aula_equipamiento>();
                    List<string> equipamiento = new List<string>();


                    string disponibleCA = CBAire ? "SI" : "NO";
                    string disponibleWIFI = CBWIFI ? "SI" : "NO";
                    string disponibleProyector = CBProyector ? "SI" : "NO";
                    string disponibleTelevisor = CBTelevisor ? "SI" : "NO";

                    equipamiento.Add(disponibleTelevisor);
                    equipamiento.Add(disponibleCA);
                    equipamiento.Add(disponibleProyector);
                    equipamiento.Add(disponibleWIFI);
                    
                   

                    
                    for (int i = 0; i < 4; i++)
                    {
                        aula_equi.Add(new aula_equipamiento()
                        {
                            id_aula = aula1.id_aula,
                            id_equipamiento = i + 1,
                            disponible = equipamiento[i],
                        });

                    }

                    db.aula.Add(aula1);

                    for (int i = 0; i < 4; i++)
                    {
                        db.aula_equipamiento.Add(aula_equi[i]);
                    };



                    db.SaveChanges();
                   
                
               

            }
        }
    }
}
