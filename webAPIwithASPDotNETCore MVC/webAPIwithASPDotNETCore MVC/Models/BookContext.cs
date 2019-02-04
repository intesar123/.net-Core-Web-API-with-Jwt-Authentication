using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPIwithASPDotNETCore_MVC.Models
{
    public class BookContext:DbContext
    {

        public BookContext(DbContextOptions<BookContext> options):base(options)
        {
           
        }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-U19FN36;Database=CoreAppTest;User Id = sa;Password=Hello@123;Initial Catalog = CoreAppTest;");
            //}
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Id).IsRequired();
            });


        }
        

    }
}
