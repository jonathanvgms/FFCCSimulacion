//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ffccSimulacion.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incidentes
    {
        public Incidentes()
        {
            this.Estaciones_X_Incidentes = new HashSet<Estaciones_X_Incidentes>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ProbabilidadOcurrencia { get; set; }
        public int TiempoDemora { get; set; }
    
        public virtual ICollection<Estaciones_X_Incidentes> Estaciones_X_Incidentes { get; set; }
    }
}
