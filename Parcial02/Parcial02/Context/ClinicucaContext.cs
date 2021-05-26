using Microsoft.EntityFrameworkCore;
using Parcial02.Entities;

namespace Parcial02.Context 
{
    public class ClinicucaContext : DbContext
    {
        public DbSet<Question> questions { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Specialty> specialties { get; set; }
        public DbSet<Username> usernames { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("server=localhost\\SQLEXPRESS;Database=clinicuca;Trusted_Connection=True;");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .Property(r => r.id)		//esto lo hago con todas las entidades, con esto hago q mi id sea autoincrementable
                .ValueGeneratedOnAdd();
            
            modelBuilder.Entity<Question>()
                .Property(q => q.id)		//esto lo hago con todas las entidades, con esto hago q mi id sea autoincrementable
                .ValueGeneratedOnAdd();
            
            modelBuilder.Entity<Specialty>()
                .Property(s => s.id)		//esto lo hago con todas las entidades, con esto hago q mi id sea autoincrementable
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Username>()
                .HasKey(u => u.idCard);
            //esto lo hago con todas las entidades, con esto hago q mi id sea autoincrementable




        }
    }
}