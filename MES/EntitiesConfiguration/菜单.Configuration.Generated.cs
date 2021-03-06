//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2022/5/27 19:54:32
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.CodeDom.Compiler;

/// <summary>
/// There are no comments for 菜单Configuration in the schema.
/// </summary>
[GeneratedCode("Devart Entity Developer", "")]
public partial class 菜单Configuration : IEntityTypeConfiguration<菜单>
{
    /// <summary>
    /// There are no comments for Configure(EntityTypeBuilder<菜单> builder) method in the schema.
    /// </summary>
    public void Configure(EntityTypeBuilder<菜单> builder)
    {
        builder.ToTable(@"菜单");
        builder.Property(x => x.Key).HasColumnName(@"Key").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
        builder.Property(x => x.名称).HasColumnName(@"名称").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
        builder.Property(x => x.编号).HasColumnName(@"编号").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
        builder.Property(x => x.序号).HasColumnName(@"序号").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
        builder.Property(x => x.Url).HasColumnName(@"Url").ValueGeneratedNever().HasMaxLength(4000);
        builder.Property(x => x.ICON).HasColumnName(@"ICON").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
        builder.Property(x => x.上级菜单Key).HasColumnName(@"上级菜单Key").ValueGeneratedNever();
        builder.HasKey(@"Key");
        builder.HasMany(x => x.下级菜单列表).WithOne(op => op.上级菜单).HasForeignKey(@"上级菜单Key").IsRequired(false);
        builder.HasOne(x => x.上级菜单).WithMany(op => op.下级菜单列表).HasForeignKey(@"上级菜单Key").IsRequired(false);
        builder.HasMany(x => x.可访问的角色列表).WithOne(op => op.菜单).HasForeignKey(@"菜单Key").IsRequired(true);

        CustomizeConfiguration(builder);
    }

    #region Partial Methods

    partial void CustomizeConfiguration(EntityTypeBuilder<菜单> builder);

    #endregion
}
