using MES.CoreComponents;
using MES.InformationObject;

namespace MES.Common
{
    public partial class OperationsRecordSpecTemplateType
    {
        public IdentifierType ID { get; set; }
        public DescriptionType Description { get; set; }
        public IdentifierType Version { get; set; }
        public DateTimeType PublishedDate { get; set; }
        public DataTypeType EffectiveStartDate { get; set; }
        public DataTypeType EffectiveEndDate { get; set; }
        public HierarchyScopeType HierarchyScope { get; set; }
        public IdentifierType OperationsRecordSpecificationPatternID { get; set; }
        public DefinitionTypeType DefinitionType { get; set; }
        public InformationObjectTypeType InformationObjectType { get; set; }
        public TextType InformationObjectTypeMultiplicity { get; set; }
        public OperationsRecordActionType Action { get; set; }
        public TextType ActionMultiplicity { get; set; }
        public OperationsRecordSpecTemplateType OperationsRecordSpecificationChild { get; set; }
    }
}
