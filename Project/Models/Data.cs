namespace Project.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class Data : DbContext
{
    
    public DbSet<Medication> Medications { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<PatientInfo> PatientInfos { get; set; }
    public DbSet<MedicationInfo> MedicationInfos { get; set; }
    public DbSet<PatientMedication> PatientMedications { get; set; }

    public string DbPath { get; }

    public Data(DbContextOptions<Data> options) : base(options)
    {
    
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>()
            .HasData(
                new Patient()
                {
                    patientInfo =  new PatientInfo()
                    {
                        Name = "Adam",
                        Surname = "Nowak",
                        Age = 34,
                        Height = 182,
                        Weight = 87
                    },
                },
                new Patient()
                {
                    patientInfo =  new PatientInfo()
                    {
                        Name = "Ewa",
                        Surname = "Porada",
                        Age = 23,
                        Height = 170,
                        Weight = 60
                    },
                });
        modelBuilder.Entity<Medication>()
            .HasData(
                new Medication()
                {
                    Name = "Vitamin C",
                    Selected = false,
                    medInfo = new MedicationInfo()
                    {
                        medType = MedType.Pill,
                        dosageType = DosageType.Other,
                        timeOfDay = TimeOfDay.Morning
                    }
                },
                new Medication()
                {
                    Name = "Vitamin B12",
                    Selected = false,
                    medInfo = new MedicationInfo()
                    {
                        medType = MedType.Pill,
                        dosageType = DosageType.Other,
                        timeOfDay = TimeOfDay.Morning
                    }
                },
                new Medication()
                {
                    Name = "Omega 3",
                    Selected = false,
                    medInfo = new MedicationInfo()
                    {
                        medType = MedType.Pill,
                        dosageType = DosageType.Other,
                        timeOfDay = TimeOfDay.Morning
                    }
                });
        modelBuilder.Entity<PatientMedication>()
            .HasData(
                new PatientMedication()
                {
                    PatientId = 1,
                    MedId = 1
                },
                new PatientMedication()
                {
                    PatientId = 1,
                    MedId = 2
                },
                new PatientMedication()
                {
                    PatientId = 2,
                    MedId = 1
                });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}