using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class addNewBodySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Eu lobortis elementum nibh tellus molestie nunc. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna. Rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui.", new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Eu lobortis elementum nibh tellus molestie nunc. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna. Rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui.", new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Eu lobortis elementum nibh tellus molestie nunc. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna. Rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui.", new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "Random words", new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "Random words Random words", new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "Random words Random words Random words", new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
