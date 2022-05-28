using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Util.Model;

[Owned]
public partial class ErrorMessageType
{
}

[Owned]
public partial class MaterialInformationType
{
}

[Owned]
public partial class OperationalLocationInformationType
{
}

[Owned]
public partial class OperationsCapabilityInformationType
{
}

[Owned]
public partial class OperationsDefinitionInformationType
{
}

[Owned]
public partial class OperationsEventInformationType
{
}

[Owned]
public partial class OperationsTestInformationType
{
}

[Owned]
public partial class PropertyMeasurementType
{
}

[Owned]
public partial class PersonnelInformationType
{
}

[Owned]
public partial class PhysicalAssetInformationType
{
}

[Owned]
public partial class ProcessSegmentInformationType
{
}

[Owned]
public partial class TransactionProfileType
{
}

[Owned]
public partial class SupportedActionType
{
}

[Owned]
public partial class WorkAlertInformationType
{
}

[Owned]
public partial class WorkCalendarInformationType
{
}

[Owned]
public partial class WorkCapabilityInformationType
{
}

[Owned]
public partial class WorkDefinitionInformationType
{
}

[Owned]
public partial class JobResponseListType
{
}

[Owned]
public partial class WorkRecordSpecificationType
{
}

public partial class BatchProductionRecordType : BatchProductionRecordEntryType
{
}

[Owned]
public class BatchProductionRecordEntryType
{
    public IdentifierType EntryID { get; set; }
    public RecordObjectTypeType ObjectType { get; set; }
    public DateTimeType TimeStamp { get; set; }
    public IdentifierType ExternalReference { get; set; }
    public DescriptionType Description { get; set; }
}

public partial class OperationsEventType
{
    public virtual List<OperationsEventPropertyType> OperationsEventProperty { get; set; }
}

public partial class OperationsEventPropertyType : Base_Entity
{
}