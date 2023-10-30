using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SmartKern.Models;

namespace SmartKern.Data;

public partial class VsproContext : DbContext
{
    public VsproContext()
    {
    }

    public VsproContext(DbContextOptions<VsproContext> options)
        : base(options)
    {
    }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Contato> Contatos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
