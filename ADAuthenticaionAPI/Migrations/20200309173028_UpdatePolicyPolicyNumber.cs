using Microsoft.EntityFrameworkCore.Migrations;

namespace ADAuthenticaionAPI.Migrations
{
    public partial class UpdatePolicyPolicyNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PolicyNumber",
                table: "Policies",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PolicyNumber",
                table: "Policies");
        }
    }
}
