using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
public partial class WorkAlertDefinitionTypeConfiguration : IEntityTypeConfiguration<WorkAlertDefinitionType>
{
    public void Configure(EntityTypeBuilder<WorkAlertDefinitionType> builder)
    {
        builder.Property(x => x.Priority)
            .HasConversion(
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            v => JsonSerializer.Deserialize<List<PriorityType>>(v, (JsonSerializerOptions)null),
            new ValueComparer<List<PriorityType>>(
                (c1, c2) => c1.Equals(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList()
                ));
        CustomizeConfiguration(builder);
    }

    #region Partial Methods

    partial void CustomizeConfiguration(EntityTypeBuilder<WorkAlertDefinitionType> builder);

    #endregion
}