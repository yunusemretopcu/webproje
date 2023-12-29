using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Api.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "066a4947-f9bb-4fca-824f-46cd4552964e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ed0bfd-7082-41ed-b885-3ab705fff42f");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Policlinics");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64bf7177-656e-4439-8983-e64b9d6a2109", "8eb5f35d-6c66-4f56-9d36-96c07699947a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5ce603e-2e5f-4bda-9df8-fcbe641bef0d", "545f8793-1cce-4141-b65e-6be2f24b284b", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64bf7177-656e-4439-8983-e64b9d6a2109");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5ce603e-2e5f-4bda-9df8-fcbe641bef0d");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Policlinics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "066a4947-f9bb-4fca-824f-46cd4552964e", "04517bc4-27d2-4374-8b5a-a67e6740e664", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4ed0bfd-7082-41ed-b885-3ab705fff42f", "8c90ae6b-c720-4c20-93c7-8d9dc3252717", "Admin", "ADMIN" });
        }
    }
}
