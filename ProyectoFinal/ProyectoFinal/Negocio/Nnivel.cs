using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Modelo;
using ProyectoFinal.Negocio;

namespace ProyectoFinal.Negocio
{
    public class Nnivel
    {
        public void Altas(Niveles nivel)
        {
            using (var ctxt = new ProyectoEntities())
            {
                var nuevonivel = new Niveles()
                {
                    Nombre = nivel.Nombre,
                    InstitucionID = nivel.InstitucionID,
                    TurnoID = nivel.TurnoID,
                    Habilitado = false
                };
                ctxt.Niveles.Add(nuevonivel);
                ctxt.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            var niveliminar = new Niveles();
            using (var context = new ProyectoEntities())
            {
                niveliminar = context.Niveles.FirstOrDefault(x => x.ID == id);
                if(niveliminar == null)
                {
                    throw new Exception("No se encontro el nivel");
                }
                niveliminar.Habilitado = true;
                context.SaveChanges();
            }
        }

        public void Modificar(Niveles nivel)
        {
            using (var context = new ProyectoEntities())
            {
                var modificarnivel = new Niveles();
                modificarnivel = context.Niveles.FirstOrDefault(x => x.ID == nivel.ID);
                if(modificarnivel == null)
                {
                    throw new Exception("No se encontro el nivel");
                }

                modificarnivel.Nombre = nivel.Nombre;
                modificarnivel.InstitucionID = nivel.InstitucionID;
                modificarnivel.TurnoID = nivel.TurnoID;

                context.SaveChanges();
            }
        }


        public Niveles BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.Niveles.FirstOrDefault(x => x.ID == id && x.Habilitado ==false);
            }
        }

        public List<Niveles> BuscarPorString(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if(string.IsNullOrEmpty(str))
                {
                    return context.Niveles.Where(x => x.Habilitado == false).ToList();
                }
                return context.Niveles.Where(x => x.Nombre == str || x.Institucion.Nombre == str || x.Turnos.Descripcion == str && x.Habilitado == false).ToList();
            }
        }
    }
    }

