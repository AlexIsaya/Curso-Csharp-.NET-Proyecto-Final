//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Niveles
    {
        public Niveles()
        {
            this.Grados = new HashSet<Grados>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int InstitucionID { get; set; }
        public int TurnoID { get; set; }
        public bool Habilitado { get; set; }
    
        public virtual ICollection<Grados> Grados { get; set; }
        public virtual Institucion Institucion { get; set; }
        public virtual Turnos Turnos { get; set; }
    }
}