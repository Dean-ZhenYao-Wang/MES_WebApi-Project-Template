﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2022/5/27 19:54:32
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaseDB
{
    /// <summary>
    /// There are no comments for 组织Configuration in the schema.
    /// </summary>
    [GeneratedCode("Devart Entity Developer", "")]
    public partial class 组织Configuration : IEntityTypeConfiguration<组织>
    {
        /// <summary>
        /// There are no comments for Configure(EntityTypeBuilder<组织> builder) method in the schema.
        /// </summary>
        public void Configure(EntityTypeBuilder<组织> builder)
        {
            builder.ToTable(@"组织");
            builder.Property(x => x.Key).HasColumnName(@"Key").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.编号).HasColumnName(@"编号").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.序号).HasColumnName(@"序号").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.名称).HasColumnName(@"名称").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.全名).HasColumnName(@"全名").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.上级组织Key).HasColumnName(@"上级组织Key").ValueGeneratedNever().HasMaxLength(4000);
            builder.HasKey(@"Key");
            builder.HasMany(x => x.下辖的用户列表).WithOne(op => op.组织).HasForeignKey(@"组织Key").IsRequired(true);
            builder.HasMany(x => x.下级组织列表).WithOne(op => op.上级组织).HasForeignKey(@"上级组织Key").IsRequired(false);
            builder.HasOne(x => x.上级组织).WithMany(op => op.下级组织列表).HasForeignKey(@"上级组织Key").IsRequired(false);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<组织> builder);

        #endregion
    }

}
