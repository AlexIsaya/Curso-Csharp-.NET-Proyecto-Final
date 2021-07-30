using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Modelo;
using ProyectoFinal.Negocio;

namespace ProyectoFinal.Negocio
{
    public class NInscripcion
    {
        public void Altas(Inscripciones inscripcion)
        {
            using (var ctxt = new ProyectoEntities())
            {
                var nuevainscripcion = new Inscripciones()
                {
                    AlumnosID = inscripcion.AlumnosID,
                    DivisionesID = inscripcion.DivisionesID,
                    AñoLectivoID = inscripcion.AñoLectivoID,
                    Fecha = inscripcion.Fecha,
                    Habilitado = false,
                    Observaciones = inscripcion.Observaciones
                };
                ctxt.Inscripciones.Add(nuevainscripcion);
                ctxt.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            var insceliminar = new Inscripciones();
            using (var context = new ProyectoEntities())
            {
                insceliminar = context.Inscripciones.FirstOrDefault(x => x.ID == id);
                if(insceliminar == null)
                {
                    throw new Exception("No se encontro la inscripcion");
                }
                insceliminar.Habilitado = true;
                context.SaveChanges();
            }
        }

        public void Modificar(Inscripciones inscripcion)
        {
            using (var context = new ProyectoEntities())
            {
                var modificarinscripcion = new Inscripciones();
                modificarinscripcion = context.Inscripciones.FirstOrDefault(x => x.ID == inscripcion.ID);
                if(modificarinscripcion == null)
                {
                    throw new Exception("No se encontro la inscripcion");
                }

                modificarinscripcion.AlumnosID = inscripcion.AlumnosID;
                modificarinscripcion.DivisionesID = inscripcion.DivisionesID;
                modificarinscripcion.AñoLectivoID = inscripcion.AñoLectivoID;
                modificarinscripcion.Fecha = inscripcion.Fecha;
                modificarinscripcion.Observaciones = inscripcion.Observaciones;

                context.SaveChanges();
            }
        }


        public Inscripciones BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.Inscripciones.FirstOrDefault(x => x.ID == id && x.Habilitado ==false);
            }
        }

        public List<Inscripciones> BuscarPorString(string str)
        {
            using (var context = new ProyectoEntities())
            {
                return context.Inscripciones.Where(x => x.Alumnos.Nombre == str || x.Divisiones.Nombre == str || x.AñoLectivo.Año == str && x.Habilitado == false).ToList();
            }
        }

        public List<Inscripcionesconsultalistado_Result> buscarlistado()
        {
            using (var context = new ProyectoEntities())
            {
                return context.Inscripcionesconsultalistado();
            }
        }


    }
}
