using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsTournament : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateStart",
                table: "Courses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Rated",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedDate", "DateStart", "Rated" },
                values: new object[] { new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8335), null, false });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateStart", "Rated" },
                values: new object[] { new DateTime(2024, 12, 14, 18, 41, 37, 221, DateTimeKind.Utc).AddTicks(8366), null, false });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateStart",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Rated",
                table: "Courses");

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
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 13, 20, 29, 49, 545, DateTimeKind.Utc).AddTicks(2092));

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
        }
    }
}
