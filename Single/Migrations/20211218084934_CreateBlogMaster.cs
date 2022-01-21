using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Single.Migrations
{
    public partial class CreateBlogMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogMaster",
                columns: table => new
                {
                    BlogId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PostId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "sysutcdatetime()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogMaster", x => new { x.BlogId, x.PostId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogMaster");
        }
    }
}
