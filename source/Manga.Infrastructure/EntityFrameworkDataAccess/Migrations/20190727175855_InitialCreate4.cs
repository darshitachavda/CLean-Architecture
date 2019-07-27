using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manga.Infrastructure.EntityFrameworkDataAccess.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Credit",
                keyColumn: "Id",
                keyValue: new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 27, 17, 58, 54, 500, DateTimeKind.Utc).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Debit",
                keyColumn: "Id",
                keyValue: new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 27, 17, 58, 54, 500, DateTimeKind.Utc).AddTicks(5082));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Credit",
                keyColumn: "Id",
                keyValue: new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 27, 17, 32, 45, 889, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Debit",
                keyColumn: "Id",
                keyValue: new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 27, 17, 32, 45, 889, DateTimeKind.Utc).AddTicks(6170));
        }
    }
}
