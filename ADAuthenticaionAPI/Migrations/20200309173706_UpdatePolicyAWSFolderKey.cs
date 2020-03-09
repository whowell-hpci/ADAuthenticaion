using Microsoft.EntityFrameworkCore.Migrations;

namespace ADAuthenticaionAPI.Migrations
{
    public partial class UpdatePolicyAWSFolderKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AwsFolderKey",
                table: "Policies",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwsFolderKey",
                table: "Policies");
        }
    }
}
