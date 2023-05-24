using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication7._0.Models;

public partial class AspNet7Context : DbContext
{
    public AspNet7Context()
    {
    }

    public AspNet7Context(DbContextOptions<AspNet7Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
