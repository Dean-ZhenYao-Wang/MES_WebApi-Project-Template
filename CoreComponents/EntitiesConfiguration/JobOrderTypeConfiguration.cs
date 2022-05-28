using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

public partial class JobOrderTypeConfiguration : IEntityTypeConfiguration<JobOrderType>
{
    public void Configure(EntityTypeBuilder<JobOrderType> builder)
    {
        builder.Property(x => x.Priority)
            .HasConversion(
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            v => JsonSerializer.Deserialize<PriorityType>(v, (JsonSerializerOptions)null));
        CustomizeConfiguration(builder);
    }

    #region Partial Methods

    partial void CustomizeConfiguration(EntityTypeBuilder<JobOrderType> builder);

    #endregion
}
