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
    /// There are no comments for 用户_角色Configuration in the schema.
    /// </summary>
    [GeneratedCode("Devart Entity Developer", "")]
    public partial class 用户_角色Configuration : IEntityTypeConfiguration<用户_角色>
    {
        /// <summary>
        /// There are no comments for Configure(EntityTypeBuilder<用户_角色> builder) method in the schema.
        /// </summary>
        public void Configure(EntityTypeBuilder<用户_角色> builder)
        {
            builder.ToTable(@"用户_角色");
            builder.Property(x => x.Key).HasColumnName(@"Key").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.用户Key).HasColumnName(@"用户Key").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.角色Key).HasColumnName(@"角色Key").IsRequired().ValueGeneratedNever();
            builder.HasKey(@"Key", @"用户Key", @"角色Key");
            builder.HasOne(x => x.用户).WithMany(op => op.拥有的角色列表).HasForeignKey(@"用户Key").IsRequired(true);
            builder.HasOne(x => x.角色).WithMany(op => op.下辖的用户列表).HasForeignKey(@"角色Key").IsRequired(true);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<用户_角色> builder);

        #endregion
    }

}
