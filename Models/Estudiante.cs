using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Estudiantil.Models
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            ReporteCalificacion = new HashSet<ReporteCalificacion>();
        }

        public long Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Edad { get; set; }
        public string Carrera { get; set; }
        public long Condicion { get; set; }
        public long Beca { get; set; }

        public virtual ICollection<ReporteCalificacion> ReporteCalificacion { get; set; }
    }
}
