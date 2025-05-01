using Microsoft.EntityFrameworkCore;
using PortfolioCore.Entities;

namespace PortfolioCore.Context
{
    public class PortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MERMILIUS;initial Catalog=PortfolioNightDb;integrated security=true;");
        }
        public DbSet<Entities.Contact> Contacts { get; set; }
        public DbSet<Entities.Education> Educations { get; set; }
        public DbSet<Entities.Experience> Experiences { get; set; }
        public DbSet<Entities.Message> Messages { get; set; }
        public DbSet<Entities.Testimonial> Testimonials { get; set; }
        public DbSet<Entities.Skill> Skills { get; set; }
        public DbSet<Entities.Category> Categories { get; set; }
        public DbSet<Entities.Portfolio> Portfolios { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Feature> Features { get; set; }

	}

}
