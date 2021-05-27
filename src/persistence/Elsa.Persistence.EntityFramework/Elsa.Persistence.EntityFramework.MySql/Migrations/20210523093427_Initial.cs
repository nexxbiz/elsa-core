﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Elsa.Persistence.EntityFramework.MySql.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Elsa");

            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bookmarks",
                schema: "Elsa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hash = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Model = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModelType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActivityType = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActivityId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkflowInstanceId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CorrelationId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookmarks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkflowDefinitions",
                schema: "Elsa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefinitionId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Version = table.Column<int>(type: "int", nullable: false),
                    IsSingleton = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PersistenceBehavior = table.Column<int>(type: "int", nullable: false),
                    DeleteCompletedInstances = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsPublished = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsLatest = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Tag = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowDefinitions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkflowExecutionLogRecords",
                schema: "Elsa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkflowInstanceId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActivityId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActivityType = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Timestamp = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    EventName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Source = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowExecutionLogRecords", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkflowInstances",
                schema: "Elsa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefinitionId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Version = table.Column<int>(type: "int", nullable: false),
                    WorkflowStatus = table.Column<int>(type: "int", nullable: false),
                    CorrelationId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContextType = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContextId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    LastExecutedAt = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    FinishedAt = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    CancelledAt = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    FaultedAt = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Data = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowInstances", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmark_ActivityId",
                schema: "Elsa",
                table: "Bookmarks",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmark_ActivityType",
                schema: "Elsa",
                table: "Bookmarks",
                column: "ActivityType");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmark_ActivityType_TenantId_Hash",
                schema: "Elsa",
                table: "Bookmarks",
                columns: new[] { "ActivityType", "TenantId", "Hash" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookmark_CorrelationId",
                schema: "Elsa",
                table: "Bookmarks",
                column: "CorrelationId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmark_Hash",
                schema: "Elsa",
                table: "Bookmarks",
                column: "Hash");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmark_Hash_CorrelationId_TenantId",
                schema: "Elsa",
                table: "Bookmarks",
                columns: new[] { "Hash", "CorrelationId", "TenantId" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookmark_TenantId",
                schema: "Elsa",
                table: "Bookmarks",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmark_WorkflowInstanceId",
                schema: "Elsa",
                table: "Bookmarks",
                column: "WorkflowInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDefinition_DefinitionId_VersionId",
                schema: "Elsa",
                table: "WorkflowDefinitions",
                columns: new[] { "DefinitionId", "Version" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDefinition_IsLatest",
                schema: "Elsa",
                table: "WorkflowDefinitions",
                column: "IsLatest");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDefinition_IsPublished",
                schema: "Elsa",
                table: "WorkflowDefinitions",
                column: "IsPublished");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDefinition_Name",
                schema: "Elsa",
                table: "WorkflowDefinitions",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDefinition_Tag",
                schema: "Elsa",
                table: "WorkflowDefinitions",
                column: "Tag");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDefinition_TenantId",
                schema: "Elsa",
                table: "WorkflowDefinitions",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDefinition_Version",
                schema: "Elsa",
                table: "WorkflowDefinitions",
                column: "Version");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowExecutionLogRecord_ActivityId",
                schema: "Elsa",
                table: "WorkflowExecutionLogRecords",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowExecutionLogRecord_ActivityType",
                schema: "Elsa",
                table: "WorkflowExecutionLogRecords",
                column: "ActivityType");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowExecutionLogRecord_TenantId",
                schema: "Elsa",
                table: "WorkflowExecutionLogRecords",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowExecutionLogRecord_Timestamp",
                schema: "Elsa",
                table: "WorkflowExecutionLogRecords",
                column: "Timestamp");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowExecutionLogRecord_WorkflowInstanceId",
                schema: "Elsa",
                table: "WorkflowExecutionLogRecords",
                column: "WorkflowInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_ContextId",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "ContextId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_ContextType",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "ContextType");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_CorrelationId",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "CorrelationId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_CreatedAt",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_DefinitionId",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "DefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_FaultedAt",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "FaultedAt");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_FinishedAt",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "FinishedAt");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_LastExecutedAt",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "LastExecutedAt");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_Name",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_TenantId",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_WorkflowStatus",
                schema: "Elsa",
                table: "WorkflowInstances",
                column: "WorkflowStatus");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_WorkflowStatus_DefinitionId",
                schema: "Elsa",
                table: "WorkflowInstances",
                columns: new[] { "WorkflowStatus", "DefinitionId" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowInstance_WorkflowStatus_DefinitionId_Version",
                schema: "Elsa",
                table: "WorkflowInstances",
                columns: new[] { "WorkflowStatus", "DefinitionId", "Version" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookmarks",
                schema: "Elsa");

            migrationBuilder.DropTable(
                name: "WorkflowDefinitions",
                schema: "Elsa");

            migrationBuilder.DropTable(
                name: "WorkflowExecutionLogRecords",
                schema: "Elsa");

            migrationBuilder.DropTable(
                name: "WorkflowInstances",
                schema: "Elsa");
        }
    }
}
