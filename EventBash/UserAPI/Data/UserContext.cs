using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

public class UserContext:DbContext
{
	public UserContext(DbContextOptions options ):base(options)
	{
	}
    public DbSet<Permissions> UserPermissions{ get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permissions>(ConfigurePermissions);

    }

    private void ConfigurePermissions(EntityTypeBuilder<Permissions> builder)
    {
        builder.ToTable("Permission");
        builder.Property(c => c.Id).IsRequired().ForSqlServerUseSequenceHiLo("permission_id_hilo");
        builder.Property(c => c.Type).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Description).IsRequired().HasMaxLength(200);
    }
}


