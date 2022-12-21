using FuzzySearchApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FuzzySearchApi.Data;

public class AppDbContext : DbContext
{
	public DbSet<Student>? Students { get; set; }
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasPostgresExtension("fuzzystrmatch");

        modelBuilder.Entity<Student>().HasData(new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "Azamjon",
                Age = 20
            },
            new Student()
            {
                Id = 2,
                Name = "MuhammadDiyor",
                Age = 18
            },
            new Student()
            {
                Id = 3,
                Name = "Nuriddin",
                Age = 26
            },
            new Student()
            {
                Id = 4,
                Name = "Abdulaziz",
                Age = 17
            },
            new Student()
            {
                Id = 5,
                Name = "Umidbek",
                Age = 26
            },
            new Student()
            {
                Id = 6,
                Name = "Botirjon",
                Age = 20
            },
            new Student()
            {
                Id = 7,
                Name = "Jamoliddin",
                Age = 19
            },
            new Student()
            {
                Id = 8,
                Name = "Shaxzod",
                Age = 23
            },
            new Student()
            {
                Id = 9,
                Name = "Javlon",
                Age = 25
            },
            new Student()
            {
                Id = 10,
                Name = "Abduvohid",
                Age = 26
            }
        });
    }
}