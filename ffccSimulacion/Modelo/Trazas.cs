//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Data.Linq.Mapping;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class Trazas
    {
        public Trazas()
        {
            this.Simulaciones = new HashSet<Simulaciones>();
            this.Trazas_X_Servicios = new HashSet<Trazas_X_Servicios>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Simulaciones> Simulaciones { get; set; }
        public virtual ICollection<Trazas_X_Servicios> Trazas_X_Servicios { get; set; }

        /*Estas propiedades no estan ni deben estar mapeadas en la base*/
        public List<Servicios> ServiciosDisponibles
        {
            get { return Trazas_X_Servicios.Select(x => x.Servicios).ToList<Servicios>(); }
        }

        /*public void LimpiarListaLINQParaPoderGuardar()
        {
            _listaServicios_LINQ = new EntitySet<Traza_X_Servicio>();
        }*/

        public void ConfigurarLosServiciosDeLaTraza()
        {
            foreach (Trazas_X_Servicios ts in Trazas_X_Servicios)
                ts.Servicios.ConfigurarServicio();
        }

        public void AgregarServicio(Servicios unServicio)
        {
            Trazas_X_Servicios ts = new Trazas_X_Servicios();
            ts.Id = this.Id;
            ts.Servicios = unServicio;
            Trazas_X_Servicios.Add(ts);
        }
    }
}
