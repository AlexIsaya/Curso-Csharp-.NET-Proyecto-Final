using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Negocio;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Negocio
{
    public class Nañolectivo
    {
        public void Altas(AñoLectivo AñoLectivo)
        {
            using (var ctxt = new ProyectoEntities())
            {
                var nuevoañolec = new AñoLectivo()
                {
                    Año = AñoLectivo.Año,
                    Habilitado = false
                };
                ctxt.AñoLectivo.Add(nuevoañolec);
                ctxt.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            var añoleliminar = new AñoLectivo();
            using (var context = new ProyectoEntities())
            {
                añoleliminar = context.AñoLectivo.FirstOrDefault(x => x.ID == id);
                if (añoleliminar == null)
                {
                    throw new Exception("No se encontro el año lectivo");
                }
                añoleliminar.Habilitado = true;
                context.SaveChanges();
            }
        }

        public void Modificar(AñoLectivo AñoLectivo)
        {
            using (var context = new ProyectoEntities())
            {
                var modificarañolec = context.AñoLectivo.FirstOrDefault(x => x.ID == AñoLectivo.ID);
                
                if(modificarañolec == null)
                {
                    throw new Exception("No se encontro el año lectivo");
                }
                modificarañolec.Año = AñoLectivo.Año;
                
                context.SaveChanges();
            }
        }


        public AñoLectivo BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.AñoLectivo.FirstOrDefault(x => x.ID == id && x.Habilitado ==false);
            }
        }

        public List<AñoLectivo> BuscarPorString(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if(string.IsNullOrEmpty(str))
                {
                    return context.AñoLectivo.Where(x => x.Habilitado == false).ToList();
                }
                return context.AñoLectivo.Where(x => x.Año == str && x.Habilitado == false).ToList();
            }
        }
    }
}
