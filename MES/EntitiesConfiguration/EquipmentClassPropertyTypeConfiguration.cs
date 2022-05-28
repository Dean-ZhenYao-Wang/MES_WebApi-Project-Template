using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;
public partial class EquipmentClassPropertyTypeConfiguration : IEntityTypeConfiguration<EquipmentClassPropertyType>
{
    public void Configure(EntityTypeBuilder<EquipmentClassPropertyType> builder)
    {
        builder.Property(x => x.Description)
            .HasConversion(
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            v => JsonSerializer.Deserialize<DescriptionType>(v, (JsonSerializerOptions)null));
        CustomizeConfiguration(builder);
    }

    #region Partial Methods

    partial void CustomizeConfiguration(EntityTypeBuilder<EquipmentClassPropertyType> builder);

    #endregion
}
