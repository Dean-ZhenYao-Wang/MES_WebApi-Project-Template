using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseDB.Migrations
{
    public partial class 初始化 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "菜单",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    名称 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    编号 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    序号 = table.Column<int>(type: "int", maxLength: 4000, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ICON = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    上级菜单Key = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_菜单", x => x.Key);
                    table.ForeignKey(
                        name: "FK_菜单_菜单_上级菜单Key",
                        column: x => x.上级菜单Key,
                        principalTable: "菜单",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "附件",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Extension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Size = table.Column<long>(type: "bigint", precision: 19, scale: 0, nullable: false, defaultValueSql: "0"),
                    ContentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Hash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UploadTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_附件", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "角色",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    名称 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_角色", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "用户",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    登录用户名 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    密码 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    昵称 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    性别 = table.Column<int>(type: "int", precision: 10, scale: 0, nullable: true),
                    邮件 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    手机 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    头像 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    年龄 = table.Column<int>(type: "int", precision: 10, scale: 0, nullable: true),
                    生日 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_用户", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "组织",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    编号 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    序号 = table.Column<int>(type: "int", maxLength: 4000, nullable: false),
                    名称 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    全名 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    上级组织Key = table.Column<Guid>(type: "uniqueidentifier", maxLength: 4000, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_组织", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "角色_菜单",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    角色Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    菜单Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_角色_菜单", x => new { x.Key, x.角色Key, x.菜单Key });
                    table.ForeignKey(
                        name: "FK_角色_菜单_菜单_菜单Key",
                        column: x => x.菜单Key,
                        principalTable: "菜单",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_角色_菜单_角色_角色Key",
                        column: x => x.角色Key,
                        principalTable: "角色",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "用户_角色",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    用户Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    角色Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_用户_角色", x => new { x.Key, x.用户Key, x.角色Key });
                    table.ForeignKey(
                        name: "FK_用户_角色_角色_角色Key",
                        column: x => x.角色Key,
                        principalTable: "角色",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_用户_角色_用户_用户Key",
                        column: x => x.用户Key,
                        principalTable: "用户",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "用户_组织",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    用户Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    组织Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_用户_组织", x => new { x.Key, x.用户Key, x.组织Key });
                    table.ForeignKey(
                        name: "FK_用户_组织_用户_用户Key",
                        column: x => x.用户Key,
                        principalTable: "用户",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_用户_组织_组织_组织Key",
                        column: x => x.组织Key,
                        principalTable: "组织",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_菜单_上级菜单Key",
                table: "菜单",
                column: "上级菜单Key");

            migrationBuilder.CreateIndex(
                name: "IX_角色_菜单_菜单Key",
                table: "角色_菜单",
                column: "菜单Key");

            migrationBuilder.CreateIndex(
                name: "IX_角色_菜单_角色Key",
                table: "角色_菜单",
                column: "角色Key");

            migrationBuilder.CreateIndex(
                name: "IX_用户_角色_角色Key",
                table: "用户_角色",
                column: "角色Key");

            migrationBuilder.CreateIndex(
                name: "IX_用户_角色_用户Key",
                table: "用户_角色",
                column: "用户Key");

            migrationBuilder.CreateIndex(
                name: "IX_用户_组织_用户Key",
                table: "用户_组织",
                column: "用户Key");

            migrationBuilder.CreateIndex(
                name: "IX_用户_组织_组织Key",
                table: "用户_组织",
                column: "组织Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "附件");

            migrationBuilder.DropTable(
                name: "角色_菜单");

            migrationBuilder.DropTable(
                name: "用户_角色");

            migrationBuilder.DropTable(
                name: "用户_组织");

            migrationBuilder.DropTable(
                name: "菜单");

            migrationBuilder.DropTable(
                name: "角色");

            migrationBuilder.DropTable(
                name: "用户");

            migrationBuilder.DropTable(
                name: "组织");
        }
    }
}
