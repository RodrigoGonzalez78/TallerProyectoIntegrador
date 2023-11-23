using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;


namespace ProyectoIntegradorTaller.logica
{
    internal class LogicaUsuarios
    {

        public static usuario ObtenerUsuarioPorID(int id_usuario)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var usuarioElejido = db.usuario.FirstOrDefault(u => u.id_usuario == id_usuario);
                return usuarioElejido;
            }
        }

        public static void CBTipoListar(ComboBoxPersonalisado box)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                box.DataSource = db.tipoUsuario.ToList();
                box.DisplayMember = "tipo"; 
                box.ValueMember = "id_tipoUsuario";
            }
        }
        public static IList buscarDNI(int idtipoUsuario, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.id_tipoUsuario == idtipoUsuario && usuario.dni.ToString().Contains(valor)
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                                
                            };
                return query.ToList();




            }
        }
     
        public static IList buscarEmail(int idtipoUsuario, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.id_tipoUsuario==idtipoUsuario && usuario.correo.Contains(valor)
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
               
                            };
                return query.ToList();




            }
        }
        public static IList buscarApellido(int idtipoUsuario, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.id_tipoUsuario==idtipoUsuario && usuario.apellido.Contains(valor)
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                      
                            };
                return query.ToList();




            }
        }
        public static IList buscarNombre(int idtipousuario, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.id_tipoUsuario==idtipousuario && usuario.nombre.Contains(valor)
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                
                            };
                return query.ToList();




            }
        }
        public static IList buscarDNI(bool RBActivo, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.desactivar == (RBActivo ? "NO" : "SI") && usuario.dni.ToString().Contains(valor)
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                                Tipo = tipoUsuario.tipo,
                                Activo = usuario.desactivar,
                            };
                return query.ToList();




            }
        }
        public static IList buscarTipo(bool RBActivo, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.desactivar == (RBActivo ? "NO" : "SI") && tipoUsuario.tipo.Contains(valor)
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                                Tipo = tipoUsuario.tipo,
                                Activo = usuario.desactivar,
                            };
                return query.ToList();




            }
        }
        public static IList buscarEmail(bool RBActivo, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.desactivar == (RBActivo ? "NO" : "SI") && usuario.correo.Contains(valor)
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                                Tipo = tipoUsuario.tipo,
                                Activo = usuario.desactivar,
                            };
                return query.ToList();




            }
        }
        public static IList buscarApellido(bool RBActivo, string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.desactivar == (RBActivo ? "NO" : "SI") && usuario.apellido.Contains(valor)
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                                Tipo = tipoUsuario.tipo,
                                Activo = usuario.desactivar,
                            };
                return query.ToList();




            }
        }
        public static IList buscarNombre(bool RBActivo,string valor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.desactivar == (RBActivo ? "NO" : "SI") && usuario.nombre.Contains(valor)
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                                Tipo = tipoUsuario.tipo,
                                Activo = usuario.desactivar,
                            };
                return query.ToList();




            }
        }
        public static IList ListarUsuarios(bool RBActivo)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.desactivar == (RBActivo? "NO" : "SI")
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI =usuario.dni,
                                Email = usuario.correo,
                                Tipo = tipoUsuario.tipo,
                                Activo = usuario.desactivar,
                            };
                return query.ToList();
              



            }
        }
        public static IList BuscarUsuario(string valor)
        {
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var query = from usuario in dbContext.usuario
                            join tipoUsuario in dbContext.tipoUsuario
                            on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where (usuario.nombre.Contains(valor) || usuario.apellido.Contains(valor))
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                                Tipo = tipoUsuario.tipo,
                                Activo = usuario.desactivar
                            };

                
                return query.ToList();
            }
        }

        public static void ActualisarUsuario(int id,int dni_, string apellido_, string emial, string nombre, int tipoU)
        {
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
              
                var entityToUpdate = dbContext.usuario.Find(id); 

                if (entityToUpdate != null)
                {
                   
                    entityToUpdate.nombre = nombre;
                    entityToUpdate.apellido = apellido_;
                    entityToUpdate.correo = emial;
                    entityToUpdate.id_tipoUsuario = tipoU;
                    entityToUpdate.dni = dni_;

                   
                    dbContext.SaveChanges();

                }
            }

        }
        public static void AgregarUsuario(int dni_, string apellido_ , string emial, string nombre,int tipoU)
        {
            usuario user = new usuario
            {
                dni = dni_,
                nombre = nombre,
                apellido = apellido_,
                correo = emial,
                id_tipoUsuario = tipoU,
                password=Encrypt.GetSHA256(dni_.ToString()),
                desactivar="NO"
            };

            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                db.usuario.Add(user);
                db.SaveChanges();
      

            }
        }

        public static void UsuarioCambiarEstado(string estado,int idUsuario)
        {
          

            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                usuario usuarioDesactivar = db.usuario.FirstOrDefault(u => u.id_usuario == idUsuario);
                if (usuarioDesactivar != null)
                {
                    usuarioDesactivar.desactivar = estado;
                    db.SaveChanges();

                }
            }
        }


        public static void CambiarPassword(string password, int id) {

            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {

                var entityToUpdate = dbContext.usuario.Find(id); 

                if (entityToUpdate != null)
                {
                   
                    entityToUpdate.password = Encrypt.GetSHA256(password);
                     
                    dbContext.SaveChanges();
                    
                }
            }
        }
        public static IList BuscarUsuarioProfesor(string valor)
        {
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var query = from usuario in dbContext.usuario
                            join tipoUsuario in dbContext.tipoUsuario
                            on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where (usuario.id_tipoUsuario == 4) && (usuario.nombre.Contains(valor) || usuario.apellido.Contains(valor))
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                                Tipo = tipoUsuario.tipo,
                                Activo = usuario.desactivar
                            };


                return query.ToList();
            }
        }
        public static IList ListarUsuariosPorId(int id)
        {
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var query = dbContext.usuario
                    .Where(usuario => usuario.tipoUsuario.id_tipoUsuario == id)
                    .Select(usuario => new
                    {
                        ID=usuario.id_usuario,
                        Nombre = usuario.nombre,
                        Apellido = usuario.apellido,
                        DNI = usuario.dni,
                        Email = usuario.correo,
                    })
                    .ToList();

               
                return query;
            }
        }

    }
}
