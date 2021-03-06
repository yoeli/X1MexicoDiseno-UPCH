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
    
    public partial class Listas
    {
        public Listas()
        {
            this.Acuses = new HashSet<Acuses>();
            this.ListaCentrosTrabajo = new HashSet<ListaCentrosTrabajo>();
        }
    
        public int ListaID { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> FolioEmpresa { get; set; }
        public System.DateTime FechaPresentacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int NumeroConstancias { get; set; }
        public string NombreRepresentante { get; set; }
        public Nullable<byte> Hombres { get; set; }
        public Nullable<byte> Mujeres { get; set; }
        public int CentroTrabajoSIRCEID { get; set; }
        public byte Origen { get; set; }
        public string UsuarioCreacion { get; set; }
        public int UnidadResponsableID { get; set; }
        public string UsuarioEnvio { get; set; }
        public Nullable<System.DateTime> FechaEnvio { get; set; }
        public byte Estatus { get; set; }
        public bool Eliminado { get; set; }
    
        public virtual ICollection<Acuses> Acuses { get; set; }
        public virtual CentrosTrabajoSIRCE CentrosTrabajoSIRCE { get; set; }
        public virtual ICollection<ListaCentrosTrabajo> ListaCentrosTrabajo { get; set; }
    }
}
