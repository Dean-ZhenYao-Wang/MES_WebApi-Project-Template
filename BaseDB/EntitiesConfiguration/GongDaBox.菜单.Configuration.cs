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
    /// There are no comments for 菜单Configuration in the schema.
    /// </summary>
    public partial class 菜单Configuration
    {
        partial void CustomizeConfiguration(EntityTypeBuilder<菜单> builder)
        {
        }
    }
}
