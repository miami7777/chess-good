using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddClockTournament : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClockTournamentId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClockTournament",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Limit = table.Column<int>(type: "int", nullable: false),
                    Increment = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClockTournament", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ac3031f-fdf1-4933-a029-481b3bfab7d2", "AQAAAAIAAYagAAAAEFVP9VwSfQpzt8qu1DQ9thgupsY4+yPfIVghOjRAJzx4LH43j02mZd5cJJyvF2W3dw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c2f167c-ba9c-43f1-b812-f3ef93a6f3dd", "AQAAAAIAAYagAAAAENgX+FOSrOH9zbvb527RTU3AeFYPgnOsfTvhAbvF5V9/ExSdUfaDzXlBaBjM/QyQsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27bd0aa6-61e6-4de9-9348-187778184e4b", "AQAAAAIAAYagAAAAEPb4pSllRQP6YTeYSFFG3rM7FmsU7xpVxCWns5BDiop2nNw7aFHNtH1eBGMBsIhfqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1d8e901-ae5a-4a03-981b-b4ed988836b6", "AQAAAAIAAYagAAAAEFPtGGfu1nC7wqk//bnAOnybPM76VvXjfzbpGhoONooSUT1YyWLaVjlsRGH046HR0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3da9926d-231b-4be0-80fa-b4869b9ba93b", "AQAAAAIAAYagAAAAEMiSIxMSVEmweZf3CAYPKeLaGe2X0kcp/naFDe1q8TZqTYTFf2fjgb0pC+fonxUwlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70562374-f45f-4604-937a-9937260cb21c", "AQAAAAIAAYagAAAAEBXJ2AjXv4dJ+2VtsirpN9ieyXZo0ejk11AtvD5tnWa/Pcc9qcXvGHjRu7beHDec/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cec0a67a-3399-4588-a564-42eb7633f920", "AQAAAAIAAYagAAAAEFNOkp45LeqeGxABrmokSyXiEaDXCwsKgUmciiM10P7q5Za3jLSn07/cS04PI97tnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7a2c558-d603-4009-8174-42a22ebcd034", "AQAAAAIAAYagAAAAEKM9NOZoj0zSO3rvXT4A9pZ+2gY+749e45JOwZrzKc5aJLAw/zgRTq8tipaQ0Nh5fA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83412425-2815-4d77-89e7-7f842ae0d47a", "AQAAAAIAAYagAAAAEFbL8uNOcmeMqtZ0fkMexAkNcY6u7p96Gut2cRST0OfK9DFJ9i/sPELrac4t0hIafQ==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClockTournamentId", "CreatedDate" },
                values: new object[] { null, new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClockTournamentId", "CreatedDate" },
                values: new object[] { null, new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClockTournamentId",
                table: "Courses",
                column: "ClockTournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ClockTournament_ClockTournamentId",
                table: "Courses",
                column: "ClockTournamentId",
                principalTable: "ClockTournament",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ClockTournament_ClockTournamentId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "ClockTournament");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ClockTournamentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ClockTournamentId",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1af28189-b475-4f51-a4a1-dd3fadaad3e0", "AQAAAAIAAYagAAAAECeZtFiSxp5e8NpPhIprLKDQLsOM1WSsmKlShcily8uBW/YGoT/WfArQ6JEXsmPdOg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0779dec-a30d-4e1e-b3da-e43e6fdc6d4e", "AQAAAAIAAYagAAAAEJisvPhN//rQHtVgBtunWFjdlaJ+pVeeUwkVD9InvIGxNLj2yjONvtF9MuTayz5dMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7789ffbb-b2f0-4819-b10b-9dacb9e2b5f9", "AQAAAAIAAYagAAAAEJ6wUc57VQPQl3/idxFKD5f+pHP/5Kf2hELIQyG93wVraxGhfUsbiDBZz+wv7C6M9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de1d550a-be2d-43ca-a9b8-250cf9ec50b6", "AQAAAAIAAYagAAAAEMRoVg9mNA2BP0ZbLdYZfCUbk0RYOVZNBE10B63Fp7LAzLaAHrnJhbhDDKtMcacIaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ba62bcb-1968-445a-83d2-a51ebfdd8c9c", "AQAAAAIAAYagAAAAEFqnFhIkeUqsINy2Li7T5U0NVFPetkT/oj4IDlkOopJsGeVtJs8Wz+mcnS7bA1rnfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bec30a62-4eb1-42e7-bc26-54e3117560d3", "AQAAAAIAAYagAAAAENBgcx0JAM5jqg5ECkLSCHZNzFLggUYHdnBVODVLY4W+bcYBQeQkmf8zjYrrlQwYaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f9ea91b-dcf3-48f7-9e4f-67af812886b4", "AQAAAAIAAYagAAAAENBKfVjH5q5fI7dxy7l2e8Nr81+nk/N1uUWys3vc0a5AXx6QS0kigYzZmXCF5eylow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "adc427e1-0602-4db4-87ef-177e418cca1c", "AQAAAAIAAYagAAAAEJiAJI6yniQn8MSYdOCMozdLy92KC9/XKsYDkfo6sypZoR/b+wOkiTBw3FYEGX8iMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91ab7ee1-cbdf-4890-bbb3-4e58bef646d9", "AQAAAAIAAYagAAAAEHID9lye10jv4Vnp4WboLT7j5w0UQ+uxdhgoJEqwdhUDXFuzCat+CwzQsVtXYdtv0g==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1749));
        }
    }
}
