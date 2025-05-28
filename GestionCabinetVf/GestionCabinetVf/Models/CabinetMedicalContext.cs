using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace GestionCabinetVf.Models;

public partial class CabinetMedicalContext : DbContext
{
    public CabinetMedicalContext()
    {
    }

    public CabinetMedicalContext(DbContextOptions<CabinetMedicalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorie> Categories { get; set; }

    public virtual DbSet<Consultation> Consultations { get; set; }

    public virtual DbSet<Medicament> Medicaments { get; set; }

    public virtual DbSet<MedicamentOrdonnance> MedicamentOrdonnances { get; set; }

    public virtual DbSet<Ordonnance> Ordonnances { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Rdv> Rdvs { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;database=cabinet_medical", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.27-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Categorie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("categorie");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Consultation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("consultation");

            entity.HasIndex(e => e.PatientId, "patient_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DateConsultation)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("date_consultation");
            entity.Property(e => e.Maladie)
                .HasColumnType("text")
                .HasColumnName("maladie");
            entity.Property(e => e.PatientId)
                .HasColumnType("int(11)")
                .HasColumnName("patient_id");
            entity.Property(e => e.QuestionsReponses)
                .HasColumnType("text")
                .HasColumnName("questions_reponses");
            entity.Property(e => e.Remarques)
                .HasColumnType("text")
                .HasColumnName("remarques");

            entity.HasOne(d => d.Patient).WithMany(p => p.Consultations)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("consultation_ibfk_1");
        });

        modelBuilder.Entity<Medicament>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("medicament");

            entity.HasIndex(e => e.CategorieId, "fk_medicament_categorie");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CategorieId)
                .HasColumnType("int(11)")
                .HasColumnName("categorie_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Nom)
                .HasMaxLength(100)
                .HasColumnName("nom");

            entity.HasOne(d => d.Categorie).WithMany(p => p.Medicaments)
                .HasForeignKey(d => d.CategorieId)
                .HasConstraintName("fk_medicament_categorie");
        });

        modelBuilder.Entity<MedicamentOrdonnance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("medicament_ordonnance");

            entity.HasIndex(e => e.MedicamentId, "medicament_id");

            entity.HasIndex(e => e.OrdonnanceId, "ordonnance_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Dose)
                .HasMaxLength(100)
                .HasColumnName("dose");
            entity.Property(e => e.MedicamentId)
                .HasColumnType("int(11)")
                .HasColumnName("medicament_id");
            entity.Property(e => e.OrdonnanceId)
                .HasColumnType("int(11)")
                .HasColumnName("ordonnance_id");

            entity.HasOne(d => d.Medicament).WithMany(p => p.MedicamentOrdonnances)
                .HasForeignKey(d => d.MedicamentId)
                .HasConstraintName("medicament_ordonnance_ibfk_2");

            entity.HasOne(d => d.Ordonnance).WithMany(p => p.MedicamentOrdonnances)
                .HasForeignKey(d => d.OrdonnanceId)
                .HasConstraintName("medicament_ordonnance_ibfk_1");
        });

        modelBuilder.Entity<Ordonnance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ordonnance");

            entity.HasIndex(e => e.ConsultationId, "consultation_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ConsultationId)
                .HasColumnType("int(11)")
                .HasColumnName("consultation_id");

            entity.HasOne(d => d.Consultation).WithMany(p => p.Ordonnances)
                .HasForeignKey(d => d.ConsultationId)
                .HasConstraintName("ordonnance_ibfk_1");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("patient");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Adresse)
                .HasMaxLength(255)
                .HasColumnName("adresse");
            entity.Property(e => e.DateNaissance).HasColumnName("date_naissance");
            entity.Property(e => e.Nom)
                .HasMaxLength(100)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(100)
                .HasColumnName("prenom");
            entity.Property(e => e.Telephone)
                .HasMaxLength(20)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<Rdv>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rdv");

            entity.HasIndex(e => e.PatientId, "patient_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DateRdv)
                .HasColumnType("datetime")
                .HasColumnName("date_rdv");
            entity.Property(e => e.PatientId)
                .HasColumnType("int(11)")
                .HasColumnName("patient_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.Rdvs)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rdv_ibfk_1");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("utilisateur");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
