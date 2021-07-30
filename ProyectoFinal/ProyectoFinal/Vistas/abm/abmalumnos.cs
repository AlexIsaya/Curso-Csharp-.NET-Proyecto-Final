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

namespace ProyectoFinal.Vistas.abm
{
    public partial class abmalumnos : Formabm
    {
        Validacion1.ValidacionCompleta val = new Validacion1.ValidacionCompleta();
        public abmalumnos()
        {
            InitializeComponent();
            lbtitulo.Text = "Alta de Alumno";
        }

        private void abmalumnos_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btbuscarfoto_Click(object sender, EventArgs e)
        {
            if (ofdfoto.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(ofdfoto.FileName))
                {
                    picbfoto.Image = Image.FromFile(ofdfoto.FileName);
                }
            }
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            
                Negocio.NAlumno Nalu = new Negocio.NAlumno();
                Modelo.Alumnos obj = new Modelo.Alumnos();
             
                obj.Fecha = dtpfecha.Value;
                obj.Padre = tbpadre.Text;
                obj.Madre = tbmadre.Text;
                obj.Tutor = tbtutor.Text;
                obj.Enfermedades = tbenfermedades.Text;
                obj.Observaciones = tbobservaciones.Text;

                if (string.IsNullOrEmpty(tbdni.Text) || string.IsNullOrEmpty(tbdireccion.Text) || string.IsNullOrEmpty(tbnombre.Text)
                    || string.IsNullOrEmpty(tbapellido.Text) || string.IsNullOrEmpty(tbtelefono.Text))
                {
                    MessageBox.Show("Los campos obligatorios no pueden estar vacios");
                    return;
                }
                else
                {
                    obj.Dni = tbdni.Text;
                    obj.Direccion = tbdireccion.Text;
                    obj.Telefono = tbtelefono.Text;
                    obj.Nombre = tbnombre.Text;
                    obj.Apellido = tbapellido.Text;
                }
                obj.Foto = Convertir_Imagen_Bytes(picbfoto.Image);

                Nalu.Altas(obj);
                MessageBox.Show("Guardado con éxito");
           
        }

        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        private void tbapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void tbdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void tbnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void tbtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void tbpadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void tbmadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void tbtutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void tbenfermedades_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void tbobservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }
    }
}
