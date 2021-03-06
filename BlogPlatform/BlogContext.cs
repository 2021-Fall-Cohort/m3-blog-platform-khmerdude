using BlogPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform
{
    public class BlogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB_101421; Trusted_Connection=true";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Video Games" },
                new Category() { Id = 2, Name = "Basketball" },
                new Category() { Id = 3, Name = "GPUs" });

            modelbuilder.Entity<Content>().HasData(
                 new Content() { Id = 1, CategoryId = 1, Title = "Zelda is a wonderful game", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Eu lobortis elementum nibh tellus molestie nunc. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna. Rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui.", Author = "Bona", PublishDate = DateTime.Today },
                 new Content() { Id = 2, CategoryId = 2, Title = "Lebron James scored 50 in a loss to the Nets", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Eu lobortis elementum nibh tellus molestie nunc. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna. Rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui.", Author = "Bona", PublishDate = DateTime.Today },
                 new Content() { Id = 3, CategoryId = 3, Title = "3080 is still overpiced.", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Eu lobortis elementum nibh tellus molestie nunc. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna. Rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui.", Author = "Bona", PublishDate = DateTime.Today});
        }
    }
}
