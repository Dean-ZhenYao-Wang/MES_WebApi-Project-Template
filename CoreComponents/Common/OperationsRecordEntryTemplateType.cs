using MES.CoreComponents;
using MES.InformationObject;
using System.Collections.Generic;

namespace MES.Common
{
    public partial class OperationsRecordEntryTemplateType
    {
        public InformationObjectType InformationObject { get; set; }
        public IdentifierType ExternalReferenceID { get; set; }

        public OperationsRecordEntryTemplateType(InformationObjectType informationObject, IdentifierType externalReferenceID = default)
        {
            InformationObject = informationObject;
            ExternalReferenceID = externalReferenceID;
        }
        public IdentifierType ID { get; set; }
        public DescriptionType Description { get; set; }
        public IdentifierType Version { get; set; }
        public DateTimeType RecordTimestamp { get; set; }
        public DateTimeType EffectiveTimestamp { get; set; }
        public DateTimeType EffectiveEndDate { get; set; }
        public HierarchyScopeType HierarchyScope { get; set; }
        public InformationObjectTypeType InformationObjectType { get; set; }
        public OperationsRecordEntryTemplateType OperationsRecordEntryChild { get; set; }
    }
}
