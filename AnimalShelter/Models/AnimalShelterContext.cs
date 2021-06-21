using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    }
    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Mimi", Species = "Cat", Age = 3, Gender = "Female" },
              new Animal { AnimalId = 2, Name = "Rocky", Species = "Dog", Age = 1, Gender = "Female" },
              new Animal { AnimalId = 3, Name = "Snowy", Species = "Cat", Age = 2, Gender = "Male" },
              new Animal { AnimalId = 4, Name = "Pika", Species = "Bird", Age = 3, Gender = "Male" },
              new Animal { AnimalId = 5, Name = "Moka", Species = "Bird", Age = 2, Gender = "Female" }
          );
    }
  }
}