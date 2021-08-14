using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Estudiantil.Models
{
    public partial class Materia
    {
        public Materia()
        {
            ReporteCalificacion = new HashSet<ReporteCalificacion>();
        }

        public long MateriaId { get; set; }
        public string Nombre { get; set; }
        public long Creditos { get; set; }

        public virtual ICollection<ReporteCalificacion> ReporteCalificacion { get; set; }
    }
}
