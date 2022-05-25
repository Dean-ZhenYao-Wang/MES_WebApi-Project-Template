using MES.CoreComponents;
using System.Collections.Generic;

namespace MES.Common
{
    public partial class OperationsRecordTemplateType
    {
        public IdentifierType ID { get; set; }
        public DescriptionType Description { get; set; }
        public IdentifierType Version { get; set; }
        public DateTimeType RecordTimestamp { get; set; }
        public DateTimeType EffectiveTimestamp { get; set; }
        public DateTimeType EffectiveEndDate { get; set; }
        public HierarchyScopeType HierarchyScope { get; set; }
        public OperationsRecordActionType Action { get; set; }
        public OperationsRecordEntryTemplateType OperationsRecordEntry { get; set; }
        public IdentifierType OperationsRecordSpecificationID { get; set; }
        public OperationsRecordTemplateType OperationsRecordChild { get; set; }
    }
}
