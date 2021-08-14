using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Estudiantil.Models
{
    public partial class ProgramaEstudiantilDBContext : DbContext
    {
        public ProgramaEstudiantilDBContext()
        {
        }

        public ProgramaEstudiantilDBContext(DbContextOptions<ProgramaEstudiantilDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<ReporteCalificacion> ReporteCalificacion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source= Data\\ProgramaEstudiantilDB.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.Matricula);

                entity.Property(e => e.Matricula).ValueGeneratedNever();

                entity.Property(e => e.Carrera).IsRequired();
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.Property(e => e.MateriaId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ReporteCalificacion>(entity =>
            {
                entity.HasIndex(e => e.EstudianteId);

                entity.HasIndex(e => e.MateriaId);

                entity.Property(e => e.ReporteCalificacionId).ValueGeneratedNever();

                entity.HasOne(d => d.Estudiante)
                    .WithMany(p => p.ReporteCalificacion)
                    .HasForeignKey(d => d.EstudianteId);

                entity.HasOne(d => d.Materia)
                    .WithMany(p => p.ReporteCalificacion)
                    .HasForeignKey(d => d.MateriaId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
