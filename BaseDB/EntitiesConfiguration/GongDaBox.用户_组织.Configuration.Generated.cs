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
    /// There are no comments for 用户_组织Configuration in the schema.
    /// </summary>
    [GeneratedCode("Devart Entity Developer", "")]
    public partial class 用户_组织Configuration : IEntityTypeConfiguration<用户_组织>
    {
        /// <summary>
        /// There are no comments for Configure(EntityTypeBuilder<用户_组织> builder) method in the schema.
        /// </summary>
        public void Configure(EntityTypeBuilder<用户_组织> builder)
        {
            builder.ToTable(@"用户_组织");
            builder.Property(x => x.Key).HasColumnName(@"Key").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.用户Key).HasColumnName(@"用户Key").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.组织Key).HasColumnName(@"组织Key").IsRequired().ValueGeneratedNever();
            builder.HasKey(@"Key", @"用户Key", @"组织Key");
            builder.HasOne(x => x.用户).WithMany(op => op.所属的组织列表).HasForeignKey(@"用户Key").IsRequired(true);
            builder.HasOne(x => x.组织).WithMany(op => op.下辖的用户列表).HasForeignKey(@"组织Key").IsRequired(true);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<用户_组织> builder);

        #endregion
    }

}
