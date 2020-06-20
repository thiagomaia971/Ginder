using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ginder.Infra.Migrations
{
    public partial class AddLocationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Location_Latitude",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Location_Longitude",
                table: "Players",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("71833138-ba80-4851-bf9d-ff01ea572d88"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 20, 15, 39, 1, 752, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("885c76df-b632-496e-a87f-98a5a362bd94"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 20, 15, 39, 1, 752, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8e4275ae-b5ed-4a16-a8c7-32d4c5cbd4f4"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 20, 15, 39, 1, 752, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PlayerGames",
                keyColumn: "Id",
                keyValue: new Guid("fee6b24d-a74d-4391-ab0e-091d48762b6f"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 20, 15, 39, 1, 804, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c8413c17-63e7-491a-9eae-0489737e19ff"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 20, 15, 39, 1, 804, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6699c75-5f44-4029-a404-84ce8a3951c8"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 20, 15, 39, 1, 805, DateTimeKind.Unspecified).AddTicks(3277), new TimeSpan(0, -3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location_Latitude",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Location_Longitude",
                table: "Players");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("71833138-ba80-4851-bf9d-ff01ea572d88"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 19, 1, 40, 10, 954, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("885c76df-b632-496e-a87f-98a5a362bd94"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 19, 1, 40, 10, 954, DateTimeKind.Unspecified).AddTicks(9230), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8e4275ae-b5ed-4a16-a8c7-32d4c5cbd4f4"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 19, 1, 40, 10, 954, DateTimeKind.Unspecified).AddTicks(9157), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PlayerGames",
                keyColumn: "Id",
                keyValue: new Guid("fee6b24d-a74d-4391-ab0e-091d48762b6f"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 19, 1, 40, 10, 955, DateTimeKind.Unspecified).AddTicks(1582), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c8413c17-63e7-491a-9eae-0489737e19ff"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 19, 1, 40, 10, 953, DateTimeKind.Unspecified).AddTicks(5168), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6699c75-5f44-4029-a404-84ce8a3951c8"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 6, 19, 1, 40, 10, 954, DateTimeKind.Unspecified).AddTicks(7998), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
