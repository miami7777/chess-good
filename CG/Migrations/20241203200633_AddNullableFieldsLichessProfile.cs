using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableFieldsLichessProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "uscfRating",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "links",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ecfRating",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "dsbRating",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cfcRating",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Realname",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Flag",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Fiderating",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f308846-77f5-41de-866a-e608db78e428", "AQAAAAIAAYagAAAAEL28XW8gn7Z4ozWVzSPR4KjHvcslcQ6wtEH08uUG9rHT0zKT3GG96lrgD/XhEGohvQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2cfda902-f766-4fac-a89a-26c39ae6ba94", "AQAAAAIAAYagAAAAENA+z0xb5HdPgWADzmJ+wHDsvqzbuJ+9ZGWtSEUWhzzRf28VtZHw8jMWEMemewDyEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d246e1a-e477-4310-adac-73671c0466d5", "AQAAAAIAAYagAAAAEHKtgKGn+wq18zlv9eHJiSbxTP6/O0MouaJGgeRaYcz+bwzSYSBn6qM1CaSkxEz6lQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "590472ea-55ea-49e2-b011-7d36f696548d", "AQAAAAIAAYagAAAAEJ+/x+i4j4pEuQ/kUtvs1KK/0a0pZNoXv27Ua5zawb36wZwQ7fKYyU3rlZ3PtAWiqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8472023-5dba-4818-8e56-b9b63a454a6a", "AQAAAAIAAYagAAAAEKHCII7iAN9WMXOg5yQsry81hye9M3S06SGZYzS6YDDd5oMeOeotwPtrepAflIrqxQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54a1b51d-7a28-4f4f-8092-66873a7699f5", "AQAAAAIAAYagAAAAEBEB1xYzSnGK2VIK8MlQ+R/O26gzHJQLfkZGeuhkgAEgv7Ln8tKUDHruvTI44U4T9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a2e26c1-b021-4483-a01a-934ab09d9d22", "AQAAAAIAAYagAAAAEFg7yekL3SJ0TA5mkOTgHAKctnEWoFHqqp7GzTDh1h1nQf1BZEDFU6DVUhcGN/Wq/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5274d07c-9e2b-4d9e-a48a-51a70a645e90", "AQAAAAIAAYagAAAAEO1BHZncY2ay0IrZl/CFCnpcjQVK2BUeT0kXdcaFDbHSwn912AWcX13maTAi55eMnw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f9796fb-3e13-4ccd-b601-fdf4a5257dd4", "AQAAAAIAAYagAAAAEDLqc6uvkSJCOzC/bpCeW7Nj1EiZ0xP87M9fGWJGpZNVKNK7NzE4/Eg+vGSPTfEWrQ==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 6, 32, 629, DateTimeKind.Utc).AddTicks(6601));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "uscfRating",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "links",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ecfRating",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dsbRating",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cfcRating",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Realname",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Flag",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Fiderating",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9c49bfc-4c6d-464c-b2fd-aaf89964753b", "AQAAAAIAAYagAAAAEDVGpsATI2glDdRDGf4aEVgkFpMdq+h2aID2sm7QIf2iieMjtJ9zxraEZfCUc6OehA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7f81f64-57c3-426c-88f4-1a6065fc9f05", "AQAAAAIAAYagAAAAEOJ+URErmayUVL7ymaug3S1vjaml40fKZFb/ECfwi7SZzQ2/wtwq0S41G7T15Af+kg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff2b3f74-2f7f-47b8-81a5-fb9edbbd5741", "AQAAAAIAAYagAAAAECq1Ugr8S5r+Z0LALy6N3xerqbRkTLKFenk4T7va6SJqSvYQOUDYzkKycw/MKnY7Tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa9408e3-c0bf-47a1-965e-70d051d13c52", "AQAAAAIAAYagAAAAEAYqdi8s+y/tjKtnUIDxtR7E31KrLBHZKUDEmvMkeYTcZTeEZ37JWGWLXG6M34a6KA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36def1fe-e92f-4c9b-955b-9fc8d3851b33", "AQAAAAIAAYagAAAAEOdKew2B2vW1ohnOnCnyK0RQ+ORukDMtUQlIjvdx2trf2rlFlsstNhgUmUuxJqqr/A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2d5e9e2-a9c1-4496-b8f5-64cdb7be78c1", "AQAAAAIAAYagAAAAEEuiav+ZCEMEnmraCJSfWG9IIsQy2s5+qgQFTcPzE0g8Dyi6GZ72C0zhgOLVnT6/Pg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "667ee5a4-7bbc-44eb-9efc-e85b26bdf3ab", "AQAAAAIAAYagAAAAEIu6sZrT5F6bwku8Ge4y9YCYgAUayx9u6wFR57OCd2dE6JUBHz7x6bYmp2dMEEWXlg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d44eb30c-9aaa-447c-b623-82e022e3c577", "AQAAAAIAAYagAAAAEOtlQ3nEqX8qTnls2XMnSG0mfb+4bV9oZHOwR7rcQrIG0JixrO7IM+yLcBYQYYrcQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe4c9406-d0a1-4f8f-b7bf-1ff5d99710d0", "AQAAAAIAAYagAAAAEJPkgYBR5++mZfYsVXtWcycgZqQqDHnBIq6pviE7fuhTRNsmFcCXYNmVNKnI544L7g==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 55, 17, 397, DateTimeKind.Utc).AddTicks(4894));
        }
    }
}
