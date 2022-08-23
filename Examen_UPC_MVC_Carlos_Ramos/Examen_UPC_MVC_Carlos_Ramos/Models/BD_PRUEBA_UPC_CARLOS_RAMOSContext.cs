using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Examen_UPC_MVC_Carlos_Ramos.Models
{
    public partial class BD_PRUEBA_UPC_CARLOS_RAMOSContext : DbContext
    {
        public BD_PRUEBA_UPC_CARLOS_RAMOSContext()
        {
        }

        public BD_PRUEBA_UPC_CARLOS_RAMOSContext(DbContextOptions<BD_PRUEBA_UPC_CARLOS_RAMOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAlumno> TbAlumnos { get; set; }
        public virtual DbSet<TbCurso> TbCursos { get; set; }
        public virtual DbSet<TbDetalleSolicitud> TbDetalleSolicituds { get; set; }
        public virtual DbSet<TbSolicitud> TbSolicituds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=BD_PRUEBA_UPC_CARLOS_RAMOS;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<TbAlumno>(entity =>
            {
                entity.HasKey(e => e.IdAlumno);

                entity.ToTable("TB_ALUMNO");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbCurso>(entity =>
            {
                entity.HasKey(e => e.IdCurso);

                entity.ToTable("TB_CURSO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TbDetalleSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdDetalleSol);

                entity.ToTable("TB_DETALLE_SOLICITUD");

                entity.Property(e => e.Aula)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Profesor)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Sede)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.TbDetalleSolicituds)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_DETALLE_SOLICITUD_TB_CURSO");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.TbDetalleSolicituds)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_DETALLE_SOLICITUD_TB_SOLICITUD");
            });

            modelBuilder.Entity<TbSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.ToTable("TB_SOLICITUD");

                entity.Property(e => e.Carrera)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CodRegistrante)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.TbSolicituds)
                    .HasForeignKey(d => d.IdAlumno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_SOLICITUD_TB_ALUMNO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
