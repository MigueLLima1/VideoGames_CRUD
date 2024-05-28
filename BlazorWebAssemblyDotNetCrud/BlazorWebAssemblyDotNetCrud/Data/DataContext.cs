using BlazorWebAssemblyCrud.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssemblyDotNetCrud.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { Id = 1, Title = "Cyberpunk 2077", Publisher = "CD ProjectRed", ReleaseYear = 2020},
                new VideoGame { Id = 2, Title = "Minecraft", Publisher = "Monjang", ReleaseYear = 2011 },
                new VideoGame { Id = 3, Title = "Farcry 4", Publisher = "Ubisoft", ReleaseYear = 2014 }
                );
        }

        public DbSet<VideoGame> VideoGames { get; set; }
    }
}
