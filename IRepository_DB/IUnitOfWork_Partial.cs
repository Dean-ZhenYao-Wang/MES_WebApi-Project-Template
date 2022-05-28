using System.Threading.Tasks;

namespace IRepository_DB
{
    public partial interface IUnitOfWork
    {
        #region Hierarchy scope model
        IRepository<HierarchyScopeType> HierarchyScopes { get; }
        #endregion

        #region Product model
        IRepository<ProductInformationType> ProductInformation { get; }
        IRepository<ProductSegmentType> ProductSegments { get; }
        #endregion

        #region Test specification model
        IRepository<TestSpecificationType> TestSpecifications { get; }
        IRepository<TestSpecificationPropertyType> TestSpecificationProperties { get; }
        IRepository<TestSpecificationCriteriaType> TestSpecificationCriterias { get; }
        IRepository<TestSpecificationEvaluatedPropertyType> TestSpecificationEvaluatedProperties { get; }

        IRepository<TestResultType> TestSpecificationResults { get; }
        #endregion

        #region Personnel model
        IRepository<PersonnelClassType> PersonnelClasses { get; }
        IRepository<PersonnelClassPropertyType> PersonnelClassProperties { get; }
        IRepository<PersonType> Peoples { get; }
        IRepository<PersonPropertyType> PeoplesProperties { get; }
        #endregion

        #region Role-based equipment model
        IRepository<EquipmentClassType> EquipmentClasses { get; }
        IRepository<EquipmentClassPropertyType> EquipmentClassProperties { get; }
        IRepository<EquipmentType> Equipments { get; }
        IRepository<EquipmentPropertyType> EquipmentProperties { get; }
        #endregion

        #region Physical asset model
        IRepository<PhysicalAssetClassType> PhysicalAssetClasses { get; }
        IRepository<PhysicalAssetClassPropertyType> PhysicalAssetClassProperties { get; }
        IRepository<PhysicalAssetType> PhysicalAssets { get; }
        IRepository<PhysicalAssetPropertyType> PhysicalAssetProperties { get; }
        #endregion

        #region Material model
        IRepository<MaterialClassType> MaterialClasses { get; }
        IRepository<MaterialClassPropertyType> MaterialClassProperties { get; }
        IRepository<MaterialDefinitionType> MaterialDefinitions { get; }
        IRepository<MaterialDefinitionPropertyType> MaterialDefinitionProperties { get; }
        IRepository<MaterialLotType> MaterialLots { get; }
        IRepository<MaterialLotPropertyType> MaterialLotProperties { get; }
        IRepository<MaterialSubLotType> MaterialSubLots { get; }
        #endregion

        #region Operational location model
        IRepository<OperationalLocationClassType> OperationalLocationClasses { get; }
        IRepository<OperationalLocationClassPropertyType> OperationalLocationClassProperties { get; }
        IRepository<OperationalLocationType> OperationalLocations { get; }
        IRepository<OperationalLocationPropertyType> OperationalLocationProperties { get; }
        #endregion

        #region Process segment model
        IRepository<ProcessSegmentType> ProcessSegments { get; }
        IRepository<PersonnelSegmentSpecificationType> PersonnelSegmentSpecifications { get; }
        IRepository<PersonnelSegmentSpecificationPropertyType> PersonnelSegmentSpecificationProperties { get; }
        IRepository<EquipmentSegmentSpecificationType> EquipmentSegmentSpecifications { get; }
        IRepository<EquipmentSegmentSpecificationPropertyType> EquipmentSegmentSpecificationProperties { get; }
        IRepository<PhysicalAssetSegmentSpecificationType> PhysicalAssetSegmentSpecifications { get; }
        IRepository<PhysicalAssetSegmentSpecificationPropertyType> PhysicalAssetSegmentSpecificationProperties { get; }
        IRepository<MaterialSegmentSpecificationType> MaterialSegmentSpecifications { get; }
        IRepository<MaterialSegmentSpecificationPropertyType> MaterialSegmentSpecificationProperties { get; }
        #endregion

        #region Operations event model
        IRepository<OperationsEventClassType> OperationsEventClasses { get; }
        IRepository<OperationsEventClassPropertyType> OperationsEventClassProperties { get; }
        IRepository<OperationsEventDefinitionType> OperationsEventDefinitions { get; }
        IRepository<OperationsEventType> OperationsEvents { get; }
        IRepository<OperationsEventPropertyType> OperationsEventProperties { get; }
        #endregion

        #region Operations capability model
        IRepository<OperationsCapabilityType> OperationsCapabilities { get; }
        IRepository<OpProcessSegmentCapabilityType> OpProcessSegmentCapabilityProperties { get; }
        IRepository<OpOperationsSegmentCapabilityType> OpOperationsSegmentCapabilities { get; }
        IRepository<OpPersonnelCapabilityType> OpPersonnelCapabilities { get; }
        IRepository<OpPersonnelCapabilityPropertyType> OpPersonnelCapabilityProperties { get; }
        IRepository<OpEquipmentCapabilityType> OpEquipmentCapabilities { get; }
        IRepository<OpEquipmentCapabilityPropertyType> OpEquipmentCapabilityProperties { get; }
        IRepository<OpPhysicalAssetCapabilityType> OpPhysicalAssetCapabilities { get; }
        IRepository<OpPhysicalAssetCapabilityPropertyType> OpPhysicalAssetCapabilityProperties { get; }
        IRepository<OpMaterialCapabilityType> OpMaterialCapabilities { get; }
        IRepository<OpMaterialCapabilityPropertyType> OpMaterialCapabilityProperties { get; }
        #endregion

        #region Operations definition model
        IRepository<OperationsDefinitionType> OperationsDefinitions { get; }
        IRepository<OperationsMaterialBillType> OperationsMaterialBills { get; }
        IRepository<SegmentDependencyType> SegmentDependencies { get; }
        IRepository<OperationsSegmentType> OperationsSegments { get; }
        IRepository<OperationsMaterialBillItemType> OperationsMaterialBillItems { get; }
        IRepository<OpPersonnelSpecificationType> OpPersonnelSpecifications { get; }
        IRepository<OpPersonnelSpecificationPropertyType> OpPersonnelSpecificationProperties { get; }
        IRepository<OpEquipmentSpecificationType> OpEquipmentSpecifications { get; }
        IRepository<OpEquipmentSpecificationPropertyType> OpEquipmentSpecificationProperties { get; }
        IRepository<OpPhysicalAssetSpecificationType> OpPhysicalAssetSpecifications { get; }
        IRepository<OpPhysicalAssetSpecificationPropertyType> OpPhysicalAssetSpecificationProperties { get; }
        IRepository<OpMaterialSpecificationType> OpMaterialSpecifications { get; }
        IRepository<OpMaterialSpecificationPropertyType> OpMaterialSpecificationProperties { get; }
        #endregion

        #region Operations schedule model
        IRepository<OperationsScheduleType> OperationsSchedules { get; }
        IRepository<OperationsRequestType> OperationsRequests { get; }
        IRepository<OpSegmentRequirementType> OpSegmentRequirements { get; }
        IRepository<OpPersonnelRequirementType> OpPersonnelRequirements { get; }
        IRepository<OpPersonnelRequirementPropertyType> OpPersonnelRequirementProperties { get; }
        IRepository<OpEquipmentRequirementType> OpEquipmentRequirements { get; }
        IRepository<OpEquipmentRequirementPropertyType> OpEquipmentRequirementProperties { get; }
        IRepository<OpPhysicalAssetRequirementType> OpPhysicalAssetRequirements { get; }
        IRepository<OpPhysicalAssetRequirementPropertyType> OpPhysicalAssetRequirementProperties { get; }
        IRepository<OpMaterialRequirementType> OpMaterialRequirements { get; }
        IRepository<OpMaterialRequirementPropertyType> OpMaterialRequirementProperties { get; }
        #endregion

        #region Operations performance model
        IRepository<OperationsPerformanceType> OperationsPerformances { get; }
        IRepository<OperationsResponseType> OperationsResponses { get; }
        IRepository<OpSegmentResponseType> OpSegmentResponses { get; }
        IRepository<OpSegmentDataType> OpSegmentDatas { get; }
        IRepository<OpPersonnelActualType> OpPersonnelActuals { get; }
        IRepository<OpPersonnelActualPropertyType> OpPersonnelActualProperties { get; }
        IRepository<OpEquipmentActualType> OpEquipmentActuals { get; }
        IRepository<OpEquipmentActualPropertyType> OpEquipmentActualProperties { get; }
        IRepository<OpPhysicalAssetActualType> OpPhysicalAssetActuals { get; }
        IRepository<OpPhysicalAssetActualPropertyType> OpPhysicalAssetActualProperties { get; }
        IRepository<OpMaterialActualType> OpMaterialActuals { get; }
        IRepository<OpMaterialActualPropertyType> OpMaterialActualProperties { get; }
        #endregion

        #region Resource relationship network model
        IRepository<ResourceRelationshipNetworkType> ResourceRelationshipNetworks { get; }
        IRepository<RRNPropertyType> ResourceRelationshipNetworkProperties { get; }
        IRepository<ResourceNetworkConnectionType> ResourceNetworkConnections { get; }
        IRepository<RNCPropertyType> ResourceNetworkConnectionProperties { get; }
        IRepository<ResourceNetworkConnectionTypeType> ResourceNetworkConnectionTypes { get; }
        IRepository<RNCTypePropertyType> ResourceNetworkConnectionTypeProperties { get; }
        IRepository<ResourceReferenceType> ResourceReferences { get; }
        IRepository<ResourceReferencePropertyType> ResourceReferencesProperties { get; }
        #endregion

        #region Work alert model
        IRepository<WorkAlertDefinitionType> WorkAlertDefinitions { get; }
        IRepository<WorkAlertDefinitionPropertyType> WorkAlertDefinitionProperties { get; }
        IRepository<WorkAlertType> WorkAlerts { get; }
        IRepository<WorkAlertPropertyType> WorkAlertProperties { get; }
        #endregion

        #region Work calendar
        IRepository<WorkCalendarDefinitionEntryType> WorkCalendarDefinitionEntries { get; }
        IRepository<WorkCalendarDefinitionEntryPropertyType> WorkCalendarDefinitionEntryProperties { get; }
        IRepository<WorkCalendarDefinitionType> WorkCalendarDefinitions { get; }
        IRepository<WorkCalendarDefinitionPropertyType> WorkCalendarDefinitionProperties { get; }
        IRepository<WorkCalendarType> WorkCalendars { get; }
        IRepository<WorkCalendarPropertyType> WorkCalendarProperties { get; }
        IRepository<WorkCalendarEntryType> WorkCalendarEntries { get; }
        IRepository<WorkCalendarEntryPropertyType> WorkCalendarEntryProperties { get; }
        #endregion

        #region Work capability model
        IRepository<WorkCapabilityType> WorkCapabilities { get; }
        IRepository<WorkMasterCapabilityType> WorkMasterCapabilities { get; }
        #endregion

        #region Work definition model
        IRepository<WorkMasterType> WorkMasters { get; }
        IRepository<WorkDirectiveType> WorkDirectives { get; }
        IRepository<WorkflowSpecificationType> WorkflowSpecifications { get; }
        #endregion

        #region Work record
        IRepository<WorkRecordType> WorkRecords { get; }
        IRepository<WorkRecordEntryType> WorkRecordEntries { get; }
        #endregion

        #region Work schedule model
        IRepository<WorkScheduleType> WorkSchedules { get; }
        IRepository<WorkRequestType> WorkRequests { get; }
        IRepository<WorkResponseType> WorkResponses { get; }
        IRepository<JobOrderType> JobOrders { get; }
        IRepository<JobResponseType> JobResponses { get; }
        IRepository<JobListType> JobLists { get; }
        #endregion

        #region Work performance model
        IRepository<WorkPerformanceType> WorkPerformances { get; }
        #endregion

        #region Workflow specification model
        IRepository<WorkflowSpecificationPropertyType> WorkflowSpecificationProperties { get; }
        IRepository<WorkflowSpecificationNodeTypeType> SpecificationNodeTypes { get; }
        IRepository<WorkflowSpecificationNodeTypePropertyType> WorkflowSpecificationNodeTypeProperties { get; }
        IRepository<WorkflowSpecificationNodeType> SpecificationNodes { get; }
        IRepository<WorkflowSpecificationNodePropertyType> WorkflowSpecificationNodeProperties { get; }
        IRepository<WorkflowSpecificationConnectionType> WorkflowSpecificationConnections { get; }
        IRepository<WorkflowSpecificationConnectionPropertyType> WorkflowSpecificationConnectionProperties { get; }
        IRepository<WorkflowSpecificationConnectionTypeType> WorkflowSpecificationConnectionTypes { get; }
        IRepository<WorkflowSpecificationConnectionTypePropertyType> WorkflowSpecificationConnectionTypeProperties { get; }
        #endregion
        Task SaveAsync();
    }
}