using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Portfolio.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Experience> Experiences { get;set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Experience>()
                .Property(a => a.Skill)
                .HasConversion(new EnumToStringConverter<ExperienceSkillEnum>());
        }
    }
}