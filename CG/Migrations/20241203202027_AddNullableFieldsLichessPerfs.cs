using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableFieldsLichessPerfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
