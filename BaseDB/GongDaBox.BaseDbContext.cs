using Microsoft.EntityFrameworkCore;

namespace BaseDB
{

    public partial class BaseDbContext
    {
        #region Hierarchy scope model
        public DbSet<HierarchyScopeType> HierarchyScopes { get; set; }
        #endregion

        #region Product model
        public DbSet<ProductInformationType> ProductInformation { get; set; }
        public DbSet<ProductSegmentType> ProductSegments { get; set; }
        #endregion

        #region Test specification model
        public DbSet<TestSpecificationType> TestSpecifications { get; set; }
        public DbSet<TestSpecificationPropertyType> TestSpecificationProperties { get; set; }
        public DbSet<TestSpecificationCriteriaType> TestSpecificationCriterias { get; set; }
        public DbSet<TestSpecificationEvaluatedPropertyType> TestSpecificationEvaluatedProperties { get; set; }

        public DbSet<TestResultType> TestSpecificationResults { get; set; }
        #endregion

        #region Personnel model
        public DbSet<PersonnelClassType> PersonnelClasses { get; set; }
        public DbSet<PersonnelClassPropertyType> PersonnelClassProperties { get; set; }
        public DbSet<PersonType> Peoples { get; set; }
        public DbSet<PersonPropertyType> PeoplesProperties { get; set; }
        #endregion

        /// <summary>
        /// There are no comments for 用户_组织s property in the schema.
        /// </summary>
        public virtual DbSet<用户_组织> 用户_组织s
        {
            get;
            set;
        }

        /// <summary>
        /// There are no comments for 组织 property in the schema.
        /// </summary>
        public virtual DbSet<组织> 组织
        {
            get;
            set;
        }

        #region Role-based equipment model
        public DbSet<EquipmentClassType> EquipmentClasses { get; set; }
        public DbSet<EquipmentClassPropertyType> EquipmentClassProperties { get; set; }
        public DbSet<EquipmentType> Equipments { get; set; }
        public DbSet<EquipmentPropertyType> EquipmentProperties { get; set; }
        #endregion

        #region Physical asset model
        public DbSet<PhysicalAssetClassType> PhysicalAssetClasses { get; set; }
        public DbSet<PhysicalAssetClassPropertyType> PhysicalAssetClassProperties { get; set; }
        public DbSet<PhysicalAssetType> PhysicalAssets { get; set; }
        public DbSet<PhysicalAssetPropertyType> PhysicalAssetProperties { get; set; }
        #endregion

        #region Material model
        public DbSet<MaterialClassType> MaterialClasses { get; set; }
        public DbSet<MaterialClassPropertyType> MaterialClassProperties { get; set; }
        public DbSet<MaterialDefinitionType> MaterialDefinitions { get; set; }
        public DbSet<MaterialDefinitionPropertyType> MaterialDefinitionProperties { get; set; }
        public DbSet<MaterialLotType> MaterialLots { get; set; }
        public DbSet<MaterialLotPropertyType> MaterialLotProperties { get; set; }
        public DbSet<MaterialSubLotType> MaterialSubLots { get; set; }
        #endregion

        #region Operational location model
        public DbSet<OperationalLocationClassType> OperationalLocationClasses { get; set; }
        public DbSet<OperationalLocationClassPropertyType> OperationalLocationClassProperties { get; set; }
        public DbSet<OperationalLocationType> OperationalLocations { get; set; }
        public DbSet<OperationalLocationPropertyType> OperationalLocationProperties { get; set; }
        #endregion

        #region Process segment model
        public DbSet<ProcessSegmentType> ProcessSegments { get; set; }
        public DbSet<PersonnelSegmentSpecificationType> PersonnelSegmentSpecifications { get; set; }
        public DbSet<PersonnelSegmentSpecificationPropertyType> PersonnelSegmentSpecificationProperties { get; set; }
        public DbSet<EquipmentSegmentSpecificationType> EquipmentSegmentSpecifications { get; set; }
        public DbSet<EquipmentSegmentSpecificationPropertyType> EquipmentSegmentSpecificationProperties { get; set; }
        public DbSet<PhysicalAssetSegmentSpecificationType> PhysicalAssetSegmentSpecifications { get; set; }
        public DbSet<PhysicalAssetSegmentSpecificationPropertyType> PhysicalAssetSegmentSpecificationProperties { get; set; }
        public DbSet<MaterialSegmentSpecificationType> MaterialSegmentSpecifications { get; set; }
        public DbSet<MaterialSegmentSpecificationPropertyType> MaterialSegmentSpecificationProperties { get; set; }
        #endregion

        #region Operations event model
        public DbSet<OperationsEventClassType> OperationsEventClasses { get; set; }
        public DbSet<OperationsEventClassPropertyType> OperationsEventClassProperties { get; set; }
        public DbSet<OperationsEventDefinitionType> OperationsEventDefinitions { get; set; }
        public DbSet<OperationsEventType> OperationsEvents { get; set; }
        public DbSet<OperationsEventPropertyType> OperationsEventProperties { get; set; }
        #endregion

        #region Operations capability model
        public DbSet<OperationsCapabilityType> OperationsCapabilities { get; set; }
        public DbSet<OpProcessSegmentCapabilityType> OpProcessSegmentCapabilityProperties { get; set; }
        public DbSet<OpOperationsSegmentCapabilityType> OpOperationsSegmentCapabilities { get; set; }
        public DbSet<OpPersonnelCapabilityType> OpPersonnelCapabilities { get; set; }
        public DbSet<OpPersonnelCapabilityPropertyType> OpPersonnelCapabilityProperties { get; set; }
        public DbSet<OpEquipmentCapabilityType> OpEquipmentCapabilities { get; set; }
        public DbSet<OpEquipmentCapabilityPropertyType> OpEquipmentCapabilityProperties { get; set; }
        public DbSet<OpPhysicalAssetCapabilityType> OpPhysicalAssetCapabilities { get; set; }
        public DbSet<OpPhysicalAssetCapabilityPropertyType> OpPhysicalAssetCapabilityProperties { get; set; }
        public DbSet<OpMaterialCapabilityType> OpMaterialCapabilities { get; set; }
        public DbSet<OpMaterialCapabilityPropertyType> OpMaterialCapabilityProperties { get; set; }
        #endregion

        #region Operations definition model
        public DbSet<OperationsDefinitionType> OperationsDefinitions { get; set; }
        public DbSet<OperationsMaterialBillType> OperationsMaterialBills { get; set; }
        public DbSet<SegmentDependencyType> SegmentDependencies { get; set; }
        public DbSet<OperationsSegmentType> OperationsSegments { get; set; }
        public DbSet<OperationsMaterialBillItemType> OperationsMaterialBillItems { get; set; }
        public DbSet<OpPersonnelSpecificationType> OpPersonnelSpecifications { get; set; }
        public DbSet<OpPersonnelSpecificationPropertyType> OpPersonnelSpecificationProperties { get; set; }
        public DbSet<OpEquipmentSpecificationType> OpEquipmentSpecifications { get; set; }
        public DbSet<OpEquipmentSpecificationPropertyType> OpEquipmentSpecificationProperties { get; set; }
        public DbSet<OpPhysicalAssetSpecificationType> OpPhysicalAssetSpecifications { get; set; }
        public DbSet<OpPhysicalAssetSpecificationPropertyType> OpPhysicalAssetSpecificationProperties { get; set; }
        public DbSet<OpMaterialSpecificationType> OpMaterialSpecifications { get; set; }
        public DbSet<OpMaterialSpecificationPropertyType> OpMaterialSpecificationProperties { get; set; }
        #endregion

        #region Operations schedule model
        public DbSet<OperationsScheduleType> OperationsSchedules { get; set; }
        public DbSet<OperationsRequestType> OperationsRequests { get; set; }
        public DbSet<OpSegmentRequirementType> OpSegmentRequirements { get; set; }
        public DbSet<OpPersonnelRequirementType> OpPersonnelRequirements { get; set; }
        public DbSet<OpPersonnelRequirementPropertyType> OpPersonnelRequirementProperties { get; set; }
        public DbSet<OpEquipmentRequirementType> OpEquipmentRequirements { get; set; }
        public DbSet<OpEquipmentRequirementPropertyType> OpEquipmentRequirementProperties { get; set; }
        public DbSet<OpPhysicalAssetRequirementType> OpPhysicalAssetRequirements { get; set; }
        public DbSet<OpPhysicalAssetRequirementPropertyType> OpPhysicalAssetRequirementProperties { get; set; }
        public DbSet<OpMaterialRequirementType> OpMaterialRequirements { get; set; }
        public DbSet<OpMaterialRequirementPropertyType> OpMaterialRequirementProperties { get; set; }
        #endregion

        #region Operations performance model
        public DbSet<OperationsPerformanceType> OperationsPerformances { get; set; }
        public DbSet<OperationsResponseType> OperationsResponses { get; set; }
        public DbSet<OpSegmentResponseType> OpSegmentResponses { get; set; }
        public DbSet<OpSegmentDataType> OpSegmentDatas { get; set; }
        public DbSet<OpPersonnelActualType> OpPersonnelActuals { get; set; }
        public DbSet<OpPersonnelActualPropertyType> OpPersonnelActualProperties { get; set; }
        public DbSet<OpEquipmentActualType> OpEquipmentActuals { get; set; }
        public DbSet<OpEquipmentActualPropertyType> OpEquipmentActualProperties { get; set; }
        public DbSet<OpPhysicalAssetActualType> OpPhysicalAssetActuals { get; set; }
        public DbSet<OpPhysicalAssetActualPropertyType> OpPhysicalAssetActualProperties { get; set; }
        public DbSet<OpMaterialActualType> OpMaterialActuals { get; set; }
        public DbSet<OpMaterialActualPropertyType> OpMaterialActualProperties { get; set; }
        #endregion

        #region Resource relationship network model
        public DbSet<ResourceRelationshipNetworkType> ResourceRelationshipNetworks { get; set; }
        public DbSet<RRNPropertyType> ResourceRelationshipNetworkProperties { get; set; }
        public DbSet<ResourceNetworkConnectionType> ResourceNetworkConnections { get; set; }
        public DbSet<RNCPropertyType> ResourceNetworkConnectionProperties { get; set; }
        public DbSet<ResourceNetworkConnectionTypeType> ResourceNetworkConnectionTypes { get; set; }
        public DbSet<RNCTypePropertyType> ResourceNetworkConnectionTypeProperties { get; set; }
        public DbSet<ResourceReferenceType> ResourceReferences { get; set; }
        public DbSet<ResourceReferencePropertyType> ResourceReferencesProperties { get; set; }
        #endregion

        #region Work alert model
        public DbSet<WorkAlertDefinitionType> WorkAlertDefinitions { get; set; }
        public DbSet<WorkAlertDefinitionPropertyType> WorkAlertDefinitionProperties { get; set; }
        public DbSet<WorkAlertType> WorkAlerts { get; set; }
        public DbSet<WorkAlertPropertyType> WorkAlertProperties { get; set; }
        #endregion

        #region Work calendar
        public DbSet<WorkCalendarDefinitionEntryType> WorkCalendarDefinitionEntries { get; set; }
        public DbSet<WorkCalendarDefinitionEntryPropertyType> WorkCalendarDefinitionEntryProperties { get; set; }
        public DbSet<WorkCalendarDefinitionType> WorkCalendarDefinitions { get; set; }
        public DbSet<WorkCalendarDefinitionPropertyType> WorkCalendarDefinitionProperties { get; set; }
        public DbSet<WorkCalendarType> WorkCalendars { get; set; }
        public DbSet<WorkCalendarPropertyType> WorkCalendarProperties { get; set; }
        public DbSet<WorkCalendarEntryType> WorkCalendarEntries { get; set; }
        public DbSet<WorkCalendarEntryPropertyType> WorkCalendarEntryProperties { get; set; }
        #endregion

        #region Work capability model
        public DbSet<WorkCapabilityType> WorkCapabilities { get; set; }
        public DbSet<WorkMasterCapabilityType> WorkMasterCapabilities { get; set; }
        #endregion

        #region Work definition model
        public DbSet<WorkMasterType> WorkMasters { get; set; }
        public DbSet<WorkDirectiveType> WorkDirectives { get; set; }
        public DbSet<WorkflowSpecificationType> WorkflowSpecifications { get; set; }
        #endregion

        #region Work record
        public DbSet<WorkRecordType> WorkRecords { get; set; }
        public DbSet<WorkRecordEntryType> WorkRecordEntries { get; set; }
        #endregion

        #region Work schedule model
        public DbSet<WorkScheduleType> WorkSchedules { get; set; }
        public DbSet<WorkRequestType> WorkRequests { get; set; }
        public DbSet<WorkResponseType> WorkResponses { get; set; }
        public DbSet<JobOrderType> JobOrders { get; set; }
        public DbSet<JobResponseType> JobResponses { get; set; }
        public DbSet<JobListType> JobLists { get; set; }
        #endregion

        #region Work performance model
        public DbSet<WorkPerformanceType> WorkPerformances { get; set; }
        #endregion

        #region Workflow specification model
        public DbSet<WorkflowSpecificationPropertyType> WorkflowSpecificationProperties { get; set; }
        public DbSet<WorkflowSpecificationNodeTypeType> SpecificationNodeTypes { get; set; }
        public DbSet<WorkflowSpecificationNodeTypePropertyType> WorkflowSpecificationNodeTypeProperties { get; set; }
        public DbSet<WorkflowSpecificationNodeType> SpecificationNodes { get; set; }
        public DbSet<WorkflowSpecificationNodePropertyType> WorkflowSpecificationNodeProperties { get; set; }
        public DbSet<WorkflowSpecificationConnectionType> WorkflowSpecificationConnections { get; set; }
        public DbSet<WorkflowSpecificationConnectionPropertyType> WorkflowSpecificationConnectionProperties { get; set; }
        public DbSet<WorkflowSpecificationConnectionTypeType> WorkflowSpecificationConnectionTypes { get; set; }
        public DbSet<WorkflowSpecificationConnectionTypePropertyType> WorkflowSpecificationConnectionTypeProperties { get; set; }
        #endregion
        partial void CustomizeMapping(ref ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<用户_组织>(new 用户_组织Configuration());
            modelBuilder.ApplyConfiguration<组织>(new 组织Configuration());
            modelBuilder.ApplyConfiguration(new EquipmentClassPropertyTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobOrderTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OperationsEventDefinitionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OperationsEventTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OperationsRequestTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProcessSegmentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TestSpecificationCriteriaTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WorkAlertDefinitionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WorkAlertTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WorkRequestTypeConfiguration());
        }
    }



}
