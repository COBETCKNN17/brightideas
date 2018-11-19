using CBeltII.Models;
using CBeltII.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CBeltII.Data {
    public class DataContext : DbContext {
        public DataContext (DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }

    }
}