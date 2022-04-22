using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model.Entity;

namespace DataAccess.Model.Context
{
    public class IMDBContext:DbContext
    {
        public IMDBContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-55FON9IT;Database=IMDB;Trusted_Connection=True;";
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<MoviesAndCategories> MoviesAndCategories { get; set; }
        public DbSet<UserComments> UserComments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoviesAndCategories>().HasKey(x => new
            {
                x.MovieId,
                x.CategoryId
            });

            modelBuilder.Entity<UserComments>().HasKey(x => new
            {
                x.UserId,
                x.CommentId
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
