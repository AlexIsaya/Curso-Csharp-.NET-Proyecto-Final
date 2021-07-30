using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas.Modificar
{
    public partial class ModificarGrado : Formabm
    {
        int entidadidGrado;
        public ModificarGrado(int _entidad)
        {
            InitializeComponent();
            entidadidGrado = _entidad;
            lbtitulo.Text = "Modificar Grado";
        }

        private void ModificarGrado_Load(object sender, EventArgs e)
        {
            Negocio.Nnivel Nnivel = new Negocio.Nnivel();
            IList<Modelo.Niveles> listaniveles = Nnivel.BuscarPorString(string.Empty);
            foreach (var item in listaniveles)
            {
                cbnivel.DataSource = listaniveles;
                cbnivel.DisplayMember = "Nombre";
                cbnivel.ValueMember = "ID";
            }
            Modelo.Grados grado = new Modelo.Grados();
            Negocio.NGrado Ngrado = new Negocio.NGrado();
            Modelo.Niveles niv = new Modelo.Niveles();

            grado = Ngrado.BuscarPorId(entidadidGrado);
            niv = Nnivel.BuscarPorId(grado.NivelesID);

            tbnombre.Text = grado.Nombre;
            tbdescripcion.Text = grado.Descripcion;
            cbnivel.Text = niv.Nombre;  //no se por que no lo toma al id desde el datagridview
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.NGrado Ngrado = new Negocio.NGrado();
            Modelo.Grados obj = Ngrado.BuscarPorId(entidadidGrado);

            obj.Nombre = tbnombre.Text;
            obj.Descripcion = tbdescripcion.Text;
            obj.NivelesID = ((Modelo.Niveles)cbnivel.SelectedItem).ID;

            Ngrado.Modificar(obj);
            MessageBox.Show("Modificación Realizada con éxito");
        }

    }
}
