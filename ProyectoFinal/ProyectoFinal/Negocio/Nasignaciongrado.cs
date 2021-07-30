using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Modelo;
using ProyectoFinal.Negocio;
using System.Data.Entity;

namespace ProyectoFinal.Negocio
{
    class NAsignaciongrado
    {
        public void Altas(AsignacionGrados asigna)
        {
            using (var ctxt = new ProyectoEntities())
            {
                var nuevasig = new AsignacionGrados()
                {
                    DocentesID = asigna.DocentesID,
                    DivisionesID = asigna.DivisionesID,
                    Habilitado = false
                };
                ctxt.AsignacionGrados.Add(nuevasig);
                ctxt.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            var asignaeliminar = new AsignacionGrados();
            using (var context = new ProyectoEntities())
            {
                asignaeliminar = context.AsignacionGrados.FirstOrDefault(x => x.ID == id);
                if (asignaeliminar == null)
                {
                    throw new Exception("No se encontro la asignacion");
                }
                asignaeliminar.Habilitado = true;
                context.SaveChanges();
            }
        }

        public void Modificar(AsignacionGrados asigna)
        {
            using (var context = new ProyectoEntities())
            {
                var modificarasigna = new AsignacionGrados();
                modificarasigna = context.AsignacionGrados.FirstOrDefault(x => x.ID == asigna.ID);
                if (modificarasigna == null)
                {
                    throw new Exception("No se encontro la asignacion");
                }

                modificarasigna.DocentesID = asigna.DocentesID;
                modificarasigna.DivisionesID = asigna.DivisionesID;


                context.SaveChanges();
            }
        }


        public AsignacionGrados BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.AsignacionGrados.FirstOrDefault(x => x.ID == id && x.Habilitado ==false);
            }
        }

        public List<AsignacionGrados> BuscarPorString(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if (string.IsNullOrEmpty(str))
                {
                    return context.AsignacionGrados.Where(x => x.Habilitado == false).ToList();
                }

                return context.AsignacionGrados.Where(x => x.Docentes.Nombre == str || x.Divisiones.Nombre == str  && x.Habilitado == false).ToList();
            }
        }



        public List<AsignacionGrados> buscarlistaIDdocentes(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.AsignacionGrados.Include("Docentes").Where(x => x.DocentesID == id).ToList();
            }
        }

        public List<Asignaciondivisiondocente_Result> buscarlistado()
        {
            using (var context = new ProyectoEntities())
            {
                return context.Asignaciondivisiondocente();
            }
        }

        //public ICollection<AsignacionGrados> buscarlistaIDdivision()
        //{
        //    using(var context = new ProyectoEntities())
        //    {
        //        //return context.AsignacionGrados.Include("Divisiones").Where(x => x.DivisionesID == id).ToList();
        //        var qwery = from doc in context.Docentes join div in context.Divisiones on doc.ID equals div.ID select new AsignacionGrados();
        //        return qwery.ToList();
        //    }
        //}
    }
}
