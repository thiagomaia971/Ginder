using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ginder.Infra.Migrations
{
    public partial class AddUserMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("71833138-ba80-4851-bf9d-ff01ea572d88"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 260, DateTimeKind.Unspecified).AddTicks(5291), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("885c76df-b632-496e-a87f-98a5a362bd94"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 260, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8e4275ae-b5ed-4a16-a8c7-32d4c5cbd4f4"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 260, DateTimeKind.Unspecified).AddTicks(5060), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PlayerGames",
                keyColumn: "Id",
                keyValue: new Guid("488d7a32-cd07-4963-8846-61a1ff12deee"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 331, DateTimeKind.Unspecified).AddTicks(7401), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PlayerGames",
                keyColumn: "Id",
                keyValue: new Guid("fee6b24d-a74d-4391-ab0e-091d48762b6f"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 331, DateTimeKind.Unspecified).AddTicks(7209), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "PlayerGames",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "GameId", "PeriodTime", "PlayerId", "Role", "UpdatedAt" },
                values: new object[] { new Guid("b2768f45-4d9f-4dae-abec-a6c07cc35603"), new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 331, DateTimeKind.Unspecified).AddTicks(7389), new TimeSpan(0, -3, 0, 0, 0)), null, "Jogo pra zuar3", new Guid("885c76df-b632-496e-a87f-98a5a362bd94"), "Todo santo dia xD4", new Guid("c8413c17-63e7-491a-9eae-0489737e19ff"), "DPS", null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c8413c17-63e7-491a-9eae-0489737e19ff"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 330, DateTimeKind.Unspecified).AddTicks(5037), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("e19e6927-a444-489c-885c-45735f88e6ee"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 330, DateTimeKind.Unspecified).AddTicks(5159), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Idade", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b0707b09-f1bd-44e9-928b-9277e1bf8d46"), new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 330, DateTimeKind.Unspecified).AddTicks(5167), new TimeSpan(0, -3, 0, 0, 0)), null, 23, "Player 3", null },
                    { new Guid("eaf6db7c-e7f3-49c8-afbe-66ed55d52af8"), new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 330, DateTimeKind.Unspecified).AddTicks(5175), new TimeSpan(0, -3, 0, 0, 0)), null, 17, "Player 4", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6699c75-5f44-4029-a404-84ce8a3951c8"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 332, DateTimeKind.Unspecified).AddTicks(3131), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "PlayerGames",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "GameId", "PeriodTime", "PlayerId", "Role", "UpdatedAt" },
                values: new object[] { new Guid("23098ff0-1267-460f-a3f0-fbea676a4279"), new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 331, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, -3, 0, 0, 0)), null, "Jogo pra zuar2", new Guid("8e4275ae-b5ed-4a16-a8c7-32d4c5cbd4f4"), "Todo santo dia xD2", new Guid("b0707b09-f1bd-44e9-928b-9277e1bf8d46"), "ADC", null });

            migrationBuilder.InsertData(
                table: "PlayerGames",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "GameId", "PeriodTime", "PlayerId", "Role", "UpdatedAt" },
                values: new object[] { new Guid("2adcaf82-a6a7-46d2-b126-0d342cd51130"), new DateTimeOffset(new DateTime(2020, 7, 6, 22, 42, 9, 331, DateTimeKind.Unspecified).AddTicks(7433), new TimeSpan(0, -3, 0, 0, 0)), null, "Jogo pra zuar2", new Guid("885c76df-b632-496e-a87f-98a5a362bd94"), "Todo santo dia xD3", new Guid("b0707b09-f1bd-44e9-928b-9277e1bf8d46"), "Healer", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayerGames",
                keyColumn: "Id",
                keyValue: new Guid("23098ff0-1267-460f-a3f0-fbea676a4279"));

            migrationBuilder.DeleteData(
                table: "PlayerGames",
                keyColumn: "Id",
                keyValue: new Guid("2adcaf82-a6a7-46d2-b126-0d342cd51130"));

            migrationBuilder.DeleteData(
                table: "PlayerGames",
                keyColumn: "Id",
                keyValue: new Guid("b2768f45-4d9f-4dae-abec-a6c07cc35603"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("eaf6db7c-e7f3-49c8-afbe-66ed55d52af8"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("b0707b09-f1bd-44e9-928b-9277e1bf8d46"));

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
                keyValue: new Guid("488d7a32-cd07-4963-8846-61a1ff12deee"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 763, DateTimeKind.Unspecified).AddTicks(9965), new TimeSpan(0, -3, 0, 0, 0)));

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

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("e19e6927-a444-489c-885c-45735f88e6ee"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 763, DateTimeKind.Unspecified).AddTicks(733), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6699c75-5f44-4029-a404-84ce8a3951c8"),
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2020, 7, 6, 22, 33, 23, 764, DateTimeKind.Unspecified).AddTicks(5451), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
