
using PhoneBook.Models;
using Microsoft.EntityFrameworkCore;

namespace PhoneBook.Data
{
    public class DataBase : DbContext
    {


        public DataBase()
        {

        }
        public DataBase(DbContextOptions<DataBase> options)
          : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Image> Image { get; set; }



    }
}
