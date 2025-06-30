using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "LichessUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "LichessUsers",
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
                values: new object[] { "ff3c1f99-72e6-4524-b294-16c1600403d6", "AQAAAAIAAYagAAAAEPIe5eTm0rtQN34GcdWTDMzil0yfJGPDbXXYuyo5FyH5o7sIYpf0CW+WgZVr0Jf1Uw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b272d79e-c9aa-493e-a584-573ba38cb5ec", "AQAAAAIAAYagAAAAEPBVlOIwgERy+pknCEtybRmbi6KTct6so4+0q8D/Mzlol6TE3uCeKyd6iJZuNFaKKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb52623d-52c5-4649-9c5b-0906d1597b5a", "AQAAAAIAAYagAAAAEDAAV0DyMUivH1jLKa2QwATNwmsQ1tVBJ2aSG4p2kbfLaKpvyiZzLakXX14YDjrvTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebc6e2e8-683d-4f35-9f5e-4ad76dac2e01", "AQAAAAIAAYagAAAAEE8ZfyQM+Orwn6jKz/7nIFFZDRER4JuCHEtxMgms2zuL4wBvQzYLRI45oVPpkasvzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d3e023b-009e-4e23-ab76-0956c80d4c49", "AQAAAAIAAYagAAAAEGtfS8/WJvC/nhD11IRiJSdvzF8A/t4cBeXwwYL5CqOKMD7TZgrJRWgMYgw2Z1DlDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a352014-7a21-45ba-a22a-05c5cc6761f6", "AQAAAAIAAYagAAAAEHfE+nBh5gxZmFwli+bsUZB8UuEmaerueJq8P/KPKPSujYiSIXcjFOBT/V1zf++flQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a1ce2d7-2bf0-453d-bb63-bf689b486c2d", "AQAAAAIAAYagAAAAEGpUN+Gkqih+98PmHfzoqNfw/tRX1iwzUK7KZ0WPuY5mtwWJNZytD7tqKODPsLuEgA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87df7b19-828f-46c0-87d9-2497a45f4287", "AQAAAAIAAYagAAAAEN8XGRwcLsVQDf9szjpWO5sdcvBPmtP8r1QVC3nwkJJbtYxAOssn1+CMGRx8Fx52Hg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "829e860b-19b0-4068-ae06-0f6ef0583252", "AQAAAAIAAYagAAAAEPSsUMuh4BLckghNb2Rp1Z4iakUE7r/Du845ZwOJme5/OjeYgk4hk937w87NpQfwEg==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 132, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 132, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 132, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 132, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 132, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 132, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 132, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 19, 47, 10, 131, DateTimeKind.Utc).AddTicks(8967));
        }
    }
}
