using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public partial class ProcessSegmentTypeConfiguration : IEntityTypeConfiguration<ProcessSegmentType>
{
    public void Configure(EntityTypeBuilder<ProcessSegmentType> builder)
    {
        //builder.HasMany(x => x.下级菜单列表).WithOne(op => op.上级菜单).HasForeignKey(@"上级菜单Key").IsRequired(false);
        //builder.HasOne(x => x.上级菜单).WithMany(op => op.下级菜单列表).HasForeignKey(@"上级菜单Key").IsRequired(false);
        //builder.HasMany(x => x.可访问的角色列表).WithOne(op => op.菜单).HasForeignKey(@"菜单Key").IsRequired(true);
        //过程段内有哪些依赖关系
        builder.HasMany(x => x.SegmentDependency).WithOne(op => op.ProcessSegment).HasForeignKey(o => o.ProcessSegmentKey);
        CustomizeConfiguration(builder);
    }

    #region Partial Methods

    partial void CustomizeConfiguration(EntityTypeBuilder<ProcessSegmentType> builder);

    #endregion
}
//public partial class SegmentDependencyTypeConfiguration : IEntityTypeConfiguration<SegmentDependencyType>
//{
//    public void Configure(EntityTypeBuilder<SegmentDependencyType> builder)
//    {
//        //过程段内的依赖关系上，谁是A谁是B
//        builder.HasOne(x => x.ProcessSegment_A).WithMany(op => op.SegmentDependency).HasForeignKey(o => o.ProcessSegment_A.Key);
//        builder.HasOne(x => x.ProcessSegment_B).WithMany(op => op.SegmentDependency).HasForeignKey(o => o.ProcessSegment_B.Key);
//        CustomizeConfiguration(builder);
//    }
//    partial void CustomizeConfiguration(EntityTypeBuilder<SegmentDependencyType> builder);
//}
