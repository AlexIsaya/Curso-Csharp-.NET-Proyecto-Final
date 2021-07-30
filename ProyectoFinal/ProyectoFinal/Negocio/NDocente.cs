using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Negocio;
using ProyectoFinal.Modelo;



namespace ProyectoFinal.Negocio
{
    public class NDocente
    {
        public void Altas(Docentes Docentes)
        {
            using (var context = new ProyectoEntities())
            {
                var Docentesnuevo = new Docentes() {
                    Nombre=Docentes.Nombre,
                    Apellido=Docentes.Apellido,
                    Dni=Docentes.Dni,
                    Telefono=Docentes.Telefono,
                    
                    Habilitado=false,
                    CondicionDocenteID=Docentes.CondicionDocenteID
                    
                };





                context.Docentes.Add(Docentesnuevo);
                context.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {

            using (var context = new ProyectoEntities())
            {

                var DocentesEliminar = new Docentes();

                DocentesEliminar = context.Docentes.FirstOrDefault(x => x.ID == id);

                if (DocentesEliminar == null)
                {
                    throw new Exception("No se encontró el Docente");
                }

                DocentesEliminar.Habilitado = true;

                context.SaveChanges();
            }
        }

        public void Modificar(Docentes Docentes)
        {
            using (var context = new ProyectoEntities())
            {


                var DocentesModificar = context.Docentes.FirstOrDefault(x => x.ID == Docentes.ID);

                if (DocentesModificar == null)
                {
                    throw new Exception("No se encontró el Docentes");
                }

                DocentesModificar.Apellido = Docentes.Apellido;
                DocentesModificar.Nombre = Docentes.Nombre;
                DocentesModificar.Telefono = Docentes.Telefono;
               
                DocentesModificar.CondicionDocenteID = Docentes.CondicionDocenteID;
                DocentesModificar.Dni = Docentes.Dni;
                

                context.SaveChanges();

            }
        }


        public Docentes BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.Docentes.FirstOrDefault(x => x.ID == id && x.Habilitado == false);
            }
        }

        public List<Docentes> Buscarporstring(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if(string.IsNullOrEmpty(str))
                {
                    return context.Docentes.Where(x => x.Habilitado == false).ToList();
                }
                return context.Docentes.Where(x => x.Nombre == str || x.Apellido == str  || x.Dni == str && x.Habilitado == false).ToList();
            }
        }

        public Docentes Buscar(string docente)
        {
            using (var context = new ProyectoEntities())
            {
                return context.Docentes.FirstOrDefault(x => x.Nombre == docente || x.Dni == docente && x.Habilitado == false);
            }
        }
    }
}
