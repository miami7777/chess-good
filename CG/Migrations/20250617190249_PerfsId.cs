using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class PerfsId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PerfsId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PerfsId" },
                values: new object[] { "62b22193-3e5e-4b67-9808-d2b355891bec", "AQAAAAIAAYagAAAAEF5SKIVLhqiiL/09A73S2kB8yL07+maLZQ/lYVC0R2zXLzaKnsiq2WVM+swsuB5oLQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PerfsId" },
                values: new object[] { "be6b876e-2400-412d-a186-e55d569120f6", "AQAAAAIAAYagAAAAEBAVTBxnN4/3O6eSk9O/r+yGukRjPA725TCo9llCFrRN/hr85rRR52FSumEIv18MPw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PerfsId" },
                values: new object[] { "72b9c263-1806-4923-9ae5-2b2a6525f929", "AQAAAAIAAYagAAAAEClmNgecOhyARG0NATzRydLjgf1roytQboCp4Tl0K4SCvkYETT+fRkBj9OZQYOXaKQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PerfsId" },
                values: new object[] { "1feb6567-a95b-453e-87dc-71743993b304", "AQAAAAIAAYagAAAAEOVi8ffVMbKxAameDzvPl/9nN8QTMIHORE9zEWG71xaNNhSq3XZr/8yWU2JCOp028g==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PerfsId" },
                values: new object[] { "eba36306-dc57-48db-abda-63f272f002c9", "AQAAAAIAAYagAAAAELwpmqSdIZu+XgokzrxFQQ4AThpaxFoPxjIZolUlT0rqIRZNRWej5UDjC6d8RMnZGw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PerfsId" },
                values: new object[] { "e92cea23-f727-4816-82e5-a4316f8e59d8", "AQAAAAIAAYagAAAAEHcIqQyDjAO1BHu3hm6sQJEWlSz+wHdtCD2BW7Ix2Cl4BXILnv3dDhk9+NyyS0XsJg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PerfsId" },
                values: new object[] { "b37420cc-e826-494e-bf6a-b32d1fc39be6", "AQAAAAIAAYagAAAAEJE2JrE/IACKigc2YbQCiS0PuY6+LsqXTKXOdTGXe30zvFIMWg/bWkHUStJgL+WFHA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PerfsId" },
                values: new object[] { "d574a25f-ef0e-46c7-b5d5-b58a2691e6e5", "AQAAAAIAAYagAAAAECilb2h9VVdLP2GdRZgAAf3qye8+o5DACuqN1VGKTkhV5kIWg6Bo5Tp/tkGmOavisA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PerfsId" },
                values: new object[] { "9f8cb050-94a7-4551-b15a-eb07ebaf2d45", "AQAAAAIAAYagAAAAEFvEUomj+pq56h5q5h6e3Uyh4pIXjg2jWchnW/RDqdNg1wKRb/j4xv58RfQrKLq9Ww==", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 19, 2, 48, 239, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PerfsId",
                table: "AspNetUsers",
                column: "PerfsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_perfs_PerfsId",
                table: "AspNetUsers",
                column: "PerfsId",
                principalTable: "perfs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_perfs_PerfsId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PerfsId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PerfsId",
                table: "AspNetUsers");

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
        }
    }
}
