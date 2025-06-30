using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddWebinarFiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebinarFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebinarId = table.Column<int>(type: "int", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    FileContentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TypeWebinarFiles = table.Column<int>(type: "int", nullable: false),
                    OfferThumbNail = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebinarFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebinarFiles_Webinars_WebinarId",
                        column: x => x.WebinarId,
                        principalTable: "Webinars",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7a07b57-3ec5-4031-a839-8deb0500e379", "AQAAAAIAAYagAAAAEJKOuhDcX9uYeRMuSXc+AF8OJSMOWvlYh/CcNnvVW1TlHnYD5/HoW05F+fSGE0UQSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "011864ad-1bb3-49b3-bd28-ae92b9e2f6e8", "AQAAAAIAAYagAAAAEFTvXyCbvq8QIsuHvnKHxdDwzarWiEq2TTw/tiicFzxN6L3wAsJXvGR+P16fnrQMdw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0467199-a7b5-4255-8643-ff5143aa36f9", "AQAAAAIAAYagAAAAEBzYP4eGVm3Qj1b5IJ2wXRv0HuWl0JncrBkkDS4HS73YA3nIXtJEiLFV/fJcQhuU4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13ad2b64-3ce1-4d16-8a9b-e219eca531ca", "AQAAAAIAAYagAAAAEHTewqxq76YqFsACDRTrjm5KUpl48dvQ+NhyT+EOmQW0ZO32f3YGcjSFSaS7AEyYfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e61450e-9f88-479f-88b8-a208bfdcd2d2", "AQAAAAIAAYagAAAAEAG40AehFciRJg2vbrf/QEkumJKtg2gVIfJ0Yi0FUHTAIvR6Kk4Y3SvPp363c6bYIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "701e1385-8701-4e54-af76-a45bef177661", "AQAAAAIAAYagAAAAEBnYijZQP9B8dxefD7oTxTzGK8e8fN1xCK/CYCtQPCJWskzZwoCweA6+xqOcdStZCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16461d1b-76a2-460e-8d07-df483955c02b", "AQAAAAIAAYagAAAAEPWzdIv8A0k1GJ86fhbUbXsPJdd0S/WMkql98rk2ByXMGr+3YqiTL2pqude4d7m5uw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f372a49-f2af-4380-a975-14fe805e4a08", "AQAAAAIAAYagAAAAEEsflFt+bPb6eTdn0IkuSOTWma8/boFAPEU8qBlSGjtY0HahRkVFPMWUsVriG7jRcA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8c04fbf-60d3-4704-95e9-69aa2d3df2f7", "AQAAAAIAAYagAAAAEMBE3WXReaXvSLbDEW0kdn08P3MCqHEy1BOe3vs6KOXrH3XD++AZFrWeshb1eluZXQ==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.CreateIndex(
                name: "IX_WebinarFiles_WebinarId",
                table: "WebinarFiles",
                column: "WebinarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebinarFiles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd28e8b0-bf64-41c4-9276-718e6df629c9", "AQAAAAIAAYagAAAAEFjiW3+WXBiV/rTA3RJtFyMwz9UmWBXFgXG1PQLsm6ZK44aZXEsOORO4QiPPLsvUoQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a4e51e1-c1a5-4cc0-b187-1a57a399ee71", "AQAAAAIAAYagAAAAEOfw60yZtDrLohlYDkO7hl5LxXvAWe4a4EoOUHdGcilxM6dKZRUPo6cq4U8EulBzzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4583c34f-5d5b-47f7-b708-093be0bc8646", "AQAAAAIAAYagAAAAENi7t9bDelM5gurtqbOJCw5V/gV+73qSStrfeubiPJ0v/4huXAZIUJSZbVAYOvOh1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e281a14e-bf08-4a21-b4b3-cd1b4685284f", "AQAAAAIAAYagAAAAEKUjciqBT5BsOkoAZWEIWNOXKxNKsQ7u4J4ldNokK3TbGIQc0h4JLto2caJFb0flow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af73b81c-a4f9-45f0-af55-da7407bc73e8", "AQAAAAIAAYagAAAAEAOeV0K2yuoWFgr/omqb7d6le+LAW6b29nM8/ocdZY/u03yUF88Gqu8l5CPJNRY+lQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a72c329-7bd3-4653-9b86-8b074df0088b", "AQAAAAIAAYagAAAAEJhah5j1KY5JT8MHAt7CKnDju2GAqPiRCI+HSpnwrCv7YLgxuyx5NQuZRLdYaaqwHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e6b5dc8-a460-4dd7-a90b-3b1b40bef123", "AQAAAAIAAYagAAAAEP/dCCzhrYq673Z67C10hjuZIsC3LXI62yNvXycxFUhduVxbceez+CZ2ncrz13D7Yw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77cd01e1-c293-4e7a-ac05-1507bfbcdc9d", "AQAAAAIAAYagAAAAECcX82CV03m5UJGXnqT2d37kOLvjjM1I0Y9A7HO+urINOpE1Aga4HFbS0RdYKT5Vkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b3283e9-b518-4948-a76a-3378b64590a2", "AQAAAAIAAYagAAAAEFNzDKUGBF2W/B/NW52xLX1gJuUtfLutjxMW/cB7/ZXFRNTnn77uiS8A1r8iiAoKhw==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2296));
        }
    }
}
