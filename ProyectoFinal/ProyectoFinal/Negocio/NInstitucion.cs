using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Modelo;
using ProyectoFinal.Negocio;

namespace ProyectoFinal.Negocio
{
    public class NInstitucion
    {
        public void Altas(Institucion institucion)
        {
            using(var ctxt=new ProyectoEntities())
	        {
                ctxt.Institucion.Add(institucion);
                ctxt.SaveChanges();	 
	        }
        }

        public void Eliminar(int id)
        {
            var insteliminar = new Institucion();
            using (var context = new ProyectoEntities())
            {
                insteliminar = context.Institucion.FirstOrDefault(x => x.ID == id);
                insteliminar.Habilitado = true;

                context.SaveChanges();
            }
        }

        public void Modificar(Institucion institucion)
        {
            using (var context = new ProyectoEntities())
            {
                var InstModificar = context.Institucion.FirstOrDefault(x => x.ID == institucion.ID);

                if (InstModificar == null)
                {
                    throw new Exception("No se encontró la Institución");
                }

                InstModificar.Nombre = institucion.Nombre;
                InstModificar.Telefono = institucion.Telefono;
                InstModificar.Descripcion = institucion.Descripcion;
                InstModificar.Direccion = institucion.Direccion;
                InstModificar.CodigoMin = institucion.CodigoMin;

                context.SaveChanges();
            }
        }

       
        public Institucion BuscarPorId(int id)
        {
            using (var context=new ProyectoEntities())
            {
               // return context.Institucion.FirstOrDefault(x => x.ID == id);
                return context.Institucion.FirstOrDefault(x => x.ID == id && x.Habilitado == false);
            }
        }

        public List<Institucion> BuscarPorstring(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if(string.IsNullOrEmpty(str))
                {
                    return context.Institucion.Where(x => x.Habilitado == false).ToList();
                }
                return context.Institucion.Where(x => x.Descripcion==str || x.Direccion==str || x.CodigoMin==str || x.Nombre==str).ToList();
            }
        }



    }
}
