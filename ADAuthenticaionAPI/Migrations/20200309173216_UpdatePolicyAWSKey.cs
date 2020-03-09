using Microsoft.EntityFrameworkCore.Migrations;

namespace ADAuthenticaionAPI.Migrations
{
    public partial class UpdatePolicyAWSKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AwsKey",
                table: "Policies",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwsKey",
                table: "Policies");
        }
    }
}
