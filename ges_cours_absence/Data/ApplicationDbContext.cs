using ges_cours_absence.Models;
using Microsoft.EntityFrameworkCore;

namespace ges_cours_absence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<DetailCoursClasse> DetailCoursClasses { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);

        //     // Configuration pour Classe
        //     modelBuilder.Entity<Classe>()
        //         .HasMany(c => c.Etudiants)
        //         .WithOne()
        //         .HasForeignKey(e => e.Id)
        //         .OnDelete(DeleteBehavior.Restrict);

        //     modelBuilder.Entity<Classe>()
        //         .HasMany(c => c.detailCoursClasses)
        //         .WithOne(cc => cc.Classe)
        //         .HasForeignKey(cc => cc.ClasseId)
        //         .OnDelete(DeleteBehavior.Cascade);

        //     // Configuration pour Cours
        //     modelBuilder.Entity<Cours>()
        //         .HasOne(c => c.Professeur)
        //         .WithMany(p => p.Cours)
        //         .HasForeignKey(c => c.ProfesseurId)
        //         .OnDelete(DeleteBehavior.Restrict);

        //     modelBuilder.Entity<Cours>()
        //         .HasMany(c => c.detailCoursClasses)
        //         .WithOne(cc => cc.Cours)
        //         .HasForeignKey(cc => cc.CoursId)
        //         .OnDelete(DeleteBehavior.Cascade);

        //     // Configuration pour CoursClasse (table d'association)
        //     modelBuilder.Entity<DetailCoursClasse>()
        //         .HasKey(cc => new { cc.CoursId, cc.ClasseId });

        //     modelBuilder.Entity<DetailCoursClasse>()
        //         .HasOne(cc => cc.Cours)
        //         .WithMany(c => c.detailCoursClasses)
        //         .HasForeignKey(cc => cc.CoursId);

        //     modelBuilder.Entity<DetailCoursClasse>()
        //         .HasOne(cc => cc.Classe)
        //         .WithMany(c => c.detailCoursClasses)
        //         .HasForeignKey(cc => cc.ClasseId);

        //     // Configuration pour Absence
        //     modelBuilder.Entity<Absence>()
        //         .HasOne(a => a.Etudiant)
        //         .WithMany()
        //         .HasForeignKey(a => a.EtudiantId)
        //         .OnDelete(DeleteBehavior.Restrict);

        //     modelBuilder.Entity<Absence>()
        //         .HasOne(a => a.Cours)
        //         .WithMany()
        //         .HasForeignKey(a => a.CoursId)
        //         .OnDelete(DeleteBehavior.Restrict);
        // }

    }
}