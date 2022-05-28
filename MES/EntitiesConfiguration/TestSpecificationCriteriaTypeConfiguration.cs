using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public partial class TestSpecificationCriteriaTypeConfiguration : IEntityTypeConfiguration<TestSpecificationCriteriaType>
{
    public void Configure(EntityTypeBuilder<TestSpecificationCriteriaType> builder)
    {
        builder.Property(x => x.Sequence)
            .HasConversion(
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            v => JsonSerializer.Deserialize<List<NumericType>>(v, (JsonSerializerOptions)null),
            new ValueComparer<List<NumericType>>(
                (c1, c2) => c1.Equals(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList()
                ));
        CustomizeConfiguration(builder);
    }

    #region Partial Methods

    partial void CustomizeConfiguration(EntityTypeBuilder<TestSpecificationCriteriaType> builder);

    #endregion
}
