using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=10.2.2.166;port=3306;user=vsuser;password=123456;database=vspro;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
