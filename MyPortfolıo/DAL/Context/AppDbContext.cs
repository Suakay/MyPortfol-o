using Microsoft.EntityFrameworkCore;
using MyPortfolıo.DAL.Entites;

namespace MyPortfolıo.DAL.Context
{
    public class AppDbContext:DbContext
    {
        public readonly IConfiguration  _configuration;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<About> Abouts { get; set; } 
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Skill> Skills { get; set; }    
        public DbSet<Experience> Experiences { get; set; }  
        public DbSet<SocialMedia>SocialMedias { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if(!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }



            
        }



    }
}
