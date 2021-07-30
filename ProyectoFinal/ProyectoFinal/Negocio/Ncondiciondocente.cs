using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Modelo;
using ProyectoFinal.Negocio;

namespace ProyectoFinal.Negocio
{
    class Ncondiciondocente
    {
        public void Altas(CondicionDocente condicion)
        {
            using (var ctxt = new ProyectoEntities())
            {
                var nuevacondicion = new CondicionDocente()
                {
                    Descripcion=condicion.Descripcion,
                    Habilitado = false
                };
                ctxt.CondicionDocente.Add(nuevacondicion);
                ctxt.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            var condeliminar = new CondicionDocente();
            using (var context = new ProyectoEntities())
            {
                condeliminar = context.CondicionDocente.FirstOrDefault(x => x.ID == id);
                if(condeliminar == null)
                {
                    throw new Exception("No se encontro la condicion");
                }
                condeliminar.Habilitado = true;
                
                context.SaveChanges();
            }
        }

        public void Modificar(CondicionDocente condicion)
        {
            using (var context = new ProyectoEntities())
            {
                var modificarcondi = new CondicionDocente();
                modificarcondi = context.CondicionDocente.FirstOrDefault(x => x.ID == condicion.ID);
                if(modificarcondi == null)
                {
                    throw new Exception("No se encontro la condicion");
                }

                modificarcondi.Descripcion = condicion.Descripcion;

                context.SaveChanges();
            }
        }


        public CondicionDocente BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                //return context.CondicionDocente.FirstOrDefault(x => x.ID == id && x.Habilitado ==false);
                return context.CondicionDocente.FirstOrDefault(x => x.ID == id);
            }
        }

        public List<CondicionDocente> BuscarPorString(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if(string.IsNullOrEmpty(str))
                {
                    return context.CondicionDocente.Where(x => x.Habilitado == false).ToList();
                }
                return context.CondicionDocente.Where(x => x.Descripcion == str  && x.Habilitado == false).ToList();
            }
        }
    }
}
