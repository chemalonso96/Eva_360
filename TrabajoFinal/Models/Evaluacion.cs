//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evaluacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evaluacion()
        {
            this.EvalucionTema = new HashSet<EvalucionTema>();
        }
    
        public int EvaluacionId { get; set; }
        public string Nombre { get; set; }
        public decimal PorcentajeAvance { get; set; }
        public int SupervisorId { get; set; }
        public Nullable<int> ProveedorId { get; set; }
        public string RutaInforme { get; set; }
        public int EmpleadoId { get; set; }
        public int PeriodoId { get; set; }
        public int UsuarioCreacionId { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<int> UsuarioModificacionId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Periodo Periodo { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvalucionTema> EvalucionTema { get; set; }
    }
}
