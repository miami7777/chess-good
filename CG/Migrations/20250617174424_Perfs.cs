using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class Perfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "perfsStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Games = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    RD = table.Column<int>(type: "int", nullable: false),
                    Prog = table.Column<int>(type: "int", nullable: false),
                    Prov = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfsStatistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "perfs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlitzId = table.Column<int>(type: "int", nullable: true),
                    BlitzIncId = table.Column<int>(type: "int", nullable: true),
                    RapidId = table.Column<int>(type: "int", nullable: true),
                    RapidIncId = table.Column<int>(type: "int", nullable: true),
                    BulletId = table.Column<int>(type: "int", nullable: true),
                    BulletIncId = table.Column<int>(type: "int", nullable: true),
                    ClassicalId = table.Column<int>(type: "int", nullable: true),
                    ClassicalIncId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_perfs_perfsStatistics_BlitzId",
                        column: x => x.BlitzId,
                        principalTable: "perfsStatistics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_perfs_perfsStatistics_BlitzIncId",
                        column: x => x.BlitzIncId,
                        principalTable: "perfsStatistics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_perfs_perfsStatistics_BulletId",
                        column: x => x.BulletId,
                        principalTable: "perfsStatistics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_perfs_perfsStatistics_BulletIncId",
                        column: x => x.BulletIncId,
                        principalTable: "perfsStatistics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_perfs_perfsStatistics_ClassicalId",
                        column: x => x.ClassicalId,
                        principalTable: "perfsStatistics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_perfs_perfsStatistics_ClassicalIncId",
                        column: x => x.ClassicalIncId,
                        principalTable: "perfsStatistics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_perfs_perfsStatistics_RapidId",
                        column: x => x.RapidId,
                        principalTable: "perfsStatistics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_perfs_perfsStatistics_RapidIncId",
                        column: x => x.RapidIncId,
                        principalTable: "perfsStatistics",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dc90d8d-6ff1-4958-9063-46a14024f343", "AQAAAAIAAYagAAAAEEhWXnQJlEHIlIvgAGML8AXy+nulJBIdxlGiSZ7IFFEtGRgp8ZFYk0XU40P4ndePqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1582d2d-a2c8-44d3-ac87-9ae26665b195", "AQAAAAIAAYagAAAAEInnB0802Xtk69fOYcczX8mLdArajC/4231QcvhY/sLrzUBGwARblpVfq6IDMJn+iQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61f1efa7-4212-449b-80d7-22c766480edf", "AQAAAAIAAYagAAAAEDNI86X6+RAK5r+PnA6rs2L5s1XuE13qO3jTEHYxIuyY8k87OdYQ9UBgtCs9Q3bcrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e35b70ca-93f4-4175-9958-be285bb98359", "AQAAAAIAAYagAAAAEF5Cd40kzXZNRQpqqHDIfJSjSQqec5YclwGwGccNYmFsfItARY/5WqrLY6qftmVzTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8d24240-dcf5-4b4d-923a-3ac9365a84e8", "AQAAAAIAAYagAAAAEGawUhuHQqmyIWDyhVo4KbW9jJ3wIAgsYsx4pmNf972yGAVyMF9zFrsRhVl24K59Yg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbd52647-35ee-4e78-acab-a265e28b6ccf", "AQAAAAIAAYagAAAAEECB89H0JkaU3B3j9Rs18GbPCkmNLBEpdbSmfXbnJQj2c5Nycl2SRk7fUCYUIOEaEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3d59ef7-d4a8-4e17-b90f-622b5fc468ce", "AQAAAAIAAYagAAAAECxPNIU56lgxBO/9Z0Bd2h0SzwN4AaVLgKWcVllvRXDGX5KTEtBy6eOHgN4wSOhtAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abb851e8-8448-4afc-90fe-586241a78271", "AQAAAAIAAYagAAAAEHkW1VraB7YFFr71bMcaaLyciJ4q6hVRnRAdaMxCyKqvfwGBWiQij5RPlRXFAhwH4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5376d066-ead0-4772-86b5-64cbb4b5c0ec", "AQAAAAIAAYagAAAAEDj4r1aYm3nXKHoFcnx3O5F9VTW0/03bwlmrnSKt1qKFlkt0lnHO7+LXhixmh1Jtkg==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 521, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 17, 44, 23, 522, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.CreateIndex(
                name: "IX_perfs_BlitzId",
                table: "perfs",
                column: "BlitzId");

            migrationBuilder.CreateIndex(
                name: "IX_perfs_BlitzIncId",
                table: "perfs",
                column: "BlitzIncId");

            migrationBuilder.CreateIndex(
                name: "IX_perfs_BulletId",
                table: "perfs",
                column: "BulletId");

            migrationBuilder.CreateIndex(
                name: "IX_perfs_BulletIncId",
                table: "perfs",
                column: "BulletIncId");

            migrationBuilder.CreateIndex(
                name: "IX_perfs_ClassicalId",
                table: "perfs",
                column: "ClassicalId");

            migrationBuilder.CreateIndex(
                name: "IX_perfs_ClassicalIncId",
                table: "perfs",
                column: "ClassicalIncId");

            migrationBuilder.CreateIndex(
                name: "IX_perfs_RapidId",
                table: "perfs",
                column: "RapidId");

            migrationBuilder.CreateIndex(
                name: "IX_perfs_RapidIncId",
                table: "perfs",
                column: "RapidIncId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perfs");

            migrationBuilder.DropTable(
                name: "perfsStatistics");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a072813-cf0a-4046-9897-f82fc820aec4", "AQAAAAIAAYagAAAAEGHCMqooLNqjJqGSIvm4ObiNQyakHwUfoTdGeGgDJ/8hlvejMTc4wG8f5PrKon1xIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "717c90eb-fea3-4f7c-9e2c-1a817db843bc", "AQAAAAIAAYagAAAAEAF/EhcO+lcd1IJfMCgTcbAQcSpcGAk3D0kdHKY3Lh+LVA5rf+uP14L2Bk+kzUi1Ag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a427d9c3-14e1-4c21-810a-7634a12d5997", "AQAAAAIAAYagAAAAEAJuzhFP/wGzmAIkdVcWPMmBFy0TJlzEYIChh/oDZ9mP1ew3yZ8nxqV31w3SFuqzvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd53135e-529b-465d-9355-ab5a8ffcd07e", "AQAAAAIAAYagAAAAEGCGI5Cl6c6MYvIQ4f2YN6ZpzC7MyitJZ8zWgYP9PJbKX+0WFBDeCbxY11DGSxG4mw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9abb0d2-e690-4368-862f-2dd64e6d43cc", "AQAAAAIAAYagAAAAEGbX1AfJabrlwd6Z7CnJ0aCDNZSmczrgH7TWrW4AHqgNlaMsc+t5wfpITBwc0xt5eg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b61dc55-6b2e-439e-ab17-e0ec96b3214b", "AQAAAAIAAYagAAAAECT1nReRtZWNs+Nnzmdsk5BMWjvIK4AIzI3XvbqBJbjDjYn+FY1VFwA1Svq8w2Uo6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a8add93-3456-48dc-ae69-7587cd60f90d", "AQAAAAIAAYagAAAAELdL1EGDNewfDCShgpwFFwNEtY0iG+Kd8GOwfuz7B3cdLtHmiSCb9ZrjK99K3HvhKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0f7f4b7-e34e-4746-9769-afce8d12aa87", "AQAAAAIAAYagAAAAEF3FK0UHHGpygrlkGMFVr8C9TTO8PYEpPwpKYnTdZ0cPitw+O5dzHcQ5rNaqG0i4Ew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0bf0da7-1ad4-4137-83ba-6fb16bd88f77", "AQAAAAIAAYagAAAAEPCHKdF/fOF43bymDOmZF9lla52QrvCfxPnRoKS00/8I7ruCssquHELFiCfOD6odKg==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1968));
        }
    }
}
