//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STPS.SIRCE.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Escolaridades
    {
        public Escolaridades()
        {
            this.Trabajadores = new HashSet<Trabajadores>();
        }
    
        public int EscolaridadID { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Trabajadores> Trabajadores { get; set; }
    }
}
