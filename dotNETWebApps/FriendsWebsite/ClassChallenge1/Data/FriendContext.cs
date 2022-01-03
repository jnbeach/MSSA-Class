using ClassChallenge1.Models;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.EntityFrameworkCore;

// Got this from a Microsoft tutorial:
//https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-6.0
//This tutorial is out of date. Using Leon's tutorial that uses EntityFrameworkCore


namespace ClassChallenge1.Data
{
    public class FriendContext : DbContext
    {
        //Constructor for FriendContext takes a set of Options as an argument
        public FriendContext(DbContextOptions<FriendContext> options) : base(options)
        {
        }
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>().ToTable("Friend");
        }
    }
}
