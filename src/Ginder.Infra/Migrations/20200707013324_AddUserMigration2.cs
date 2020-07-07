using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ginder.Infra.Migrations
{
    public partial class AddUserMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("71833138-ba80-4851-bf9d-ff01ea572d88"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 695, DateTimeKind.Unspecified).AddTicks(1487), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("885c76df-b632-496e-a87f-98a5a362bd94"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 695, DateTimeKind.Unspecified).AddTicks(1478), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8e4275ae-b5ed-4a16-a8c7-32d4c5cbd4f4"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 695, DateTimeKind.Unspecified).AddTicks(1350), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PlayerGames",
                keyColumn: "Id",
                keyValue: new Guid("fee6b24d-a74d-4391-ab0e-091d48762b6f"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 763, DateTimeKind.Unspecified).AddTicks(9856), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c8413c17-63e7-491a-9eae-0489737e19ff"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 763, DateTimeKind.Unspecified).AddTicks(628), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Idade", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e19e6927-a444-489c-885c-45735f88e6ee"), new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 763, DateTimeKind.Unspecified).AddTicks(733), new TimeSpan(0, -3, 0, 0, 0)), null, 23, "Player 2", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6699c75-5f44-4029-a404-84ce8a3951c8"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 764, DateTimeKind.Unspecified).AddTicks(5451), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "PlayerGames",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "GameId", "PeriodTime", "PlayerId", "Role", "UpdatedAt" },
                values: new object[] { new Guid("488d7a32-cd07-4963-8846-61a1ff12deee"), new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 763, DateTimeKind.Unspecified).AddTicks(9965), new TimeSpan(0, -3, 0, 0, 0)), null, "Jogo pra zuar", new Guid("8e4275ae-b5ed-4a16-a8c7-32d4c5cbd4f4"), "Todo santo dia xD", new Guid("e19e6927-a444-489c-885c-45735f88e6ee"), "MID", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayerGames",
                keyColumn: "Id",
                keyValue: new Guid("488d7a32-cd07-4963-8846-61a1ff12deee"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("e19e6927-a444-489c-885c-45735f88e6ee"));

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
    }
}
