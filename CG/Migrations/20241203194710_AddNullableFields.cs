using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LichessUsers_perfsLichesses_PerfsId",
                table: "LichessUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_LichessUsers_profileLichesses_ProfileId",
                table: "LichessUsers");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "LichessUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PerfsId",
                table: "LichessUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_LichessUsers_perfsLichesses_PerfsId",
                table: "LichessUsers",
                column: "PerfsId",
                principalTable: "perfsLichesses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LichessUsers_profileLichesses_ProfileId",
                table: "LichessUsers",
                column: "ProfileId",
                principalTable: "profileLichesses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LichessUsers_perfsLichesses_PerfsId",
                table: "LichessUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_LichessUsers_profileLichesses_ProfileId",
                table: "LichessUsers");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "LichessUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PerfsId",
                table: "LichessUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0fb55120-eeca-40f5-9378-9fc1befdbaec", "AQAAAAIAAYagAAAAECyEIa6HZG2A+trinRi9OdgSMkhUhS0PpGIynx5cz3XAGHeDKJDC4lNghmVr/g7BYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a23f60b7-11a9-4a62-a8db-0ac11219462d", "AQAAAAIAAYagAAAAEKz4Wb03KV+EzFVScKdqjkFdldQvXgn/NAgh4M+VEfw0Z+1YZf/XGv8SVK5A2/qKVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4709e06-8172-4fb7-8ff9-2ac530b33b9e", "AQAAAAIAAYagAAAAEN3LyVJgvYTsudGFeLiwgaRkLKmDzhQAYCpLe9xPTqaGpZVyTWUWwWO7Kf82zcEOEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "424cf284-3317-44da-88dd-1f0dd2a7bba0", "AQAAAAIAAYagAAAAEDt1HVuKTCDqxr4EtEAPLHEahmKx4q/E2mZL6dJ74ia0PSCIlzoPUV5UnTp/x0tq6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c0fe3a5-9188-4bac-bcfa-7cba547cf092", "AQAAAAIAAYagAAAAECtKqVhSHVdKU5QCbhasZvkt8jpTU0EswfDsQ0HabQzacW4ulJRPVWqAPbZqgNxbcA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56abb40d-8d8e-4fa9-8222-6c89fbd7cc8d", "AQAAAAIAAYagAAAAEHgLml/ByY/oQ2Ir8HXyZg1LramvhTHQAOk/9dkClHVMs5/rBkQlmO+q/y+eRhio8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afdb90f9-ba79-47a8-aaf1-c769cc772616", "AQAAAAIAAYagAAAAEN6DU0JsyJFxpHnK+GMMr3lrnkf7oxjei7gGNXGn7+ki3R6Y7KoEF9e2iX+Ku0cJWg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43d60570-bf97-4908-bf51-ec1567f547f4", "AQAAAAIAAYagAAAAEMm9iauSGIZa0uisFejEWJME26gb8RrspGLS0ZCSD9i01tIZ1W39MZtt9VFzTzMREQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "002f1789-7273-41ed-989a-e900813d49d6", "AQAAAAIAAYagAAAAEOgCH4VnUgILpQweswrp3Dy8vm5++9RDVJk3tu3hkF1HFuJ6Dkj0JbYaJDByfQTwbA==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 17, 16, 31, 583, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.AddForeignKey(
                name: "FK_LichessUsers_perfsLichesses_PerfsId",
                table: "LichessUsers",
                column: "PerfsId",
                principalTable: "perfsLichesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LichessUsers_profileLichesses_ProfileId",
                table: "LichessUsers",
                column: "ProfileId",
                principalTable: "profileLichesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
