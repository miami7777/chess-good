using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "DirectoryCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "DirectoryCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "DirectoryCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1af28189-b475-4f51-a4a1-dd3fadaad3e0", "AQAAAAIAAYagAAAAECeZtFiSxp5e8NpPhIprLKDQLsOM1WSsmKlShcily8uBW/YGoT/WfArQ6JEXsmPdOg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0779dec-a30d-4e1e-b3da-e43e6fdc6d4e", "AQAAAAIAAYagAAAAEJisvPhN//rQHtVgBtunWFjdlaJ+pVeeUwkVD9InvIGxNLj2yjONvtF9MuTayz5dMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7789ffbb-b2f0-4819-b10b-9dacb9e2b5f9", "AQAAAAIAAYagAAAAEJ6wUc57VQPQl3/idxFKD5f+pHP/5Kf2hELIQyG93wVraxGhfUsbiDBZz+wv7C6M9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de1d550a-be2d-43ca-a9b8-250cf9ec50b6", "AQAAAAIAAYagAAAAEMRoVg9mNA2BP0ZbLdYZfCUbk0RYOVZNBE10B63Fp7LAzLaAHrnJhbhDDKtMcacIaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ba62bcb-1968-445a-83d2-a51ebfdd8c9c", "AQAAAAIAAYagAAAAEFqnFhIkeUqsINy2Li7T5U0NVFPetkT/oj4IDlkOopJsGeVtJs8Wz+mcnS7bA1rnfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bec30a62-4eb1-42e7-bc26-54e3117560d3", "AQAAAAIAAYagAAAAENBgcx0JAM5jqg5ECkLSCHZNzFLggUYHdnBVODVLY4W+bcYBQeQkmf8zjYrrlQwYaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f9ea91b-dcf3-48f7-9e4f-67af812886b4", "AQAAAAIAAYagAAAAENBKfVjH5q5fI7dxy7l2e8Nr81+nk/N1uUWys3vc0a5AXx6QS0kigYzZmXCF5eylow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "adc427e1-0602-4db4-87ef-177e418cca1c", "AQAAAAIAAYagAAAAEJiAJI6yniQn8MSYdOCMozdLy92KC9/XKsYDkfo6sypZoR/b+wOkiTBw3FYEGX8iMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91ab7ee1-cbdf-4890-bbb3-4e58bef646d9", "AQAAAAIAAYagAAAAEHID9lye10jv4Vnp4WboLT7j5w0UQ+uxdhgoJEqwdhUDXFuzCat+CwzQsVtXYdtv0g==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 339, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 12, 11, 51, 15, 340, DateTimeKind.Utc).AddTicks(1749));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "DirectoryCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "DirectoryCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "DirectoryCategory",
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
                values: new object[] { "4cd2a561-dcf3-45a3-aaf6-39b88bf7d24b", "AQAAAAIAAYagAAAAEFW5ycUs+WUeILa6z1EvMHrjF23V1WlIcFkt5dfGniZtOrd2H0daKckrLlrkxhvh3Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "756f0367-68b2-428f-a50b-6b759a6c0cd8", "AQAAAAIAAYagAAAAEOqp1NFychZd/BlwnoxedIpCCNv24kNIJbTbD3IJ6QWpaEJo/qcsgBwACPboh/1UQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8442dc99-ed4b-40c4-b626-0f5f8bd63778", "AQAAAAIAAYagAAAAEBnfdmJ1lY+wU5X8//8HHO8I5mKImb8f6Eg+YePOd3ulkBdMe5rUEzQoYHRI0mK4aA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e80a4554-acab-471d-8ffc-5eba95052142", "AQAAAAIAAYagAAAAELWk93n8gqWx23uBwfrSgLu4cQPz1iW4g02df+HNmVvufvOkeGeZMOUA0RuT9YfXwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "794fd067-c567-4a81-a965-620f511e292d", "AQAAAAIAAYagAAAAEDbYnp1eclg6A/JkEnYqJ+PmjHkCWoGEblCxEE0rULQci8Z7qkN3HQW6jBlIA11NoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49a6b604-c963-4252-a67c-e9c630a0ea60", "AQAAAAIAAYagAAAAEFTcwwJW2bunHV9jhxDQHysOJW1oCncdwq8+HKWc/HAMrF2mIaqljzYbKk0qFLmjHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8999dd4-bb57-4163-b137-a9539f7aa2cc", "AQAAAAIAAYagAAAAEFsTN8gCIYWlDsmDIT4AgDqq5IK69aWiRJzWfeIQ/aFmndl6GhgO0OdxXwwZsbdmfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "681f3d97-24b3-46d5-baa7-cc9ae8ebd75d", "AQAAAAIAAYagAAAAEGl+9ek0bIY4gpLFot67N3DI6/OaSXgazS8DyIRpLUQQFs+h6o5/rzIaoG3lLqBamg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7306b57-f021-46e9-87a4-6f1af3b19c73", "AQAAAAIAAYagAAAAEHE0XiRlQR/5xyFfIwvXtDOKN2dlEREBu42vTEwsWZwIpC7Lw5+e/y0IgqLLVHA7BQ==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 279, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 49, 58, 278, DateTimeKind.Utc).AddTicks(9122));
        }
    }
}
