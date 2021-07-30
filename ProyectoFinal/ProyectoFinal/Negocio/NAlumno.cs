using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Modelo;


namespace ProyectoFinal.Negocio
{
    public class NAlumno
    {
        public void Altas(Alumnos alumno)
        {
            using (var ctxt = new ProyectoEntities())
            {
                Alumnos alumnonuevo = new Alumnos()
                {
                    Nombre = alumno.Nombre,
                    Apellido = alumno.Apellido,
                    Fecha = alumno.Fecha,
                    Dni = alumno.Dni,
                    Telefono = alumno.Telefono,
                    Direccion = alumno.Direccion,
                    Padre = alumno.Padre,
                    Madre = alumno.Madre,
                    Habilitado = false,
                    Enfermedades =     alumno.Enfermedades,
                    Tutor = alumno.Tutor,
                    Observaciones = alumno.Observaciones,
                    Foto = alumno.Foto
                };
               

                ctxt.Alumnos.Add(alumnonuevo);
                ctxt.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {

            using (var context = new ProyectoEntities())
            {

                var alumnoEliminar = new Alumnos();

                alumnoEliminar = context.Alumnos.FirstOrDefault(x => x.ID == id);

                if (alumnoEliminar == null)
                {
                    throw new Exception("No se encontró el alumno");
                }

                alumnoEliminar.Habilitado = true;

                context.SaveChanges();
            }
        }

        public void Modificar(Alumnos alumno)
        {
            using (var context=new ProyectoEntities())
            {


                var alumnoModificar = context.Alumnos.FirstOrDefault(x => x.ID == alumno.ID);

                if (alumnoModificar == null)
                {
                    throw new Exception("No se encontró alumno");
                }

                alumnoModificar.Nombre = alumno.Nombre;
                alumnoModificar.Apellido = alumno.Apellido;
                alumnoModificar.Fecha = alumno.Fecha;
                alumnoModificar.Dni = alumno.Dni;
                alumnoModificar.Telefono = alumno.Telefono;
                alumnoModificar.Direccion = alumno.Direccion;
                alumnoModificar.Padre = alumno.Padre;
                alumnoModificar.Madre = alumno.Madre;
                alumnoModificar.Enfermedades = alumno.Enfermedades;
                alumnoModificar.Tutor = alumno.Tutor;
                alumnoModificar.Observaciones = alumno.Observaciones;
                alumnoModificar.Foto = alumno.Foto;

                context.SaveChanges();

            }
        }


        public Alumnos BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.Alumnos.FirstOrDefault(x => x.ID == id && x.Habilitado==false);
            }
        }

        public List<Alumnos> Buscar(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if(string.IsNullOrEmpty(str))
                {
                    return context.Alumnos.Where(x => x.Habilitado == false).ToList();
                }
                return context.Alumnos.Where(x => x.Nombre == str || x.Apellido==str || x.Direccion == str || x.Dni == str && x.Habilitado==false).ToList();
            }
        }
    }
}
