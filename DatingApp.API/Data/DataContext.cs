using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.bin.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base (options){}
        
        public DbSet<Value1> Value1s {get;set;}

        public DbSet<User> Users {get; set;}
    }
}