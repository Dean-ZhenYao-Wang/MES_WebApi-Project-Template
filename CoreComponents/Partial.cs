using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public partial class HierarchyScopeType
{
    private List<HierarchyScopeType> hierarchyScopeChilds;

    public List<HierarchyScopeType> HierarchyScopeChilds { get => hierarchyScopeChilds; set => hierarchyScopeChilds = value; }
}
[Owned]
public partial class SpatialDefinitionType
{

}
public partial class OperationalLocationClassType
{
    public List<OperationalLocationClassType> OperationalLocationClassChild { get; set; }
    public List<OperationalLocationClassType> OperationalLocationClassBase { get; set; }
    public List<OperationalLocationClassType> OperationalLocationSource { get; set; }
    public List<OperationalLocationClassPropertyType> OperationalLocationClassProperty { get; set; }
}