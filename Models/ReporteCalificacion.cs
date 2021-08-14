using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Estudiantil.Models
{
    public partial class ReporteCalificacion
    {
        public long ReporteCalificacionId { get; set; }
        public long EstudianteId { get; set; }
        public long MateriaId { get; set; }
        public string Cuatrimestre { get; set; }
        public long Calificacion { get; set; }

        public virtual Estudiante Estudiante { get; set; }
        public virtual Materia Materia { get; set; }
    }
}
