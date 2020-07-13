using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoExample.Entities;

namespace ToDoExample.DataAccess.Concrete.EF
{
    public class ToDoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;DataBase=ToDoDB;Integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().Property(p => p.DateTime)
                .HasColumnType("datetime");
        }
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<ToDoList> ToDoList { get; set; }
    }
}
