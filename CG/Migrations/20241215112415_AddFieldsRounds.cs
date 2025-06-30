using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsRounds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoundInterval",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rounds",
                table: "Courses",
                type: "int",
                nullable: true);

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
                columns: new[] { "CreatedDate", "RoundInterval", "Rounds" },
                values: new object[] { new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(51), null, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "RoundInterval", "Rounds" },
                values: new object[] { new DateTime(2024, 12, 15, 11, 24, 12, 261, DateTimeKind.Utc).AddTicks(154), null, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoundInterval",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Rounds",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23b4d740-61b9-46f6-9a76-0743c97d1f8f", "AQAAAAIAAYagAAAAEMoH8Qo2CJZ8xQLh5PFGeRgwK44iEN3D26mC7yz51pA82KjDyJuu/wO2E98EQ41+nw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c81b6669-c2a3-4162-9880-aac19ef822b5", "AQAAAAIAAYagAAAAEDXtgfw9Ncv9uglN0dEfQBz//03hJxgxH+xPYe1tQFFU6brPdbTKrO/wu8VPLCskjw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43cae9c1-5d34-4ff5-b7ab-55fd37d47ad9", "AQAAAAIAAYagAAAAEM+iwKqX2R7TYtvC4ql31cVJ1yquc7aMXkovg4GGFcQoABnTvZHvsRiXNFC6JZ/KUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a52feec0-7cc1-4bbe-8243-ed0d15aa0dc5", "AQAAAAIAAYagAAAAEOvlKe+b0GzMTuTjWfDbf2yRRFZ+J++oA/1jCPNcdHEpgPKZFJzvdssw2pc7tb6VwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c87c067-657a-4345-9590-142b21933d8b", "AQAAAAIAAYagAAAAEEPhXAQePKxxwS9wOJ9waidipMpO8bVlR9DSvao7CnTEu1y6/xx1K/TRJEhkmN2XIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2cf9c586-b5b1-48ff-bf94-a316218d0304", "AQAAAAIAAYagAAAAEDhDKDzijq3WC3Nbxl1eyidcKd498V1jU1HKvtDUlU16o8viLeoXGYE/wAhHa3LO/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70873106-def4-41c8-9d97-2f71b8ee504e", "AQAAAAIAAYagAAAAEFIgCsPey6WsesAMpy7PqmcqgJdXXGV3CBRifXcR6aYnN1n7U7eMsir0l6EALv34Bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c588cb2e-71b5-4d9c-8a91-587b13964fc2", "AQAAAAIAAYagAAAAECSJRJq+teBe5+tx8LUIWgDvsJY5KBm9mRZdIU41QrTGIopxfA2NcrTUE0j2u+hKVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eeed8cfc-e759-418c-8ce9-2fdefa689e4d", "AQAAAAIAAYagAAAAEDPLB1KahABesfvyCz7x/9mFdI/sjpzHyACYLedJv3g60bhg4e92IiNGGR/hY9A/pQ==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8432));
        }
    }
}
