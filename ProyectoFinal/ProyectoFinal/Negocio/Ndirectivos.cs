using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Modelo;
using System.IO;

namespace ProyectoFinal.Negocio
{
    class Ndirectivos
    {
        public void Altas(Directivos Directivo)
        {
            using (var context = new ProyectoEntities())
            {
                var directivonuevo = new Directivos()
                {
                    Nombre = Directivo.Nombre,
                    Apellido = Directivo.Apellido,
                    Dni = Directivo.Dni,
                    Telefono = Directivo.Telefono,
                    Direccion=Directivo.Direccion,
                    Cv=Directivo.Cv,
                    InstitucionID=Directivo.InstitucionID,
                    Habilitado = false,
                    
                };
                context.Directivos.Add(directivonuevo);
                context.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {

            using (var context = new ProyectoEntities())
            {

                var directivoeliminar = new Directivos();

                directivoeliminar = context.Directivos.FirstOrDefault(x => x.ID == id);

                if (directivoeliminar == null)
                {
                    throw new Exception("No se encontró el Directivo");
                }

                directivoeliminar.Habilitado = true;

                context.SaveChanges();
            }
        }

        public void Modificar(Directivos directivos)
        {
            using (var context = new ProyectoEntities())
            {


                var DirectivosModificar = context.Directivos.FirstOrDefault(x => x.ID == directivos.ID);

                if (DirectivosModificar == null)
                {
                    throw new Exception("No se encontró el Docentes");
                }

                DirectivosModificar.Apellido = directivos.Apellido;
                DirectivosModificar.Nombre = directivos.Nombre;
                DirectivosModificar.Telefono = directivos.Telefono;
                DirectivosModificar.Direccion = directivos.Direccion;
                DirectivosModificar.Cv = directivos.Cv;
                DirectivosModificar.InstitucionID = directivos.InstitucionID;
                DirectivosModificar.Dni = directivos.Dni;


                context.SaveChanges();

            }
        }


        public Directivos BuscarPorId(int id)
        {
            using (var context = new ProyectoEntities())
            {
                return context.Directivos.FirstOrDefault(x => x.ID == id && x.Habilitado == false);
            }
        }

        public List<Directivos> Buscar(string str)
        {
            using (var context = new ProyectoEntities())
            {
                if(string.IsNullOrEmpty(str))
                {
                    return context.Directivos.Where(x => x.Habilitado == false).ToList();
                }
                return context.Directivos.Where(x => x.Nombre == str || x.Apellido == str || x.Dni == str && x.Habilitado == false).ToList();
            }
        }

        //public static byte[] ConvertirFileToByteArray(string ruta)
        //{

        //    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
        //    /*Create a byte array of file stream length*/
        //    byte[] b = new byte[fs.Length];
        //    /*Read block of bytes from stream into the byte array*/
        //    fs.Read(b, 0, System.Convert.ToInt32(fs.Length));
        //    /*Close the File Stream*/
        //    fs.Close();

        //    return b;
        }
    }


