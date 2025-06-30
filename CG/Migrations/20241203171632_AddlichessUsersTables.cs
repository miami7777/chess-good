using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddlichessUsersTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LichessUserId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "perfsStatisticsLichesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Games = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    RD = table.Column<int>(type: "int", nullable: false),
                    Prog = table.Column<int>(type: "int", nullable: false),
                    Prov = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfsStatisticsLichesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "profileLichesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Realname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiderating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uscfRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ecfRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cfcRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dsbRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    links = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profileLichesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "perfsLichesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlitzId = table.Column<int>(type: "int", nullable: true),
                    RapidId = table.Column<int>(type: "int", nullable: true),
                    BulletId = table.Column<int>(type: "int", nullable: true),
                    ClassicalId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfsLichesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_perfsLichesses_perfsStatisticsLichesses_BlitzId",
                        column: x => x.BlitzId,
                        principalTable: "perfsStatisticsLichesses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_perfsLichesses_perfsStatisticsLichesses_BulletId",
                        column: x => x.BulletId,
                        principalTable: "perfsStatisticsLichesses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_perfsLichesses_perfsStatisticsLichesses_ClassicalId",
                        column: x => x.ClassicalId,
                        principalTable: "perfsStatisticsLichesses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_perfsLichesses_perfsStatisticsLichesses_RapidId",
                        column: x => x.RapidId,
                        principalTable: "perfsStatisticsLichesses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LichessUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdat = table.Column<long>(type: "bigint", nullable: false),
                    seenat = table.Column<long>(type: "bigint", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    PerfsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichessUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LichessUsers_perfsLichesses_PerfsId",
                        column: x => x.PerfsId,
                        principalTable: "perfsLichesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichessUsers_profileLichesses_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "profileLichesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "LichessUserId", "PasswordHash" },
                values: new object[] { "0fb55120-eeca-40f5-9378-9fc1befdbaec", null, "AQAAAAIAAYagAAAAECyEIa6HZG2A+trinRi9OdgSMkhUhS0PpGIynx5cz3XAGHeDKJDC4lNghmVr/g7BYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "LichessUserId", "PasswordHash" },
                values: new object[] { "a23f60b7-11a9-4a62-a8db-0ac11219462d", null, "AQAAAAIAAYagAAAAEKz4Wb03KV+EzFVScKdqjkFdldQvXgn/NAgh4M+VEfw0Z+1YZf/XGv8SVK5A2/qKVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "LichessUserId", "PasswordHash" },
                values: new object[] { "f4709e06-8172-4fb7-8ff9-2ac530b33b9e", null, "AQAAAAIAAYagAAAAEN3LyVJgvYTsudGFeLiwgaRkLKmDzhQAYCpLe9xPTqaGpZVyTWUWwWO7Kf82zcEOEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "LichessUserId", "PasswordHash" },
                values: new object[] { "424cf284-3317-44da-88dd-1f0dd2a7bba0", null, "AQAAAAIAAYagAAAAEDt1HVuKTCDqxr4EtEAPLHEahmKx4q/E2mZL6dJ74ia0PSCIlzoPUV5UnTp/x0tq6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "LichessUserId", "PasswordHash" },
                values: new object[] { "5c0fe3a5-9188-4bac-bcfa-7cba547cf092", null, "AQAAAAIAAYagAAAAECtKqVhSHVdKU5QCbhasZvkt8jpTU0EswfDsQ0HabQzacW4ulJRPVWqAPbZqgNxbcA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "LichessUserId", "PasswordHash" },
                values: new object[] { "56abb40d-8d8e-4fa9-8222-6c89fbd7cc8d", null, "AQAAAAIAAYagAAAAEHgLml/ByY/oQ2Ir8HXyZg1LramvhTHQAOk/9dkClHVMs5/rBkQlmO+q/y+eRhio8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "LichessUserId", "PasswordHash" },
                values: new object[] { "afdb90f9-ba79-47a8-aaf1-c769cc772616", null, "AQAAAAIAAYagAAAAEN6DU0JsyJFxpHnK+GMMr3lrnkf7oxjei7gGNXGn7+ki3R6Y7KoEF9e2iX+Ku0cJWg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "LichessUserId", "PasswordHash" },
                values: new object[] { "43d60570-bf97-4908-bf51-ec1567f547f4", null, "AQAAAAIAAYagAAAAEMm9iauSGIZa0uisFejEWJME26gb8RrspGLS0ZCSD9i01tIZ1W39MZtt9VFzTzMREQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "LichessUserId", "PasswordHash" },
                values: new object[] { "002f1789-7273-41ed-989a-e900813d49d6", null, "AQAAAAIAAYagAAAAEOgCH4VnUgILpQweswrp3Dy8vm5++9RDVJk3tu3hkF1HFuJ6Dkj0JbYaJDByfQTwbA==" });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LichessUserId",
                table: "AspNetUsers",
                column: "LichessUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LichessUsers_PerfsId",
                table: "LichessUsers",
                column: "PerfsId");

            migrationBuilder.CreateIndex(
                name: "IX_LichessUsers_ProfileId",
                table: "LichessUsers",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_perfsLichesses_BlitzId",
                table: "perfsLichesses",
                column: "BlitzId");

            migrationBuilder.CreateIndex(
                name: "IX_perfsLichesses_BulletId",
                table: "perfsLichesses",
                column: "BulletId");

            migrationBuilder.CreateIndex(
                name: "IX_perfsLichesses_ClassicalId",
                table: "perfsLichesses",
                column: "ClassicalId");

            migrationBuilder.CreateIndex(
                name: "IX_perfsLichesses_RapidId",
                table: "perfsLichesses",
                column: "RapidId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_LichessUsers_LichessUserId",
                table: "AspNetUsers",
                column: "LichessUserId",
                principalTable: "LichessUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_LichessUsers_LichessUserId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LichessUsers");

            migrationBuilder.DropTable(
                name: "perfsLichesses");

            migrationBuilder.DropTable(
                name: "profileLichesses");

            migrationBuilder.DropTable(
                name: "perfsStatisticsLichesses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LichessUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LichessUserId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31f101a3-8e16-4ef6-b4c7-3914a982ffa1", "AQAAAAIAAYagAAAAEFKUI7J3g8QpwW48A0tFMFon6hD2LhSpxg2vwheqznhvNtIx+sVNb6ox7iBtE5KWMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "429d841a-0429-413c-864d-54527850137a", "AQAAAAIAAYagAAAAEH8El5Ig9sEbfv2SMl3Z2XCN4lCQMTxU1e4khI0cJqRaNfdTTh+4HHSI0oWOjpZveQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cfce239-f0e7-4fc9-bb4c-4559b80cc160", "AQAAAAIAAYagAAAAEExUizw4aamc6Uihe2QkRzOhun+/SJaYdDtTGkKNSHT4MA82gvwdYEKHeZF5suj7cg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5517e3c4-1c06-4f21-b2e9-b9a3ddb35966", "AQAAAAIAAYagAAAAEOjh+6XH/H63xm2A6F1SlEXpCLblcETOaIBKzpszfbvxFHM9Bn6sUUImtBOd2Gi7qQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d3563f0-1438-4e54-829e-c701a195f17c", "AQAAAAIAAYagAAAAEEowfjmT0bpj2Rh7IodFm0prqSJ5bFclfAJsoYZBHweejA/MYHnBcVM+di7/5HINvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cb948c4-1705-4ecb-9ae8-4ff3719d138d", "AQAAAAIAAYagAAAAEL8sXQxmvgSHlYCKLS3O+O5onFfy8R3jg8HhpudI9lpaWBovUzuiH8xbZ0QjLDs7yA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "011044f2-b351-4886-84b8-c0cc22e4c7e9", "AQAAAAIAAYagAAAAEDW+C5IHZrW//j+3zIetdYTLYIUVU5aBfVLniFdLtfY/+giVU1gZnIX0tUG8LYUT5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49548ffa-f4a3-4f3f-a543-92b03e4a3bc0", "AQAAAAIAAYagAAAAEOL7ALmuNw7AlZse50QjfpKwl1NZ/qiBi5f9+OVPtcnnPt7/5l0t2NdL0KC2gDym7w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f345b577-f580-4a59-bb45-7df31fd332cc", "AQAAAAIAAYagAAAAELMR5h59T/v8n2oYFWksVovvDgf+uQOWOFo6xfiKZLInV3tELIj3AEBxJAQs1Hgwig==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 16, 12, 36, 54, 707, DateTimeKind.Utc).AddTicks(6606));
        }
    }
}
