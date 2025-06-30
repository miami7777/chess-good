using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddTypeAccessWebinar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeAccess",
                table: "Webinars",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedDate", "TypeAccess" },
                values: new object[] { new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2245), 0 });

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "TypeAccess" },
                values: new object[] { new DateTime(2024, 11, 4, 11, 38, 49, 583, DateTimeKind.Utc).AddTicks(2296), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeAccess",
                table: "Webinars");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dade7352-99d8-4d59-97da-e20589a4e172", "AQAAAAIAAYagAAAAENBWiQ7LmE/0iACzh4rOExb4IASRdM7Ud5uVQll7pQf8i9IEDd5iag83e5ReecFH7w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da421212-58c3-4a1e-92e0-252bb023541a", "AQAAAAIAAYagAAAAEHf7uKDdilwT1H4dfCQy36x3ZYjgQhjecb9sODwCPBPGS66Jnxh/uTOnfaaiyCTXJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8539d257-4c91-4a22-8c9d-e74f59aa439d", "AQAAAAIAAYagAAAAEK5hItGnWVGkAWjL63sVCVfUjOi62pl2jInBkFoCOMVICPXwF8IXAJYwaWuVH9OGFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02c7a3a2-9f8a-4757-9b25-6c5d700592ab", "AQAAAAIAAYagAAAAEGmk/dpGISWptCh8LHkT1U9pKqbFQAFbuDJ0+LwVYSoveB6F5mNXiSbpb97JX4CErw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35e3790b-c31c-4f25-ab0a-5db1b09c9041", "AQAAAAIAAYagAAAAEFApXCvHATkQCxTPFmy/oDY0GtdvwooIHLLi2MK8TPfUcQgfD3hy5gpPFCqmW7b7sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b50c60c7-dd10-418d-8202-05a55067162c", "AQAAAAIAAYagAAAAEHkgwYu9wPFNb0WNzIaFgaBMcl1SW58oJM/EDKndZ/gShcUmpKnHfNE6bQFOP7eyxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2030d8f1-4c79-433d-bf1b-9ba4c19dc2e5", "AQAAAAIAAYagAAAAEDrnzs6sdQWTzDFh5Qt3fL+B/XRpgWBN0PeC6iHzrHEKnFkLEILCrO8GNIk2J2Qw2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7620082c-edac-469f-a0f5-5bddf2fff69e", "AQAAAAIAAYagAAAAEAUAF++xTRYUwxb54gj7HyRYBtPrjg/IUScYq3x5JuLBSm9ki/FkXiJgeBVJkluf7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c1fe686-8cac-4f06-825b-dd97aa2099a8", "AQAAAAIAAYagAAAAEGnwmkSpqWVIVcX47mfa4BVpZxt56LWZm/MEGczFchn15y+Guv5lm264LDhVp+VTVw==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8831));
        }
    }
}
