using System;
using Microsoft.EntityFrameworkCore;
using MyLeasing.web.Data.Entities;

namespace MyLeasing.web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //se agrega todos los modelos para  que entityframework construya la base de datos
        // y las tablas..
        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Lessee> Lessees { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyImage> PropertyImages { get; set; }

        public DbSet<PropertyType> PropertyTypes  { get; set; }


    }
}
