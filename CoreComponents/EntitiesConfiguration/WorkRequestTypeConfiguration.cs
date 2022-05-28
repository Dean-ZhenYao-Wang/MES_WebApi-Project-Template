using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

public partial class WorkRequestTypeConfiguration : IEntityTypeConfiguration<WorkRequestType>
{
    public void Configure(EntityTypeBuilder<WorkRequestType> builder)
    {
        builder.Property(x => x.Priority)
            .HasConversion(
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            v => JsonSerializer.Deserialize<PriorityType>(v, (JsonSerializerOptions)null));
        CustomizeConfiguration(builder);
    }

    #region Partial Methods

    partial void CustomizeConfiguration(EntityTypeBuilder<WorkRequestType> builder);

    #endregion
}
