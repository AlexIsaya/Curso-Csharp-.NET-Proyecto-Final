using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Negocio;
using ProyectoFinal.Modelo;


namespace ProyectoFinal.Negocio
{
    public class NDivisiones
    {
        public void Altas(Divisiones Divisiones)
        {
            using (var ctxt = new ProyectoEntities())
            {
                var nuevaDivisiones = new Divisiones()
                {
                    Nombre = Divisiones.Nombre,
                    GradosID = Divisiones.GradosID
                
                };
                ctxt.Divisiones.Add(nuevaDivisiones);
                ctxt.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            //var diveliminar = new Divisiones();
            using (var context = new ProyectoEntities())
            {
                var diveliminar = new Divisiones();
                diveliminar = context.Divisiones.FirstOrDefault(x => x.ID == id);
                if (diveliminar == null)
                {
                    throw new Exception("No se encontro la división");
                }
                diveliminar.Habilitado = true;
                context.SaveChanges();
            }
        }

        public void Modificar(Divisiones Divisioneses)
        {
            using (var context = new ProyectoEntities())
            {
                var modificarDivisiones = new Divisiones();
                modificarDivisiones = context.Divisiones.FirstOrDefault(x => x.ID == Divisioneses.ID);

                if (modificarDivisiones == null)
                {
                    throw new Exception("No se encontro la inscripcion");
                }

                modificarDivisiones.Nombre = Divisioneses.Nombre;
                modificarDivisiones.GradosID = Divisioneses.GradosID;
                

                context.SaveChanges();
            }
        }


        public Divisiones BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.Divisiones.FirstOrDefault(x => x.ID == id && x.Habilitado == false);
            }
        }

        public List<Divisiones> BuscarPorString(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if(string.IsNullOrEmpty(str))
                {
                    return context.Divisiones.Where(x => x.Habilitado == false).ToList();
                }
                return context.Divisiones.Where(x => x.Nombre == str || x.Grados.Nombre == str && x.Habilitado == false).ToList();
            }
        }
    }
}
