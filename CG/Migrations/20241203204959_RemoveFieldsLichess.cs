using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class RemoveFieldsLichess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "profileLichesses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "profileLichesses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "profileLichesses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "perfsStatisticsLichesses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "perfsStatisticsLichesses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "perfsStatisticsLichesses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "perfsLichesses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "perfsLichesses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "perfsLichesses");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "profileLichesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "profileLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "perfsStatisticsLichesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "perfsStatisticsLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "perfsStatisticsLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "perfsLichesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "perfsLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "perfsLichesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abf15a38-0eac-4a3e-b3e0-2c828bb3f484", "AQAAAAIAAYagAAAAENV4jSJ45vFVmNNPkvQntBAZhm6wchI29X/1KYyp0w55LxPooS6H975E52vjORiOxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a95a1e7-39c0-4438-a516-5646c7280756", "AQAAAAIAAYagAAAAEKOqel1fGZdt4EclwHMdSf9WkAGlTlQYYr0C/6S6ucnAyaJxx9jZPc+2sHAUbqaX/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a584ef17-5e10-4dd3-8cbf-56972071ce3e", "AQAAAAIAAYagAAAAEExrjYInidoId4nnLJqxnyHq05u/ATI2xe9BfbswUmzAcplqfRK9iVI60/MSaPYsrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02f89d25-8861-4196-baad-cd256846b647", "AQAAAAIAAYagAAAAEEvE1JllB9p5f8RrW166D4VnwkoeVJmEsT+ZWldTsDS1DCSJXFqO1iTk5splvY2y0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf19aec7-d9e4-4c7b-8f2f-b6ad2668ec61", "AQAAAAIAAYagAAAAEAsgsxWNqXQafojmGZcSYTufTmkxprpWHXoT1XMMSWjX2LqLn04GJU6ftgLGCLUxIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f0662fc-9826-48c1-a16d-16bd99cfb61d", "AQAAAAIAAYagAAAAEGtud4mizAxRG0mdU/InYR04zvJpikaP2Tbnr1A3MU9zc+kb1ILZ/HoTigXsGKTTkA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eea11f56-fd9c-4078-9e63-b87424ef2a9c", "AQAAAAIAAYagAAAAEIdASqpJq+0tTvKxdhzzxxjsbuiWeG4Zmts7c38KqG0LkDz7KCB/U4kfmQLlPUOU5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6c9b0a4-4620-4d72-9210-0204c0cf3b2b", "AQAAAAIAAYagAAAAEKeGhOplwW+ZMnl0NaZ42qooOh0/SzjcKtXpUtT54eCQcTZEcenPNNYQ4vrwLVHglQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a68ac878-ede9-4683-a1dd-9665d452335e", "AQAAAAIAAYagAAAAENSRl9hfn+N8tii3Ia3WabHxISqqF4XZdpfSUamLW+dl6rmLP8zQ7uzCllhnxMLmwA==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 3, 20, 20, 26, 380, DateTimeKind.Utc).AddTicks(4232));
        }
    }
}
