﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2022/5/19 17:14:38
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
    /// There are no comments for 用户Configuration in the schema.
    /// </summary>
    [GeneratedCode("Devart Entity Developer", "")]
    public partial class 用户Configuration : IEntityTypeConfiguration<用户>
    {
        /// <summary>
        /// There are no comments for Configure(EntityTypeBuilder<用户> builder) method in the schema.
        /// </summary>
        public void Configure(EntityTypeBuilder<用户> builder)
        {
            builder.ToTable(@"用户");
            builder.Property(x => x.Key).HasColumnName(@"Key").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.登录用户名).HasColumnName(@"登录用户名").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.密码).HasColumnName(@"密码").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.昵称).HasColumnName(@"昵称").IsRequired().ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.性别).HasColumnName(@"性别").ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.邮件).HasColumnName(@"邮件").ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.手机).HasColumnName(@"手机").ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.Code).HasColumnName(@"Code").ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.头像).HasColumnName(@"头像").ValueGeneratedNever().HasMaxLength(4000);
            builder.Property(x => x.年龄).HasColumnName(@"年龄").ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.生日).HasColumnName(@"生日").ValueGeneratedNever().HasMaxLength(4000);
            builder.HasKey(@"Key");
            builder.HasMany(x => x.所属的组织列表).WithOne(op => op.用户).HasForeignKey(@"用户Key").IsRequired(true);
            builder.HasMany(x => x.拥有的角色列表).WithOne(op => op.用户).HasForeignKey(@"用户Key").IsRequired(true);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<用户> builder);

        #endregion
    }

}
