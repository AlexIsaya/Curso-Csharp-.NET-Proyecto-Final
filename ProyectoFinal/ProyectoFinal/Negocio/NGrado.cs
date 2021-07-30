using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Negocio;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Negocio
{
    public class NGrado
    {
        public void Altas(Grados Grados)
        {
            using (var ctxt = new ProyectoEntities())
            {
                ctxt.Grados.Add(Grados);

                ctxt.SaveChanges();


            }
        }

        public void Modificar(Grados Grados)
        {
            using (var context = new ProyectoEntities())
            {
                var GradoModificar = context.Grados.FirstOrDefault(x => x.ID == Grados.ID);

                if (GradoModificar == null)
                {
                    throw new Exception("No se encontró el grado");
                }

                GradoModificar.Nombre = Grados.Nombre;
                GradoModificar.Descripcion = Grados.Descripcion;
                //GradoModificar.NivelesID = Grados.NivelesID;

                context.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            //var gradoeliminar = new Grados();
            using (var context = new ProyectoEntities())
            {
                var gradoeliminar = new Grados();
                gradoeliminar = context.Grados.FirstOrDefault(x => x.ID == id);
                if (gradoeliminar == null)
                {
                    throw new Exception("No se encontro el grado");
                }
                gradoeliminar.Habilitado = true;
                context.SaveChanges();
            }
        }

        //public void Eliminar(Grados Grados)
        //{
        //    using (var context = new ProyectoEntities())
        //    {
        //        Grados.Habilitado = false;

        //        context.Grados.Add(Grados);

        //        context.SaveChanges();
        //    }
        //}

        public List<Grados> getGrados()
        {
            using (var context = new ProyectoEntities())
            {
                return context.Grados.ToList();
            }
        }

        public Grados BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.Grados.FirstOrDefault(x => x.ID == id);
            }
        }

        public List<Grados> BuscarPorString(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if(string.IsNullOrEmpty(str))
                {
                    return context.Grados.Where(x => x.Habilitado == false).ToList();
                }
                return context.Grados.Where(x => x.Descripcion==str || x.Nombre==str).ToList();
            }
        }
    }
}
