using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseDB.Migrations
{
    public partial class _005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOrders_JobOrderParameter_ParameterSpecificationID_JobOrders_JobOrderParameter_ParameterTypeJobOrderTypeKey_ParameterTypeId",
                table: "JobOrders_JobOrderParameter_ParameterSpecificationID");

            migrationBuilder.DropForeignKey(
                name: "FK_JobOrders_JobOrderParameter_Value_JobOrders_JobOrderParameter_ParameterTypeJobOrderTypeKey_ParameterTypeId",
                table: "JobOrders_JobOrderParameter_Value");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkMasters_ParameterSpecification_Value_WorkMasters_ParameterSpecification_ParameterTypeWorkMasterTypeKey_ParameterTypeId",
                table: "WorkMasters_ParameterSpecification_Value");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkSchedules",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkSchedules",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkSchedules",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkSchedules",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkSchedules",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkSchedules",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkSchedules",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkSchedules",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkResponses",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkResponses",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkResponses",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkResponses",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkResponses",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkResponses",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkResponses",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkResponses",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkRequests",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkRequests",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkRequests",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkRequests",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkRequests",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkRequests",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkRequests",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkRequests",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkRecords",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkRecords",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkRecords",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkRecords",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkRecords",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkRecords",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkRecords",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkRecords",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkRecordEntries",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkRecordEntries",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkRecordEntries",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkRecordEntries",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkRecordEntries",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkRecordEntries",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkRecordEntries",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkRecordEntries",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkPerformances",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkPerformances",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkPerformances",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkPerformances",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkPerformances",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkPerformances",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkPerformances",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkPerformances",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "WorkMasters_ParameterSpecification_Value",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "WorkMasters_ParameterSpecification_ProcessSegmentParameterID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "WorkMasters_ParameterSpecification_ParameterSpecificationID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkMasters_ParameterSpecification",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkMasters_ParameterSpecification",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkMasters_ParameterSpecification",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkMasters_ParameterSpecification",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkMasters_ParameterSpecification",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkMasters_ParameterSpecification",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkMasters_ParameterSpecification",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkMasters_ParameterSpecification",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "WorkMasters_ParameterSpecification",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkMasters",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkMasters",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkMasters",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkMasters",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkMasters",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkMasters",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkMasters",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkMasters",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkMasterCapabilities",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkMasterCapabilities",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkMasterCapabilities",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkMasterCapabilities",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkMasterCapabilities",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkMasterCapabilities",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkMasterCapabilities",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkMasterCapabilities",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkflowSpecifications",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkflowSpecifications",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkflowSpecifications",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkflowSpecifications",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkflowSpecifications",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkflowSpecifications",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkflowSpecifications",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkflowSpecifications",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkflowSpecificationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkflowSpecificationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkflowSpecificationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkflowSpecificationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkflowSpecificationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkflowSpecificationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkflowSpecificationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkflowSpecificationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkflowSpecificationNodeProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkflowSpecificationNodeProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkflowSpecificationNodeProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkflowSpecificationNodeProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkflowSpecificationNodeProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkflowSpecificationNodeProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkflowSpecificationNodeProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkflowSpecificationNodeProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkflowSpecificationConnections",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkflowSpecificationConnections",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkflowSpecificationConnections",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkflowSpecificationConnections",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkflowSpecificationConnections",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkflowSpecificationConnections",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkflowSpecificationConnections",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkflowSpecificationConnections",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "WorkDirectives_ParameterSpecification_Value",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "WorkDirectives_ParameterSpecification_ProcessSegmentParameterID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "WorkDirectives_ParameterSpecification_ParameterSpecificationID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkDirectives_ParameterSpecification",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkDirectives_ParameterSpecification",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkDirectives_ParameterSpecification",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkDirectives_ParameterSpecification",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkDirectives_ParameterSpecification",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkDirectives_ParameterSpecification",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkDirectives_ParameterSpecification",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkDirectives_ParameterSpecification",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "WorkDirectives_ParameterSpecification",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkDirectives",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkDirectives",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkDirectives",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkDirectives",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkDirectives",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkDirectives",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkDirectives",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkDirectives",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkCapabilities",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkCapabilities",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkCapabilities",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkCapabilities",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkCapabilities",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkCapabilities",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkCapabilities",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkCapabilities",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkCalendars",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkCalendars",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkCalendars",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkCalendars",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkCalendars",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkCalendars",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkCalendars",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkCalendars",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkCalendarProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkCalendarProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkCalendarProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkCalendarProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkCalendarProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkCalendarProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkCalendarProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkCalendarProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkCalendarEntryProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkCalendarEntryProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkCalendarEntryProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkCalendarEntryProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkCalendarEntryProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkCalendarEntryProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkCalendarEntryProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkCalendarEntryProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkCalendarEntries",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkCalendarEntries",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkCalendarEntries",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkCalendarEntries",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkCalendarEntries",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkCalendarEntries",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkCalendarEntries",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkCalendarEntries",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkCalendarDefinitions",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkCalendarDefinitions",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkCalendarDefinitions",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkCalendarDefinitions",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkCalendarDefinitions",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkCalendarDefinitions",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkCalendarDefinitions",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkCalendarDefinitions",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkCalendarDefinitionProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkCalendarDefinitionProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkCalendarDefinitionProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkCalendarDefinitionProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkCalendarDefinitionProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkCalendarDefinitionProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkCalendarDefinitionProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkCalendarDefinitionProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkCalendarDefinitionEntries",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkCalendarDefinitionEntries",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkCalendarDefinitionEntries",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkCalendarDefinitionEntries",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkCalendarDefinitionEntries",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkCalendarDefinitionEntries",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkCalendarDefinitionEntries",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkCalendarDefinitionEntries",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkAlerts",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkAlerts",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkAlerts",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkAlerts",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkAlerts",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkAlerts",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkAlerts",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkAlerts",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkAlertProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkAlertProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkAlertProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkAlertProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkAlertProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkAlertProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkAlertProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkAlertProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkAlertDefinitions",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkAlertDefinitions",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkAlertDefinitions",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkAlertDefinitions",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkAlertDefinitions",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkAlertDefinitions",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkAlertDefinitions",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkAlertDefinitions",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "WorkAlertDefinitionProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "WorkAlertDefinitionProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "WorkAlertDefinitionProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "WorkAlertDefinitionProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "WorkAlertDefinitionProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "WorkAlertDefinitionProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "WorkAlertDefinitionProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "WorkAlertDefinitionProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "TestSpecifications",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "TestSpecifications",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "TestSpecifications",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "TestSpecifications",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "TestSpecifications",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "TestSpecifications",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "TestSpecifications",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "TestSpecifications",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "TestSpecificationResults",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "TestSpecificationResults",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "TestSpecificationResults",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "TestSpecificationResults",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "TestSpecificationResults",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "TestSpecificationResults",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "TestSpecificationResults",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "TestSpecificationResults",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "TestSpecificationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "TestSpecificationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "TestSpecificationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "TestSpecificationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "TestSpecificationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "TestSpecificationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "TestSpecificationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "TestSpecificationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "TestSpecificationEvaluatedProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "TestSpecificationEvaluatedProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "TestSpecificationEvaluatedProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "TestSpecificationEvaluatedProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "TestSpecificationEvaluatedProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "TestSpecificationEvaluatedProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "TestSpecificationEvaluatedProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "TestSpecificationEvaluatedProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "TestSpecificationCriterias",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "TestSpecificationCriterias",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "TestSpecificationCriterias",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "TestSpecificationCriterias",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "TestSpecificationCriterias",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "TestSpecificationCriterias",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "TestSpecificationCriterias",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "TestSpecificationCriterias",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "SpecificationNodeTypes",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "SpecificationNodeTypes",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "SpecificationNodeTypes",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "SpecificationNodeTypes",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "SpecificationNodeTypes",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "SpecificationNodeTypes",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "SpecificationNodeTypes",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "SpecificationNodeTypes",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "SpecificationNodes",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "SpecificationNodes",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "SpecificationNodes",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "SpecificationNodes",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "SpecificationNodes",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "SpecificationNodes",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "SpecificationNodes",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "SpecificationNodes",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "SegmentDependencies",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "SegmentDependencies",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "SegmentDependencies",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "SegmentDependencies",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "SegmentDependencies",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "SegmentDependencies",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "SegmentDependencies",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "SegmentDependencies",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "ResourceRelationshipNetworks",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "ResourceRelationshipNetworks",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "ResourceRelationshipNetworks",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "ResourceRelationshipNetworks",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "ResourceRelationshipNetworks",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "ResourceRelationshipNetworks",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "ResourceRelationshipNetworks",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "ResourceRelationshipNetworks",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "ResourceRelationshipNetworkProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "ResourceRelationshipNetworkProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "ResourceRelationshipNetworkProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "ResourceRelationshipNetworkProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "ResourceRelationshipNetworkProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "ResourceRelationshipNetworkProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "ResourceRelationshipNetworkProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "ResourceRelationshipNetworkProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "ResourceReferencesProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "ResourceReferencesProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "ResourceReferencesProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "ResourceReferencesProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "ResourceReferencesProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "ResourceReferencesProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "ResourceReferencesProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "ResourceReferencesProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "ResourceReferences",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "ResourceReferences",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "ResourceReferences",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "ResourceReferences",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "ResourceReferences",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "ResourceReferences",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "ResourceReferences",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "ResourceReferences",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "ResourceNetworkConnectionTypes",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "ResourceNetworkConnectionTypes",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "ResourceNetworkConnectionTypes",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "ResourceNetworkConnectionTypes",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "ResourceNetworkConnectionTypes",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "ResourceNetworkConnectionTypes",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "ResourceNetworkConnectionTypes",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "ResourceNetworkConnectionTypes",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "ResourceNetworkConnections",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "ResourceNetworkConnections",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "ResourceNetworkConnections",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "ResourceNetworkConnections",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "ResourceNetworkConnections",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "ResourceNetworkConnections",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "ResourceNetworkConnections",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "ResourceNetworkConnections",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "ResourceNetworkConnectionProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "ResourceNetworkConnectionProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "ResourceNetworkConnectionProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "ResourceNetworkConnectionProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "ResourceNetworkConnectionProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "ResourceNetworkConnectionProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "ResourceNetworkConnectionProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "ResourceNetworkConnectionProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "PropertyMeasurementTypeId",
                table: "PropertyMeasurementType_TestableObjectPropertyID",
                newName: "PropertyMeasurementTypeId1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PropertyMeasurementType",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PropertyMeasurementType",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PropertyMeasurementType",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PropertyMeasurementType",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PropertyMeasurementType",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PropertyMeasurementType",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PropertyMeasurementType",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PropertyMeasurementType",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PropertyMeasurementType",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "ProcessSegments_ProcessSegmentParameter_Value",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "ProcessSegments_ProcessSegmentParameter_ProcessSegmentParameterID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "ProcessSegments_ProcessSegmentParameter_ParameterSpecificationID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "ProcessSegments",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "ProcessSegments",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "ProcessSegments",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "ProcessSegments",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "ProcessSegments",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "ProcessSegments",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "ProcessSegments",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "ProcessSegments",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PhysicalAssets",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PhysicalAssets",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PhysicalAssets",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PhysicalAssets",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PhysicalAssets",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PhysicalAssets",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PhysicalAssets",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PhysicalAssets",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PhysicalAssetProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PhysicalAssetProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PhysicalAssetProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PhysicalAssetProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PhysicalAssetProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PhysicalAssetProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PhysicalAssetProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PhysicalAssetProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PhysicalAssetClassProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PhysicalAssetClassProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PhysicalAssetClassProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PhysicalAssetClassProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PhysicalAssetClassProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PhysicalAssetClassProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PhysicalAssetClassProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PhysicalAssetClassProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PhysicalAssetClasses",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PhysicalAssetClasses",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PhysicalAssetClasses",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PhysicalAssetClasses",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PhysicalAssetClasses",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PhysicalAssetClasses",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PhysicalAssetClasses",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PhysicalAssetClasses",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PersonnelSegmentSpecifications",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PersonnelSegmentSpecifications",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PersonnelSegmentSpecifications",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PersonnelSegmentSpecifications",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PersonnelSegmentSpecifications",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PersonnelSegmentSpecifications",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PersonnelSegmentSpecifications",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PersonnelSegmentSpecifications",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PersonnelClassProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PersonnelClassProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PersonnelClassProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PersonnelClassProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PersonnelClassProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PersonnelClassProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PersonnelClassProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PersonnelClassProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PersonnelClasses",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PersonnelClasses",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PersonnelClasses",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PersonnelClasses",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PersonnelClasses",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PersonnelClasses",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PersonnelClasses",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PersonnelClasses",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "PeoplesProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "PeoplesProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "PeoplesProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "PeoplesProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "PeoplesProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "PeoplesProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "PeoplesProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "PeoplesProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "Peoples",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "Peoples",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "Peoples",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "Peoples",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "Peoples",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "Peoples",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "Peoples",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "Peoples",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpSegmentResponses",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpSegmentResponses",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpSegmentResponses",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpSegmentResponses",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpSegmentResponses",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpSegmentResponses",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpSegmentResponses",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpSegmentResponses",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "OpSegmentRequirements_SegmentParameter_Value",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "OpSegmentRequirements_SegmentParameter_ProcessSegmentParameterID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "OpSegmentRequirements_SegmentParameter_ParameterSpecificationID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpSegmentRequirements",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpSegmentRequirements",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpSegmentRequirements",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpSegmentRequirements",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpSegmentRequirements",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpSegmentRequirements",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpSegmentRequirements",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpSegmentRequirements",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpSegmentDatas",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpSegmentDatas",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpSegmentDatas",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpSegmentDatas",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpSegmentDatas",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpSegmentDatas",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpSegmentDatas",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpSegmentDatas",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPhysicalAssetSpecifications",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPhysicalAssetSpecifications",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPhysicalAssetSpecifications",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPhysicalAssetSpecifications",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPhysicalAssetSpecifications",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPhysicalAssetSpecifications",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPhysicalAssetSpecifications",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPhysicalAssetSpecifications",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPhysicalAssetRequirements",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPhysicalAssetRequirements",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPhysicalAssetRequirements",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPhysicalAssetRequirements",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPhysicalAssetRequirements",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPhysicalAssetRequirements",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPhysicalAssetRequirements",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPhysicalAssetRequirements",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPhysicalAssetCapabilities",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPhysicalAssetCapabilities",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPhysicalAssetCapabilities",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPhysicalAssetCapabilities",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPhysicalAssetCapabilities",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPhysicalAssetCapabilities",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPhysicalAssetCapabilities",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPhysicalAssetCapabilities",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPhysicalAssetActuals",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPhysicalAssetActuals",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPhysicalAssetActuals",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPhysicalAssetActuals",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPhysicalAssetActuals",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPhysicalAssetActuals",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPhysicalAssetActuals",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPhysicalAssetActuals",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPhysicalAssetActualProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPhysicalAssetActualProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPhysicalAssetActualProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPhysicalAssetActualProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPhysicalAssetActualProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPhysicalAssetActualProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPhysicalAssetActualProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPhysicalAssetActualProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPersonnelSpecifications",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPersonnelSpecifications",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPersonnelSpecifications",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPersonnelSpecifications",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPersonnelSpecifications",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPersonnelSpecifications",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPersonnelSpecifications",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPersonnelSpecifications",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPersonnelSpecificationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPersonnelSpecificationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPersonnelSpecificationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPersonnelSpecificationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPersonnelSpecificationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPersonnelSpecificationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPersonnelSpecificationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPersonnelSpecificationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPersonnelRequirements",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPersonnelRequirements",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPersonnelRequirements",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPersonnelRequirements",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPersonnelRequirements",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPersonnelRequirements",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPersonnelRequirements",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPersonnelRequirements",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPersonnelRequirementProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPersonnelRequirementProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPersonnelRequirementProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPersonnelRequirementProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPersonnelRequirementProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPersonnelRequirementProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPersonnelRequirementProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPersonnelRequirementProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPersonnelCapabilityProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPersonnelCapabilityProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPersonnelCapabilityProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPersonnelCapabilityProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPersonnelCapabilityProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPersonnelCapabilityProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPersonnelCapabilityProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPersonnelCapabilityProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPersonnelCapabilities",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPersonnelCapabilities",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPersonnelCapabilities",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPersonnelCapabilities",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPersonnelCapabilities",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPersonnelCapabilities",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPersonnelCapabilities",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPersonnelCapabilities",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPersonnelActuals",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPersonnelActuals",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPersonnelActuals",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPersonnelActuals",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPersonnelActuals",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPersonnelActuals",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPersonnelActuals",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPersonnelActuals",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpPersonnelActualProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpPersonnelActualProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpPersonnelActualProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpPersonnelActualProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpPersonnelActualProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpPersonnelActualProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpPersonnelActualProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpPersonnelActualProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpOperationsSegmentCapabilities",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpOperationsSegmentCapabilities",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpOperationsSegmentCapabilities",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpOperationsSegmentCapabilities",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpOperationsSegmentCapabilities",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpOperationsSegmentCapabilities",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpOperationsSegmentCapabilities",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpOperationsSegmentCapabilities",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpMaterialSpecifications",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpMaterialSpecifications",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpMaterialSpecifications",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpMaterialSpecifications",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpMaterialSpecifications",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpMaterialSpecifications",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpMaterialSpecifications",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpMaterialSpecifications",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpMaterialSpecificationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpMaterialSpecificationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpMaterialSpecificationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpMaterialSpecificationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpMaterialSpecificationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpMaterialSpecificationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpMaterialSpecificationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpMaterialSpecificationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpMaterialRequirements",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpMaterialRequirements",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpMaterialRequirements",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpMaterialRequirements",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpMaterialRequirements",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpMaterialRequirements",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpMaterialRequirements",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpMaterialRequirements",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpMaterialRequirementProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpMaterialRequirementProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpMaterialRequirementProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpMaterialRequirementProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpMaterialRequirementProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpMaterialRequirementProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpMaterialRequirementProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpMaterialRequirementProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpMaterialCapabilityProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpMaterialCapabilityProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpMaterialCapabilityProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpMaterialCapabilityProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpMaterialCapabilityProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpMaterialCapabilityProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpMaterialCapabilityProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpMaterialCapabilityProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpMaterialCapabilities",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpMaterialCapabilities",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpMaterialCapabilities",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpMaterialCapabilities",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpMaterialCapabilities",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpMaterialCapabilities",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpMaterialCapabilities",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpMaterialCapabilities",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpMaterialActuals",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpMaterialActuals",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpMaterialActuals",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpMaterialActuals",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpMaterialActuals",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpMaterialActuals",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpMaterialActuals",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpMaterialActuals",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpMaterialActualProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpMaterialActualProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpMaterialActualProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpMaterialActualProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpMaterialActualProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpMaterialActualProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpMaterialActualProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpMaterialActualProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "OperationsSegments_ParameterSpecification_Value",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "OperationsSegments_ParameterSpecification_ProcessSegmentParameterID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "OperationsSegments_ParameterSpecification_ParameterSpecificationID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsSegments_ParameterSpecification",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsSegments_ParameterSpecification",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsSegments_ParameterSpecification",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsSegments_ParameterSpecification",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsSegments_ParameterSpecification",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsSegments_ParameterSpecification",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsSegments_ParameterSpecification",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsSegments_ParameterSpecification",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OperationsSegments_ParameterSpecification",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsSegments",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsSegments",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsSegments",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsSegments",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsSegments",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsSegments",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsSegments",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsSegments",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsSchedules",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsSchedules",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsSchedules",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsSchedules",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsSchedules",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsSchedules",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsSchedules",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsSchedules",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsResponses",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsResponses",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsResponses",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsResponses",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsResponses",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsResponses",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsResponses",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsResponses",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsRequests",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsRequests",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsRequests",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsRequests",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsRequests",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsRequests",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsRequests",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsRequests",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsRecordTemplateType",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsRecordTemplateType",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsRecordTemplateType",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsRecordTemplateType",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsRecordTemplateType",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsRecordTemplateType",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsRecordTemplateType",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsRecordTemplateType",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OperationsRecordTemplateType",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsRecordEntryTemplateType",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsRecordEntryTemplateType",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsRecordEntryTemplateType",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsRecordEntryTemplateType",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsRecordEntryTemplateType",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsRecordEntryTemplateType",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsRecordEntryTemplateType",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsRecordEntryTemplateType",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OperationsRecordEntryTemplateType",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordTemplateTypeId",
                table: "OperationsRecordEntryTemplateType",
                newName: "OperationsRecordTemplateTypeId1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsPerformances",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsPerformances",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsPerformances",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsPerformances",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsPerformances",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsPerformances",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsPerformances",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsPerformances",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsMaterialBills",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsMaterialBills",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsMaterialBills",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsMaterialBills",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsMaterialBills",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsMaterialBills",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsMaterialBills",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsMaterialBills",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsMaterialBillItems",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsMaterialBillItems",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsMaterialBillItems",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsMaterialBillItems",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsMaterialBillItems",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsMaterialBillItems",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsMaterialBillItems",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsMaterialBillItems",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsEvents",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsEvents",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsEvents",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsEvents",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsEvents",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsEvents",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsEvents",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsEvents",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification_InformationObjectTypeMultiplicity",
                newName: "OperationsRecordSpecTemplateTypeId1");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification_InformationObjectType",
                newName: "OperationsRecordSpecTemplateTypeId1");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification_ActionMultiplicity",
                newName: "OperationsRecordSpecTemplateTypeId1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsEventDefinitions",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsEventDefinitions",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsEventDefinitions",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsEventDefinitions",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsEventDefinitions",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsEventDefinitions",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsEventDefinitions",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsEventDefinitions",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsEventClassProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsEventClassProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsEventClassProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsEventClassProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsEventClassProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsEventClassProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsEventClassProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsEventClassProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification_InformationObjectTypeMultiplicity",
                newName: "OperationsRecordSpecTemplateTypeId1");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification_InformationObjectType",
                newName: "OperationsRecordSpecTemplateTypeId1");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification_ActionMultiplicity",
                newName: "OperationsRecordSpecTemplateTypeId1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsEventClasses",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsEventClasses",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsEventClasses",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsEventClasses",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsEventClasses",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsEventClasses",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsEventClasses",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsEventClasses",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsDefinitions",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsDefinitions",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsDefinitions",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsDefinitions",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsDefinitions",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsDefinitions",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsDefinitions",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsDefinitions",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationsCapabilities",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationsCapabilities",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationsCapabilities",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationsCapabilities",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationsCapabilities",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationsCapabilities",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationsCapabilities",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationsCapabilities",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationalLocations",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationalLocations",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationalLocations",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationalLocations",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationalLocations",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationalLocations",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationalLocations",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationalLocations",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationalLocationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationalLocationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationalLocationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationalLocationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationalLocationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationalLocationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationalLocationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationalLocationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationalLocationClassProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationalLocationClassProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationalLocationClassProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationalLocationClassProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationalLocationClassProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationalLocationClassProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationalLocationClassProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationalLocationClassProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OperationalLocationClasses",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OperationalLocationClasses",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OperationalLocationClasses",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OperationalLocationClasses",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OperationalLocationClasses",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OperationalLocationClasses",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OperationalLocationClasses",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OperationalLocationClasses",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpEquipmentSpecifications",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpEquipmentSpecifications",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpEquipmentSpecifications",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpEquipmentSpecifications",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpEquipmentSpecifications",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpEquipmentSpecifications",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpEquipmentSpecifications",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpEquipmentSpecifications",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpEquipmentSpecificationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpEquipmentSpecificationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpEquipmentSpecificationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpEquipmentSpecificationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpEquipmentSpecificationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpEquipmentSpecificationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpEquipmentSpecificationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpEquipmentSpecificationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpEquipmentRequirements",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpEquipmentRequirements",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpEquipmentRequirements",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpEquipmentRequirements",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpEquipmentRequirements",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpEquipmentRequirements",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpEquipmentRequirements",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpEquipmentRequirements",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpEquipmentRequirementProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpEquipmentRequirementProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpEquipmentRequirementProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpEquipmentRequirementProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpEquipmentRequirementProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpEquipmentRequirementProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpEquipmentRequirementProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpEquipmentRequirementProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpEquipmentCapabilityProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpEquipmentCapabilityProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpEquipmentCapabilityProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpEquipmentCapabilityProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpEquipmentCapabilityProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpEquipmentCapabilityProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpEquipmentCapabilityProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpEquipmentCapabilityProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpEquipmentCapabilities",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpEquipmentCapabilities",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpEquipmentCapabilities",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpEquipmentCapabilities",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpEquipmentCapabilities",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpEquipmentCapabilities",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpEquipmentCapabilities",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpEquipmentCapabilities",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpEquipmentActuals",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpEquipmentActuals",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpEquipmentActuals",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpEquipmentActuals",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpEquipmentActuals",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpEquipmentActuals",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpEquipmentActuals",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpEquipmentActuals",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "OpEquipmentActualProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "OpEquipmentActualProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "OpEquipmentActualProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "OpEquipmentActualProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "OpEquipmentActualProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "OpEquipmentActualProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "OpEquipmentActualProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "OpEquipmentActualProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "MaterialSubLots",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "MaterialSubLots",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "MaterialSubLots",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "MaterialSubLots",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "MaterialSubLots",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "MaterialSubLots",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "MaterialSubLots",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "MaterialSubLots",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "MaterialSegmentSpecifications",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "MaterialSegmentSpecifications",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "MaterialSegmentSpecifications",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "MaterialSegmentSpecifications",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "MaterialSegmentSpecifications",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "MaterialSegmentSpecifications",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "MaterialSegmentSpecifications",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "MaterialSegmentSpecifications",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "MaterialSegmentSpecificationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "MaterialSegmentSpecificationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "MaterialSegmentSpecificationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "MaterialSegmentSpecificationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "MaterialSegmentSpecificationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "MaterialSegmentSpecificationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "MaterialSegmentSpecificationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "MaterialSegmentSpecificationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "MaterialLots",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "MaterialLots",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "MaterialLots",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "MaterialLots",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "MaterialLots",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "MaterialLots",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "MaterialLots",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "MaterialLots",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "MaterialLotProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "MaterialLotProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "MaterialLotProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "MaterialLotProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "MaterialLotProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "MaterialLotProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "MaterialLotProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "MaterialLotProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "MaterialDefinitions",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "MaterialDefinitions",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "MaterialDefinitions",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "MaterialDefinitions",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "MaterialDefinitions",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "MaterialDefinitions",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "MaterialDefinitions",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "MaterialDefinitions",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "MaterialDefinitionProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "MaterialDefinitionProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "MaterialDefinitionProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "MaterialDefinitionProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "MaterialDefinitionProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "MaterialDefinitionProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "MaterialDefinitionProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "MaterialDefinitionProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "MaterialClassProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "MaterialClassProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "MaterialClassProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "MaterialClassProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "MaterialClassProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "MaterialClassProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "MaterialClassProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "MaterialClassProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "MaterialClasses",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "MaterialClasses",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "MaterialClasses",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "MaterialClasses",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "MaterialClasses",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "MaterialClasses",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "MaterialClasses",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "MaterialClasses",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "JobResponses",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "JobResponses",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "JobResponses",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "JobResponses",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "JobResponses",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "JobResponses",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "JobResponses",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "JobResponses",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "JobOrders_JobOrderParameter_Value",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "JobOrders_JobOrderParameter_ProcessSegmentParameterID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId",
                table: "JobOrders_JobOrderParameter_ParameterSpecificationID",
                newName: "ParameterTypeId1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "JobOrders_JobOrderParameter",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "JobOrders_JobOrderParameter",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "JobOrders_JobOrderParameter",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "JobOrders_JobOrderParameter",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "JobOrders_JobOrderParameter",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "JobOrders_JobOrderParameter",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "JobOrders_JobOrderParameter",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "JobOrders_JobOrderParameter",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "JobOrders_JobOrderParameter",
                newName: "Id1");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "JobOrders",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "JobOrders",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "JobOrders",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "JobOrders",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "JobOrders",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "JobOrders",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "JobOrders",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "JobOrders",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "JobLists",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "JobLists",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "JobLists",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "JobLists",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "JobLists",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "JobLists",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "JobLists",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "JobLists",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "EquipmentSegmentSpecifications",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "EquipmentSegmentSpecifications",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "EquipmentSegmentSpecifications",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "EquipmentSegmentSpecifications",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "EquipmentSegmentSpecifications",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "EquipmentSegmentSpecifications",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "EquipmentSegmentSpecifications",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "EquipmentSegmentSpecifications",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "Equipments",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "Equipments",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "Equipments",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "Equipments",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "Equipments",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "Equipments",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "Equipments",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "Equipments",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "EquipmentProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "EquipmentProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "EquipmentProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "EquipmentProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "EquipmentProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "EquipmentProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "EquipmentProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "EquipmentProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "EquipmentClassProperties",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "EquipmentClassProperties",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "EquipmentClassProperties",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "EquipmentClassProperties",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "EquipmentClassProperties",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "EquipmentClassProperties",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "EquipmentClassProperties",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "EquipmentClassProperties",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ID_Value",
                table: "EquipmentClasses",
                newName: "Id_Value");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeVersionID",
                table: "EquipmentClasses",
                newName: "Id_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeURI",
                table: "EquipmentClasses",
                newName: "Id_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeName",
                table: "EquipmentClasses",
                newName: "Id_SchemeName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeID",
                table: "EquipmentClasses",
                newName: "Id_SchemeID");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeDataURI",
                table: "EquipmentClasses",
                newName: "Id_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyName",
                table: "EquipmentClasses",
                newName: "Id_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "ID_SchemeAgencyID",
                table: "EquipmentClasses",
                newName: "Id_SchemeAgencyID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOrders_JobOrderParameter_ParameterSpecificationID_JobOrders_JobOrderParameter_ParameterTypeJobOrderTypeKey_ParameterTypeI~",
                table: "JobOrders_JobOrderParameter_ParameterSpecificationID",
                columns: new[] { "ParameterTypeJobOrderTypeKey", "ParameterTypeId1" },
                principalTable: "JobOrders_JobOrderParameter",
                principalColumns: new[] { "JobOrderTypeKey", "Id1" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobOrders_JobOrderParameter_Value_JobOrders_JobOrderParameter_ParameterTypeJobOrderTypeKey_ParameterTypeId1",
                table: "JobOrders_JobOrderParameter_Value",
                columns: new[] { "ParameterTypeJobOrderTypeKey", "ParameterTypeId1" },
                principalTable: "JobOrders_JobOrderParameter",
                principalColumns: new[] { "JobOrderTypeKey", "Id1" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkMasters_ParameterSpecification_Value_WorkMasters_ParameterSpecification_ParameterTypeWorkMasterTypeKey_ParameterTypeId1",
                table: "WorkMasters_ParameterSpecification_Value",
                columns: new[] { "ParameterTypeWorkMasterTypeKey", "ParameterTypeId1" },
                principalTable: "WorkMasters_ParameterSpecification",
                principalColumns: new[] { "WorkMasterTypeKey", "Id1" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOrders_JobOrderParameter_ParameterSpecificationID_JobOrders_JobOrderParameter_ParameterTypeJobOrderTypeKey_ParameterTypeI~",
                table: "JobOrders_JobOrderParameter_ParameterSpecificationID");

            migrationBuilder.DropForeignKey(
                name: "FK_JobOrders_JobOrderParameter_Value_JobOrders_JobOrderParameter_ParameterTypeJobOrderTypeKey_ParameterTypeId1",
                table: "JobOrders_JobOrderParameter_Value");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkMasters_ParameterSpecification_Value_WorkMasters_ParameterSpecification_ParameterTypeWorkMasterTypeKey_ParameterTypeId1",
                table: "WorkMasters_ParameterSpecification_Value");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkSchedules",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkSchedules",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkSchedules",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkSchedules",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkSchedules",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkSchedules",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkSchedules",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkSchedules",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkResponses",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkResponses",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkResponses",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkResponses",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkResponses",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkResponses",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkResponses",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkResponses",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkRequests",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkRequests",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkRequests",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkRequests",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkRequests",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkRequests",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkRequests",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkRequests",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkRecords",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkRecords",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkRecords",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkRecords",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkRecords",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkRecords",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkRecords",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkRecords",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkRecordEntries",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkRecordEntries",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkRecordEntries",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkRecordEntries",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkRecordEntries",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkRecordEntries",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkRecordEntries",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkRecordEntries",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkPerformances",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkPerformances",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkPerformances",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkPerformances",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkPerformances",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkPerformances",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkPerformances",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkPerformances",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "WorkMasters_ParameterSpecification_Value",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "WorkMasters_ParameterSpecification_ProcessSegmentParameterID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "WorkMasters_ParameterSpecification_ParameterSpecificationID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkMasters_ParameterSpecification",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkMasters_ParameterSpecification",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkMasters_ParameterSpecification",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkMasters_ParameterSpecification",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkMasters_ParameterSpecification",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkMasters_ParameterSpecification",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkMasters_ParameterSpecification",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkMasters_ParameterSpecification",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "WorkMasters_ParameterSpecification",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkMasters",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkMasters",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkMasters",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkMasters",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkMasters",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkMasters",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkMasters",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkMasters",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkMasterCapabilities",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkMasterCapabilities",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkMasterCapabilities",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkMasterCapabilities",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkMasterCapabilities",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkMasterCapabilities",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkMasterCapabilities",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkMasterCapabilities",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkflowSpecifications",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkflowSpecifications",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkflowSpecifications",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkflowSpecifications",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkflowSpecifications",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkflowSpecifications",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkflowSpecifications",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkflowSpecifications",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkflowSpecificationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkflowSpecificationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkflowSpecificationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkflowSpecificationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkflowSpecificationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkflowSpecificationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkflowSpecificationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkflowSpecificationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkflowSpecificationNodeTypeProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkflowSpecificationNodeProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkflowSpecificationNodeProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkflowSpecificationNodeProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkflowSpecificationNodeProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkflowSpecificationNodeProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkflowSpecificationNodeProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkflowSpecificationNodeProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkflowSpecificationNodeProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkflowSpecificationConnectionTypes",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkflowSpecificationConnectionTypeProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkflowSpecificationConnections",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkflowSpecificationConnections",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkflowSpecificationConnections",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkflowSpecificationConnections",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkflowSpecificationConnections",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkflowSpecificationConnections",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkflowSpecificationConnections",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkflowSpecificationConnections",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkflowSpecificationConnectionProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "WorkDirectives_ParameterSpecification_Value",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "WorkDirectives_ParameterSpecification_ProcessSegmentParameterID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "WorkDirectives_ParameterSpecification_ParameterSpecificationID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkDirectives_ParameterSpecification",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkDirectives_ParameterSpecification",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkDirectives_ParameterSpecification",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkDirectives_ParameterSpecification",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkDirectives_ParameterSpecification",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkDirectives_ParameterSpecification",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkDirectives_ParameterSpecification",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkDirectives_ParameterSpecification",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "WorkDirectives_ParameterSpecification",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkDirectives",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkDirectives",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkDirectives",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkDirectives",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkDirectives",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkDirectives",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkDirectives",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkDirectives",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkCapabilities",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkCapabilities",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkCapabilities",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkCapabilities",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkCapabilities",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkCapabilities",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkCapabilities",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkCapabilities",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkCalendars",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkCalendars",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkCalendars",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkCalendars",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkCalendars",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkCalendars",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkCalendars",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkCalendars",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkCalendarProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkCalendarProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkCalendarProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkCalendarProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkCalendarProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkCalendarProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkCalendarProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkCalendarProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkCalendarEntryProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkCalendarEntryProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkCalendarEntryProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkCalendarEntryProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkCalendarEntryProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkCalendarEntryProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkCalendarEntryProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkCalendarEntryProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkCalendarEntries",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkCalendarEntries",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkCalendarEntries",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkCalendarEntries",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkCalendarEntries",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkCalendarEntries",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkCalendarEntries",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkCalendarEntries",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkCalendarDefinitions",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkCalendarDefinitions",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkCalendarDefinitions",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkCalendarDefinitions",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkCalendarDefinitions",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkCalendarDefinitions",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkCalendarDefinitions",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkCalendarDefinitions",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkCalendarDefinitionProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkCalendarDefinitionProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkCalendarDefinitionProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkCalendarDefinitionProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkCalendarDefinitionProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkCalendarDefinitionProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkCalendarDefinitionProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkCalendarDefinitionProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkCalendarDefinitionEntryProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkCalendarDefinitionEntries",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkCalendarDefinitionEntries",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkCalendarDefinitionEntries",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkCalendarDefinitionEntries",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkCalendarDefinitionEntries",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkCalendarDefinitionEntries",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkCalendarDefinitionEntries",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkCalendarDefinitionEntries",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkAlerts",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkAlerts",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkAlerts",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkAlerts",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkAlerts",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkAlerts",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkAlerts",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkAlerts",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkAlertProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkAlertProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkAlertProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkAlertProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkAlertProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkAlertProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkAlertProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkAlertProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkAlertDefinitions",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkAlertDefinitions",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkAlertDefinitions",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkAlertDefinitions",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkAlertDefinitions",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkAlertDefinitions",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkAlertDefinitions",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkAlertDefinitions",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "WorkAlertDefinitionProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "WorkAlertDefinitionProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "WorkAlertDefinitionProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "WorkAlertDefinitionProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "WorkAlertDefinitionProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "WorkAlertDefinitionProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "WorkAlertDefinitionProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "WorkAlertDefinitionProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "TestSpecifications",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "TestSpecifications",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "TestSpecifications",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "TestSpecifications",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "TestSpecifications",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "TestSpecifications",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "TestSpecifications",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "TestSpecifications",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "TestSpecificationResults",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "TestSpecificationResults",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "TestSpecificationResults",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "TestSpecificationResults",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "TestSpecificationResults",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "TestSpecificationResults",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "TestSpecificationResults",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "TestSpecificationResults",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "TestSpecificationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "TestSpecificationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "TestSpecificationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "TestSpecificationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "TestSpecificationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "TestSpecificationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "TestSpecificationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "TestSpecificationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "TestSpecificationEvaluatedProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "TestSpecificationEvaluatedProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "TestSpecificationEvaluatedProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "TestSpecificationEvaluatedProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "TestSpecificationEvaluatedProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "TestSpecificationEvaluatedProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "TestSpecificationEvaluatedProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "TestSpecificationEvaluatedProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "TestSpecificationCriterias",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "TestSpecificationCriterias",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "TestSpecificationCriterias",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "TestSpecificationCriterias",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "TestSpecificationCriterias",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "TestSpecificationCriterias",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "TestSpecificationCriterias",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "TestSpecificationCriterias",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "SpecificationNodeTypes",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "SpecificationNodeTypes",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "SpecificationNodeTypes",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "SpecificationNodeTypes",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "SpecificationNodeTypes",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "SpecificationNodeTypes",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "SpecificationNodeTypes",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "SpecificationNodeTypes",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "SpecificationNodes",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "SpecificationNodes",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "SpecificationNodes",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "SpecificationNodes",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "SpecificationNodes",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "SpecificationNodes",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "SpecificationNodes",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "SpecificationNodes",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "SegmentDependencies",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "SegmentDependencies",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "SegmentDependencies",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "SegmentDependencies",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "SegmentDependencies",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "SegmentDependencies",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "SegmentDependencies",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "SegmentDependencies",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "ResourceRelationshipNetworks",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "ResourceRelationshipNetworks",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "ResourceRelationshipNetworks",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "ResourceRelationshipNetworks",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "ResourceRelationshipNetworks",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "ResourceRelationshipNetworks",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "ResourceRelationshipNetworks",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "ResourceRelationshipNetworks",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "ResourceRelationshipNetworkProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "ResourceRelationshipNetworkProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "ResourceRelationshipNetworkProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "ResourceRelationshipNetworkProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "ResourceRelationshipNetworkProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "ResourceRelationshipNetworkProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "ResourceRelationshipNetworkProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "ResourceRelationshipNetworkProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "ResourceReferencesProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "ResourceReferencesProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "ResourceReferencesProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "ResourceReferencesProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "ResourceReferencesProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "ResourceReferencesProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "ResourceReferencesProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "ResourceReferencesProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "ResourceReferences",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "ResourceReferences",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "ResourceReferences",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "ResourceReferences",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "ResourceReferences",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "ResourceReferences",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "ResourceReferences",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "ResourceReferences",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "ResourceNetworkConnectionTypes",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "ResourceNetworkConnectionTypes",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "ResourceNetworkConnectionTypes",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "ResourceNetworkConnectionTypes",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "ResourceNetworkConnectionTypes",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "ResourceNetworkConnectionTypes",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "ResourceNetworkConnectionTypes",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "ResourceNetworkConnectionTypes",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "ResourceNetworkConnectionTypeProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "ResourceNetworkConnections",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "ResourceNetworkConnections",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "ResourceNetworkConnections",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "ResourceNetworkConnections",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "ResourceNetworkConnections",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "ResourceNetworkConnections",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "ResourceNetworkConnections",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "ResourceNetworkConnections",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "ResourceNetworkConnectionProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "ResourceNetworkConnectionProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "ResourceNetworkConnectionProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "ResourceNetworkConnectionProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "ResourceNetworkConnectionProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "ResourceNetworkConnectionProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "ResourceNetworkConnectionProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "ResourceNetworkConnectionProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "PropertyMeasurementTypeId1",
                table: "PropertyMeasurementType_TestableObjectPropertyID",
                newName: "PropertyMeasurementTypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PropertyMeasurementType",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PropertyMeasurementType",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PropertyMeasurementType",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PropertyMeasurementType",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PropertyMeasurementType",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PropertyMeasurementType",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PropertyMeasurementType",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PropertyMeasurementType",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "PropertyMeasurementType",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "ProcessSegments_ProcessSegmentParameter_Value",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "ProcessSegments_ProcessSegmentParameter_ProcessSegmentParameterID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "ProcessSegments_ProcessSegmentParameter_ParameterSpecificationID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "ProcessSegments_ProcessSegmentParameter",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "ProcessSegments",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "ProcessSegments",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "ProcessSegments",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "ProcessSegments",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "ProcessSegments",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "ProcessSegments",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "ProcessSegments",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "ProcessSegments",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PhysicalAssetSegmentSpecifications",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PhysicalAssetSegmentSpecificationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PhysicalAssets",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PhysicalAssets",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PhysicalAssets",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PhysicalAssets",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PhysicalAssets",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PhysicalAssets",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PhysicalAssets",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PhysicalAssets",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PhysicalAssetProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PhysicalAssetProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PhysicalAssetProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PhysicalAssetProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PhysicalAssetProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PhysicalAssetProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PhysicalAssetProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PhysicalAssetProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PhysicalAssetClassProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PhysicalAssetClassProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PhysicalAssetClassProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PhysicalAssetClassProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PhysicalAssetClassProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PhysicalAssetClassProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PhysicalAssetClassProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PhysicalAssetClassProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PhysicalAssetClasses",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PhysicalAssetClasses",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PhysicalAssetClasses",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PhysicalAssetClasses",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PhysicalAssetClasses",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PhysicalAssetClasses",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PhysicalAssetClasses",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PhysicalAssetClasses",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PersonnelSegmentSpecifications",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PersonnelSegmentSpecifications",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PersonnelSegmentSpecifications",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PersonnelSegmentSpecifications",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PersonnelSegmentSpecifications",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PersonnelSegmentSpecifications",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PersonnelSegmentSpecifications",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PersonnelSegmentSpecifications",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PersonnelSegmentSpecificationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PersonnelClassProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PersonnelClassProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PersonnelClassProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PersonnelClassProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PersonnelClassProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PersonnelClassProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PersonnelClassProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PersonnelClassProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PersonnelClasses",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PersonnelClasses",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PersonnelClasses",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PersonnelClasses",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PersonnelClasses",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PersonnelClasses",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PersonnelClasses",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PersonnelClasses",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "PeoplesProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "PeoplesProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "PeoplesProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "PeoplesProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "PeoplesProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "PeoplesProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "PeoplesProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "PeoplesProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "Peoples",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "Peoples",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "Peoples",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "Peoples",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "Peoples",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "Peoples",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "Peoples",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "Peoples",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpSegmentResponses",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpSegmentResponses",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpSegmentResponses",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpSegmentResponses",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpSegmentResponses",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpSegmentResponses",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpSegmentResponses",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpSegmentResponses",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "OpSegmentRequirements_SegmentParameter_Value",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "OpSegmentRequirements_SegmentParameter_ProcessSegmentParameterID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "OpSegmentRequirements_SegmentParameter_ParameterSpecificationID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "OpSegmentRequirements_SegmentParameter",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpSegmentRequirements",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpSegmentRequirements",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpSegmentRequirements",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpSegmentRequirements",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpSegmentRequirements",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpSegmentRequirements",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpSegmentRequirements",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpSegmentRequirements",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpSegmentDatas",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpSegmentDatas",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpSegmentDatas",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpSegmentDatas",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpSegmentDatas",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpSegmentDatas",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpSegmentDatas",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpSegmentDatas",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpProcessSegmentCapabilityProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPhysicalAssetSpecifications",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPhysicalAssetSpecifications",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPhysicalAssetSpecifications",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPhysicalAssetSpecifications",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPhysicalAssetSpecifications",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPhysicalAssetSpecifications",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPhysicalAssetSpecifications",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPhysicalAssetSpecifications",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPhysicalAssetSpecificationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPhysicalAssetRequirements",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPhysicalAssetRequirements",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPhysicalAssetRequirements",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPhysicalAssetRequirements",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPhysicalAssetRequirements",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPhysicalAssetRequirements",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPhysicalAssetRequirements",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPhysicalAssetRequirements",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPhysicalAssetRequirementProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPhysicalAssetCapabilityProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPhysicalAssetCapabilities",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPhysicalAssetCapabilities",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPhysicalAssetCapabilities",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPhysicalAssetCapabilities",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPhysicalAssetCapabilities",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPhysicalAssetCapabilities",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPhysicalAssetCapabilities",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPhysicalAssetCapabilities",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPhysicalAssetActuals",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPhysicalAssetActuals",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPhysicalAssetActuals",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPhysicalAssetActuals",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPhysicalAssetActuals",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPhysicalAssetActuals",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPhysicalAssetActuals",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPhysicalAssetActuals",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPhysicalAssetActualProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPhysicalAssetActualProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPhysicalAssetActualProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPhysicalAssetActualProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPhysicalAssetActualProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPhysicalAssetActualProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPhysicalAssetActualProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPhysicalAssetActualProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPersonnelSpecifications",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPersonnelSpecifications",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPersonnelSpecifications",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPersonnelSpecifications",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPersonnelSpecifications",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPersonnelSpecifications",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPersonnelSpecifications",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPersonnelSpecifications",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPersonnelSpecificationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPersonnelSpecificationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPersonnelSpecificationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPersonnelSpecificationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPersonnelSpecificationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPersonnelSpecificationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPersonnelSpecificationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPersonnelSpecificationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPersonnelRequirements",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPersonnelRequirements",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPersonnelRequirements",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPersonnelRequirements",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPersonnelRequirements",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPersonnelRequirements",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPersonnelRequirements",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPersonnelRequirements",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPersonnelRequirementProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPersonnelRequirementProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPersonnelRequirementProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPersonnelRequirementProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPersonnelRequirementProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPersonnelRequirementProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPersonnelRequirementProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPersonnelRequirementProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPersonnelCapabilityProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPersonnelCapabilityProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPersonnelCapabilityProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPersonnelCapabilityProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPersonnelCapabilityProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPersonnelCapabilityProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPersonnelCapabilityProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPersonnelCapabilityProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPersonnelCapabilities",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPersonnelCapabilities",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPersonnelCapabilities",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPersonnelCapabilities",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPersonnelCapabilities",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPersonnelCapabilities",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPersonnelCapabilities",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPersonnelCapabilities",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPersonnelActuals",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPersonnelActuals",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPersonnelActuals",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPersonnelActuals",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPersonnelActuals",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPersonnelActuals",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPersonnelActuals",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPersonnelActuals",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpPersonnelActualProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpPersonnelActualProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpPersonnelActualProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpPersonnelActualProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpPersonnelActualProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpPersonnelActualProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpPersonnelActualProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpPersonnelActualProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpOperationsSegmentCapabilities",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpOperationsSegmentCapabilities",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpOperationsSegmentCapabilities",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpOperationsSegmentCapabilities",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpOperationsSegmentCapabilities",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpOperationsSegmentCapabilities",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpOperationsSegmentCapabilities",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpOperationsSegmentCapabilities",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpMaterialSpecifications",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpMaterialSpecifications",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpMaterialSpecifications",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpMaterialSpecifications",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpMaterialSpecifications",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpMaterialSpecifications",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpMaterialSpecifications",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpMaterialSpecifications",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpMaterialSpecificationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpMaterialSpecificationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpMaterialSpecificationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpMaterialSpecificationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpMaterialSpecificationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpMaterialSpecificationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpMaterialSpecificationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpMaterialSpecificationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpMaterialRequirements",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpMaterialRequirements",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpMaterialRequirements",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpMaterialRequirements",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpMaterialRequirements",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpMaterialRequirements",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpMaterialRequirements",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpMaterialRequirements",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpMaterialRequirementProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpMaterialRequirementProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpMaterialRequirementProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpMaterialRequirementProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpMaterialRequirementProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpMaterialRequirementProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpMaterialRequirementProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpMaterialRequirementProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpMaterialCapabilityProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpMaterialCapabilityProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpMaterialCapabilityProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpMaterialCapabilityProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpMaterialCapabilityProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpMaterialCapabilityProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpMaterialCapabilityProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpMaterialCapabilityProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpMaterialCapabilities",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpMaterialCapabilities",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpMaterialCapabilities",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpMaterialCapabilities",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpMaterialCapabilities",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpMaterialCapabilities",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpMaterialCapabilities",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpMaterialCapabilities",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpMaterialActuals",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpMaterialActuals",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpMaterialActuals",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpMaterialActuals",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpMaterialActuals",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpMaterialActuals",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpMaterialActuals",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpMaterialActuals",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpMaterialActualProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpMaterialActualProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpMaterialActualProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpMaterialActualProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpMaterialActualProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpMaterialActualProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpMaterialActualProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpMaterialActualProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "OperationsSegments_ParameterSpecification_Value",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "OperationsSegments_ParameterSpecification_ProcessSegmentParameterID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "OperationsSegments_ParameterSpecification_ParameterSpecificationID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsSegments_ParameterSpecification",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsSegments_ParameterSpecification",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsSegments_ParameterSpecification",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsSegments_ParameterSpecification",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsSegments_ParameterSpecification",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsSegments_ParameterSpecification",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsSegments_ParameterSpecification",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsSegments_ParameterSpecification",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "OperationsSegments_ParameterSpecification",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsSegments",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsSegments",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsSegments",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsSegments",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsSegments",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsSegments",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsSegments",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsSegments",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsSchedules",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsSchedules",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsSchedules",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsSchedules",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsSchedules",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsSchedules",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsSchedules",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsSchedules",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsResponses",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsResponses",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsResponses",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsResponses",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsResponses",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsResponses",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsResponses",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsResponses",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsRequests",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsRequests",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsRequests",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsRequests",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsRequests",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsRequests",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsRequests",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsRequests",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsRecordTemplateType",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsRecordTemplateType",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsRecordTemplateType",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsRecordTemplateType",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsRecordTemplateType",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsRecordTemplateType",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsRecordTemplateType",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsRecordTemplateType",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "OperationsRecordTemplateType",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsRecordEntryTemplateType",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsRecordEntryTemplateType",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsRecordEntryTemplateType",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsRecordEntryTemplateType",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsRecordEntryTemplateType",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsRecordEntryTemplateType",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsRecordEntryTemplateType",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsRecordEntryTemplateType",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "OperationsRecordEntryTemplateType",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordTemplateTypeId1",
                table: "OperationsRecordEntryTemplateType",
                newName: "OperationsRecordTemplateTypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsPerformances",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsPerformances",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsPerformances",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsPerformances",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsPerformances",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsPerformances",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsPerformances",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsPerformances",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsMaterialBills",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsMaterialBills",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsMaterialBills",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsMaterialBills",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsMaterialBills",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsMaterialBills",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsMaterialBills",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsMaterialBills",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsMaterialBillItems",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsMaterialBillItems",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsMaterialBillItems",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsMaterialBillItems",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsMaterialBillItems",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsMaterialBillItems",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsMaterialBillItems",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsMaterialBillItems",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsEvents",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsEvents",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsEvents",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsEvents",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsEvents",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsEvents",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsEvents",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsEvents",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId1",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification_InformationObjectTypeMultiplicity",
                newName: "OperationsRecordSpecTemplateTypeId");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId1",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification_InformationObjectType",
                newName: "OperationsRecordSpecTemplateTypeId");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId1",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification_ActionMultiplicity",
                newName: "OperationsRecordSpecTemplateTypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "OperationsEventDefinitions_OpsEventDefinitionRecordSpecification",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsEventDefinitions",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsEventDefinitions",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsEventDefinitions",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsEventDefinitions",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsEventDefinitions",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsEventDefinitions",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsEventDefinitions",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsEventDefinitions",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsEventClassProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsEventClassProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsEventClassProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsEventClassProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsEventClassProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsEventClassProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsEventClassProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsEventClassProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId1",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification_InformationObjectTypeMultiplicity",
                newName: "OperationsRecordSpecTemplateTypeId");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId1",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification_InformationObjectType",
                newName: "OperationsRecordSpecTemplateTypeId");

            migrationBuilder.RenameColumn(
                name: "OperationsRecordSpecTemplateTypeId1",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification_ActionMultiplicity",
                newName: "OperationsRecordSpecTemplateTypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "OperationsEventClasses_OpsEventClassRecordSpecification",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsEventClasses",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsEventClasses",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsEventClasses",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsEventClasses",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsEventClasses",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsEventClasses",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsEventClasses",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsEventClasses",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsDefinitions",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsDefinitions",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsDefinitions",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsDefinitions",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsDefinitions",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsDefinitions",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsDefinitions",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsDefinitions",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationsCapabilities",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationsCapabilities",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationsCapabilities",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationsCapabilities",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationsCapabilities",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationsCapabilities",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationsCapabilities",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationsCapabilities",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationalLocations",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationalLocations",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationalLocations",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationalLocations",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationalLocations",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationalLocations",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationalLocations",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationalLocations",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationalLocationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationalLocationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationalLocationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationalLocationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationalLocationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationalLocationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationalLocationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationalLocationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationalLocationClassProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationalLocationClassProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationalLocationClassProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationalLocationClassProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationalLocationClassProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationalLocationClassProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationalLocationClassProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationalLocationClassProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OperationalLocationClasses",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OperationalLocationClasses",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OperationalLocationClasses",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OperationalLocationClasses",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OperationalLocationClasses",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OperationalLocationClasses",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OperationalLocationClasses",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OperationalLocationClasses",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpEquipmentSpecifications",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpEquipmentSpecifications",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpEquipmentSpecifications",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpEquipmentSpecifications",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpEquipmentSpecifications",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpEquipmentSpecifications",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpEquipmentSpecifications",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpEquipmentSpecifications",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpEquipmentSpecificationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpEquipmentSpecificationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpEquipmentSpecificationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpEquipmentSpecificationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpEquipmentSpecificationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpEquipmentSpecificationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpEquipmentSpecificationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpEquipmentSpecificationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpEquipmentRequirements",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpEquipmentRequirements",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpEquipmentRequirements",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpEquipmentRequirements",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpEquipmentRequirements",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpEquipmentRequirements",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpEquipmentRequirements",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpEquipmentRequirements",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpEquipmentRequirementProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpEquipmentRequirementProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpEquipmentRequirementProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpEquipmentRequirementProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpEquipmentRequirementProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpEquipmentRequirementProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpEquipmentRequirementProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpEquipmentRequirementProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpEquipmentCapabilityProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpEquipmentCapabilityProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpEquipmentCapabilityProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpEquipmentCapabilityProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpEquipmentCapabilityProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpEquipmentCapabilityProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpEquipmentCapabilityProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpEquipmentCapabilityProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpEquipmentCapabilities",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpEquipmentCapabilities",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpEquipmentCapabilities",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpEquipmentCapabilities",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpEquipmentCapabilities",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpEquipmentCapabilities",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpEquipmentCapabilities",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpEquipmentCapabilities",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpEquipmentActuals",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpEquipmentActuals",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpEquipmentActuals",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpEquipmentActuals",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpEquipmentActuals",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpEquipmentActuals",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpEquipmentActuals",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpEquipmentActuals",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "OpEquipmentActualProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "OpEquipmentActualProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "OpEquipmentActualProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "OpEquipmentActualProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "OpEquipmentActualProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "OpEquipmentActualProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "OpEquipmentActualProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "OpEquipmentActualProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "MaterialSubLots",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "MaterialSubLots",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "MaterialSubLots",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "MaterialSubLots",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "MaterialSubLots",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "MaterialSubLots",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "MaterialSubLots",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "MaterialSubLots",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "MaterialSegmentSpecifications",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "MaterialSegmentSpecifications",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "MaterialSegmentSpecifications",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "MaterialSegmentSpecifications",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "MaterialSegmentSpecifications",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "MaterialSegmentSpecifications",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "MaterialSegmentSpecifications",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "MaterialSegmentSpecifications",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "MaterialSegmentSpecificationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "MaterialSegmentSpecificationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "MaterialSegmentSpecificationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "MaterialSegmentSpecificationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "MaterialSegmentSpecificationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "MaterialSegmentSpecificationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "MaterialSegmentSpecificationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "MaterialSegmentSpecificationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "MaterialLots",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "MaterialLots",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "MaterialLots",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "MaterialLots",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "MaterialLots",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "MaterialLots",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "MaterialLots",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "MaterialLots",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "MaterialLotProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "MaterialLotProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "MaterialLotProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "MaterialLotProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "MaterialLotProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "MaterialLotProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "MaterialLotProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "MaterialLotProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "MaterialDefinitions",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "MaterialDefinitions",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "MaterialDefinitions",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "MaterialDefinitions",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "MaterialDefinitions",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "MaterialDefinitions",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "MaterialDefinitions",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "MaterialDefinitions",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "MaterialDefinitionProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "MaterialDefinitionProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "MaterialDefinitionProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "MaterialDefinitionProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "MaterialDefinitionProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "MaterialDefinitionProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "MaterialDefinitionProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "MaterialDefinitionProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "MaterialClassProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "MaterialClassProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "MaterialClassProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "MaterialClassProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "MaterialClassProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "MaterialClassProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "MaterialClassProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "MaterialClassProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "MaterialClasses",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "MaterialClasses",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "MaterialClasses",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "MaterialClasses",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "MaterialClasses",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "MaterialClasses",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "MaterialClasses",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "MaterialClasses",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "JobResponses",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "JobResponses",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "JobResponses",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "JobResponses",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "JobResponses",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "JobResponses",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "JobResponses",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "JobResponses",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "JobOrders_JobOrderParameter_Value",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "JobOrders_JobOrderParameter_ProcessSegmentParameterID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "ParameterTypeId1",
                table: "JobOrders_JobOrderParameter_ParameterSpecificationID",
                newName: "ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "JobOrders_JobOrderParameter",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "JobOrders_JobOrderParameter",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "JobOrders_JobOrderParameter",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "JobOrders_JobOrderParameter",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "JobOrders_JobOrderParameter",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "JobOrders_JobOrderParameter",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "JobOrders_JobOrderParameter",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "JobOrders_JobOrderParameter",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "JobOrders_JobOrderParameter",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "JobOrders",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "JobOrders",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "JobOrders",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "JobOrders",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "JobOrders",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "JobOrders",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "JobOrders",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "JobOrders",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "JobLists",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "JobLists",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "JobLists",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "JobLists",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "JobLists",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "JobLists",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "JobLists",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "JobLists",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "EquipmentSegmentSpecifications",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "EquipmentSegmentSpecifications",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "EquipmentSegmentSpecifications",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "EquipmentSegmentSpecifications",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "EquipmentSegmentSpecifications",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "EquipmentSegmentSpecifications",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "EquipmentSegmentSpecifications",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "EquipmentSegmentSpecifications",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "EquipmentSegmentSpecificationProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "Equipments",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "Equipments",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "Equipments",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "Equipments",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "Equipments",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "Equipments",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "Equipments",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "Equipments",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "EquipmentProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "EquipmentProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "EquipmentProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "EquipmentProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "EquipmentProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "EquipmentProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "EquipmentProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "EquipmentProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "EquipmentClassProperties",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "EquipmentClassProperties",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "EquipmentClassProperties",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "EquipmentClassProperties",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "EquipmentClassProperties",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "EquipmentClassProperties",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "EquipmentClassProperties",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "EquipmentClassProperties",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.RenameColumn(
                name: "Id_Value",
                table: "EquipmentClasses",
                newName: "ID_Value");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeVersionID",
                table: "EquipmentClasses",
                newName: "ID_SchemeVersionID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeURI",
                table: "EquipmentClasses",
                newName: "ID_SchemeURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeName",
                table: "EquipmentClasses",
                newName: "ID_SchemeName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeID",
                table: "EquipmentClasses",
                newName: "ID_SchemeID");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeDataURI",
                table: "EquipmentClasses",
                newName: "ID_SchemeDataURI");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyName",
                table: "EquipmentClasses",
                newName: "ID_SchemeAgencyName");

            migrationBuilder.RenameColumn(
                name: "Id_SchemeAgencyID",
                table: "EquipmentClasses",
                newName: "ID_SchemeAgencyID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOrders_JobOrderParameter_ParameterSpecificationID_JobOrders_JobOrderParameter_ParameterTypeJobOrderTypeKey_ParameterTypeId",
                table: "JobOrders_JobOrderParameter_ParameterSpecificationID",
                columns: new[] { "ParameterTypeJobOrderTypeKey", "ParameterTypeId" },
                principalTable: "JobOrders_JobOrderParameter",
                principalColumns: new[] { "JobOrderTypeKey", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobOrders_JobOrderParameter_Value_JobOrders_JobOrderParameter_ParameterTypeJobOrderTypeKey_ParameterTypeId",
                table: "JobOrders_JobOrderParameter_Value",
                columns: new[] { "ParameterTypeJobOrderTypeKey", "ParameterTypeId" },
                principalTable: "JobOrders_JobOrderParameter",
                principalColumns: new[] { "JobOrderTypeKey", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkMasters_ParameterSpecification_Value_WorkMasters_ParameterSpecification_ParameterTypeWorkMasterTypeKey_ParameterTypeId",
                table: "WorkMasters_ParameterSpecification_Value",
                columns: new[] { "ParameterTypeWorkMasterTypeKey", "ParameterTypeId" },
                principalTable: "WorkMasters_ParameterSpecification",
                principalColumns: new[] { "WorkMasterTypeKey", "Id" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
