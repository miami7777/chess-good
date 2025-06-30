using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsToTableWebinars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageWebinar",
                table: "Webinars");

            migrationBuilder.DropColumn(
                name: "PreviewImageWebinar",
                table: "Webinars");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba3ab2d2-ab2f-4be6-9ede-211f59ff742f", "AQAAAAIAAYagAAAAEO+xKfxUFrG33Ghubvjv0EV2QZWmUpHpD3orJMyvUfTTz6a+bnROD8rU7o7MpBzVVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "344f3667-f245-474f-bcf9-99d2b029f18e", "AQAAAAIAAYagAAAAEAAkL3fSsJKuiGDwLdXq7qhKPjl4Jki9v5Vt+ROsRdqyvKqgf7UQt9KONaSuBlmYiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58a603d7-5fee-401d-98e5-a54b32129d95", "AQAAAAIAAYagAAAAELYkKFxfix/AcfbUMsY8con3hDu67d2gH3Za/tzJAXrTtUmLgIMjWaT0gdsphWSsmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23925719-6ae3-4fe3-afcb-b55074a6a33d", "AQAAAAIAAYagAAAAEM/q8fKpK5uY3p/rwJh3YBZ4Ec0ps58NICfAqnTETIevdrAOOHieq5aY7t9Ei8zqoQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "135cbfa9-e71e-476b-b744-c645e1be0cc4", "AQAAAAIAAYagAAAAEJekmiXqSfqy8pIfhm9yP69BuR4qUm+Y5wTyd7EX6bS9UCyBrNhuUmvbSGT8JoUjwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "379d2baa-a04a-4b8b-85fe-983ddcfd50ef", "AQAAAAIAAYagAAAAEBVUih3wRQ3iudoG567n7tYvtkF1xm4/o4RM1oHI9fJsROpvYDkBv8TV3B3+1wjLvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97ca4f6e-39ad-40c7-8c28-59979a6aed09", "AQAAAAIAAYagAAAAEBFJVK8DVhZP0twM8NZ5GPwbzvcKnx59qro3IhDT3NQGs8hiaEkiVHvdPYMw163KzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6687f78f-6c0e-4dd1-a2a4-0c3edd553aa3", "AQAAAAIAAYagAAAAEI5ZgeGt3AychYWzOotuxb0AmB0CD1y3TFzOnTtUwcdjCC2RSlXcRCAjZxojFN0OxQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66032d82-a20b-4bb8-9db7-2baa2cbdd9f0", "AQAAAAIAAYagAAAAENoXAj9WQisXFEC6I5BpXAnznOhP3Hd7UmpF9frkrBBTgh2a190KlMpF4KdfRsXyBA==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7009));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageWebinar",
                table: "Webinars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreviewImageWebinar",
                table: "Webinars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedDate", "ImageWebinar", "PreviewImageWebinar" },
                values: new object[] { new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6872), "events-item-3.jpg", "events-item-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageWebinar", "PreviewImageWebinar" },
                values: new object[] { new DateTime(2024, 11, 4, 13, 50, 12, 83, DateTimeKind.Utc).AddTicks(6901), "events-item-4.jpg", "events-item-4.jpg" });
        }
    }
}
