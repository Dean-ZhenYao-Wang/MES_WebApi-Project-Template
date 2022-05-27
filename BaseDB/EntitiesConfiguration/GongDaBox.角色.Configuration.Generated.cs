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
    /// There are no comments for 角色Configuration in the schema.
    /// </summary>
    [GeneratedCode("Devart Entity Developer", "")]
    public partial class 角色Configuration : IEntityTypeConfiguration<角色>
    {
        /// <summary>
        /// There are no comments for Configure(EntityTypeBuilder<角色> builder) method in the schema.
        /// </summary>
        public void Configure(EntityTypeBuilder<角色> builder)
        {
            builder.ToTable(@"角色");
            builder.Property(x => x.Key).HasColumnName(@"Key").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.名称).HasColumnName(@"名称").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
            builder.HasKey(@"Key");
            builder.HasMany(x => x.可访问的菜单列表).WithOne(op => op.角色).HasForeignKey(@"角色Key").IsRequired(true);
            builder.HasMany(x => x.下辖的用户列表).WithOne(op => op.角色).HasForeignKey(@"角色Key").IsRequired(true);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<角色> builder);

        #endregion
    }

}
