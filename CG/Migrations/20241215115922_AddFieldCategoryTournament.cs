using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldCategoryTournament : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryTournament",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CategoryTournament", "CreatedDate" },
                values: new object[] { 0, new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryTournament", "CreatedDate" },
                values: new object[] { 0, new DateTime(2024, 12, 15, 11, 59, 21, 913, DateTimeKind.Utc).AddTicks(1916) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryTournament",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf4199b4-2543-48f9-96a2-041011452f4b", "AQAAAAIAAYagAAAAEGEqsR7HymOEI8SUjYwa/BHXCCh1wcANAimruvFDY1cXkPIgCXp79S7kfOTQXrPCRQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79d42e8d-a09a-4b46-b65b-117fe3c5f0bc", "AQAAAAIAAYagAAAAECWEZ3Y5ucJn4QDuCYuqylrbKOlMdg+CyKBs5LrlYQ4xTJoZgan7Oeq9veZIfUiF8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2c49897-0e42-4a8c-adaf-13d3b62368b9", "AQAAAAIAAYagAAAAEK/9Umd4r9GrIK5XfvWFl5iSb0ec47KkT2wsuZgzCkhDMSV2jIw8lURzTq19PpLg9g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ab98f11-0268-48d8-b302-14d4a7f424ce", "AQAAAAIAAYagAAAAEF4aJ6SSMMwGK+EZB4WXbAPPSi0L7HwVxIPtYDMdPXC93C7BDWP9W8vY6rs5muNsig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acd505b9-ba3b-4602-9d3f-ffd54085e4fb", "AQAAAAIAAYagAAAAEDy2oJBTr1+qXkXoaExGL7GZyAzb8Intw/ahnlO/eJZji6syWgv5S0U7SRyewYR4jA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7afc0391-459b-47aa-8729-87df90a0be59", "AQAAAAIAAYagAAAAEAjsccNkZR8IF3bh5K347vETLOPn5lEnDO3tcz4ocFg5+LHD2Crmy9WjmflkjpTVew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5370936-5413-4c08-a953-40cc67ba4805", "AQAAAAIAAYagAAAAEHp8VFR5l2rWUz9YmeVwcYLFHNgpoB8kxn+9un6TXkpWgbxT+th1yhdrlJPIJSfJUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "89c40da1-091e-4a18-ba76-f1dbb29a4184", "AQAAAAIAAYagAAAAENFn/8GoAy3MEE1ududNUwYN1MzTekZLVUzJAYuQ1CJt4LnerqpI7WzpReOjyXoNGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b12bc4f0-dc99-410a-841c-c552d6e2cf8f", "AQAAAAIAAYagAAAAECA9jKeh+DeV4Qa/1fNRZ/hE+xKzHeoCFl7CBeCYELYbXQ9pcxg2XdNFhuwaZaCP6w==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 260, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(228));
        }
    }
}
