using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

public partial class OperationsEventDefinitionTypeConfiguration : IEntityTypeConfiguration<OperationsEventDefinitionType>
{
    public void Configure(EntityTypeBuilder<OperationsEventDefinitionType> builder)
    {
        builder.Property(x => x.Priority)
            .HasConversion(
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            v => JsonSerializer.Deserialize<NumericType>(v, (JsonSerializerOptions)null));
        CustomizeConfiguration(builder);
    }

    #region Partial Methods

    partial void CustomizeConfiguration(EntityTypeBuilder<OperationsEventDefinitionType> builder);

    #endregion
}
