using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal.Vistas.Modificar
{
    public partial class Modificaralumno : abm.abmalumnos
    {
        int entidad;
        public Modificaralumno(int _entidad)
        {
            InitializeComponent();
            entidad = _entidad;
            lbtitulo.Text = "Modificación de Alumnos";
        }

        private void Modificaralumno_Load(object sender, EventArgs e)
        {
            Negocio.NAlumno Nalu = new Negocio.NAlumno();
            Modelo.Alumnos obj = Nalu.BuscarPorId(entidad);

            tbnombre.Text = obj.Nombre;
            tbapellido.Text = obj.Apellido;
            dtpfecha.Value = obj.Fecha;
            tbdireccion.Text = obj.Direccion;
            tbtelefono.Text = obj.Telefono;
            tbpadre.Text = obj.Padre;
            tbmadre.Text = obj.Madre;
            tbtutor.Text = obj.Tutor;
            tbenfermedades.Text = obj.Enfermedades;
            tbobservaciones.Text = obj.Observaciones;
            tbdni.Text = obj.Dni;

            var bytes = obj.Foto;
            var imagen = new MemoryStream(bytes);
            Image foto = Image.FromStream(imagen);

            picbfoto.Image = foto;
        }

        private void btaceptar2_Click(object sender, EventArgs e)
        {
            Negocio.NAlumno Nalu = new Negocio.NAlumno();
            Modelo.Alumnos obj = Nalu.BuscarPorId(entidad);
            
            obj.Nombre = tbnombre.Text;
            obj.Apellido = tbapellido.Text;
            obj.Fecha = dtpfecha.Value;
            obj.Direccion = tbdireccion.Text;
            obj.Telefono = tbtelefono.Text;
            obj.Padre = tbpadre.Text;
            obj.Madre = tbmadre.Text;
            obj.Tutor = tbtutor.Text;
            obj.Enfermedades = tbenfermedades.Text;
            obj.Observaciones = tbobservaciones.Text;
            obj.Dni = tbdni.Text;
            obj.Foto = Convertir_Imagen_Bytes(picbfoto.Image);

            Nalu.Modificar(obj);
            MessageBox.Show("Modificación Realizada con éxito");
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
