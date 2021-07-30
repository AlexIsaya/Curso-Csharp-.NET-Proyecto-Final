using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Negocio;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Negocio
{
    public class Nturno
    {
        public void Altas(Turnos turno)
        {
            using (var ctxt = new ProyectoEntities())
            {
                var nuevoturno = new Turnos()
                {
                    Descripcion = turno.Descripcion,
                    Habilitado = false
                };
                ctxt.Turnos.Add(nuevoturno);
                ctxt.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            var turneliminar = new Turnos();
            using (var context = new ProyectoEntities())
            {
                turneliminar = context.Turnos.FirstOrDefault(x => x.ID == id);
                if (turneliminar == null)
                {
                    throw new Exception("No se encontro el turno");
                }
                turneliminar.Habilitado = true;
                context.SaveChanges();
            }
        }

        public void Modificar(Turnos turno)
        {
            using (var context = new ProyectoEntities())
            {
                var modificarturno = new Turnos();
                modificarturno = context.Turnos.FirstOrDefault(x => x.ID == turno.ID);
                if (modificarturno == null)
                {
                    throw new Exception("No se encontro la inscripcion");
                }

                modificarturno.Descripcion = turno.Descripcion;

                context.SaveChanges();
            }
        }


        public Turnos BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.Turnos.FirstOrDefault(x => x.ID == id && x.Habilitado ==false);
            }
        }

        public List<Turnos> BuscarPorString(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if(string.IsNullOrEmpty(str))
                {
                    return context.Turnos.Where(x => x.Habilitado == false).ToList();
                }
                return context.Turnos.Where(x => x.Descripcion == str  && x.Habilitado == false).ToList();
            }
        }
    }
    }

