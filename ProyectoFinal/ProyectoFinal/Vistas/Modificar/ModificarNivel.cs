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
    public partial class ModificarNivel : Formabm
    {
        int entidadidNivel;
        public ModificarNivel(int _entidad)
        {
            InitializeComponent();
            entidadidNivel = _entidad;
            lbtitulo.Text = "Modificar Nivel";
        }

        private void ModificarNivel_Load(object sender, EventArgs e)
        {
            Negocio.NInstitucion Nins = new Negocio.NInstitucion();
            IList<Modelo.Institucion> listainst = Nins.BuscarPorstring(string.Empty);
            foreach (var item in listainst)
            {
                cbinstitucion.DataSource = listainst;
                cbinstitucion.DisplayMember = "Nombre";
                cbinstitucion.ValueMember = "ID";
            }
            Negocio.Nturno Ntur = new Negocio.Nturno();
            IList<Modelo.Turnos> listatur = Ntur.BuscarPorString(string.Empty);
            foreach (var item in listatur)
            {
                cbturno.DataSource = listatur;
                cbturno.DisplayMember = "Descripcion";
                cbturno.ValueMember = "ID";
            }

            Modelo.Niveles niv = new Modelo.Niveles();
            Negocio.Nnivel Nniv = new Negocio.Nnivel();
            Modelo.Institucion ins = new Modelo.Institucion();
            Modelo.Turnos tur = new Modelo.Turnos();

            niv = Nniv.BuscarPorId(entidadidNivel);
            ins = Nins.BuscarPorId(niv.InstitucionID);
            tur = Ntur.BuscarPorId(niv.TurnoID);

            tbnombre.Text = niv.Nombre;
            cbinstitucion.Text = ins.Nombre;  //no se por que no lo toma al id desde el datagridview
            cbturno.Text = tur.Descripcion;  //no se por que no lo toma al id desde el datagridview
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.Nnivel Nniv = new Negocio.Nnivel();
            Modelo.Niveles obj = Nniv.BuscarPorId(entidadidNivel);

            obj.Nombre = tbnombre.Text;
            obj.InstitucionID = ((Modelo.Institucion)cbinstitucion.SelectedItem).ID;
            obj.TurnoID = ((Modelo.Turnos)cbturno.SelectedItem).ID;

            Nniv.Modificar(obj);
            MessageBox.Show("Modificación Realizada con éxito");
        }
    }
}
