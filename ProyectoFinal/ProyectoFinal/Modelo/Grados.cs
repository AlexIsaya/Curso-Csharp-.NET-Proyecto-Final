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
    
    public partial class Grados
    {
        public Grados()
        {
            this.Divisiones = new HashSet<Divisiones>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }
        public int NivelesID { get; set; }
    
        public virtual ICollection<Divisiones> Divisiones { get; set; }
        public virtual Niveles Niveles { get; set; }
    }
}
