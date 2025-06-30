using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldProfileLichess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileLichess",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileLichess" },
                values: new object[] { "31f101a3-8e16-4ef6-b4c7-3914a982ffa1", "AQAAAAIAAYagAAAAEFKUI7J3g8QpwW48A0tFMFon6hD2LhSpxg2vwheqznhvNtIx+sVNb6ox7iBtE5KWMg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileLichess" },
                values: new object[] { "429d841a-0429-413c-864d-54527850137a", "AQAAAAIAAYagAAAAEH8El5Ig9sEbfv2SMl3Z2XCN4lCQMTxU1e4khI0cJqRaNfdTTh+4HHSI0oWOjpZveQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileLichess" },
                values: new object[] { "0cfce239-f0e7-4fc9-bb4c-4559b80cc160", "AQAAAAIAAYagAAAAEExUizw4aamc6Uihe2QkRzOhun+/SJaYdDtTGkKNSHT4MA82gvwdYEKHeZF5suj7cg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileLichess" },
                values: new object[] { "5517e3c4-1c06-4f21-b2e9-b9a3ddb35966", "AQAAAAIAAYagAAAAEOjh+6XH/H63xm2A6F1SlEXpCLblcETOaIBKzpszfbvxFHM9Bn6sUUImtBOd2Gi7qQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileLichess" },
                values: new object[] { "4d3563f0-1438-4e54-829e-c701a195f17c", "AQAAAAIAAYagAAAAEEowfjmT0bpj2Rh7IodFm0prqSJ5bFclfAJsoYZBHweejA/MYHnBcVM+di7/5HINvw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileLichess" },
                values: new object[] { "6cb948c4-1705-4ecb-9ae8-4ff3719d138d", "AQAAAAIAAYagAAAAEL8sXQxmvgSHlYCKLS3O+O5onFfy8R3jg8HhpudI9lpaWBovUzuiH8xbZ0QjLDs7yA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileLichess" },
                values: new object[] { "011044f2-b351-4886-84b8-c0cc22e4c7e9", "AQAAAAIAAYagAAAAEDW+C5IHZrW//j+3zIetdYTLYIUVU5aBfVLniFdLtfY/+giVU1gZnIX0tUG8LYUT5w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileLichess" },
                values: new object[] { "49548ffa-f4a3-4f3f-a543-92b03e4a3bc0", "AQAAAAIAAYagAAAAEOL7ALmuNw7AlZse50QjfpKwl1NZ/qiBi5f9+OVPtcnnPt7/5l0t2NdL0KC2gDym7w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileLichess" },
                values: new object[] { "f345b577-f580-4a59-bb45-7df31fd332cc", "AQAAAAIAAYagAAAAELMR5h59T/v8n2oYFWksVovvDgf+uQOWOFo6xfiKZLInV3tELIj3AEBxJAQs1Hgwig==", null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileLichess",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "551789c3-79af-427d-96e4-1286462298d5", "AQAAAAIAAYagAAAAEHBfNypMRuP7LG5FkH7pT1lGiexcG897zZdyZu/8df807jdzx4lH20I0+cWJD5+lHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99acefe1-cac3-4aef-a8b5-68bfb1b0a694", "AQAAAAIAAYagAAAAELthBqc91NotQ7Y2jEAjuU2psNY0AHS3cORk347iX4lBhFphyhJhDVboZrahXuZ7iQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2de32c6-2fac-45ed-a38c-505b6e580a00", "AQAAAAIAAYagAAAAEMtPoMTHrTyIdjlf7j5jDaLHOgmW9hIGzgGrkUmvq3obmJ8cNz6zF+B1TEVkofyo+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dcd63034-4673-48c3-b2e3-167770543d9c", "AQAAAAIAAYagAAAAEOAB5BhEF82anB6I+yKgi6udJpFxElBdrTLhFrbmgpzAcKt9wqmoMqomYNeHdj/siw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e95532b3-e2b0-476c-a4ae-3ac56634d411", "AQAAAAIAAYagAAAAECtivW/jZI8Ad6YUOJ3t3rJbk9KrZzgTuPgPd3uqBcmTfrGwoTPOvJlmojMdoS6zaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cf8230f-0cee-418c-aa45-787d0b66b9fe", "AQAAAAIAAYagAAAAEMheMxTSux9u14EsN2VRHWXC2WOD1mrNvZA3jD86BMNYwLBRhc6zkGvQipBsgS8CVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34555710-2269-4dce-88e3-f9bda307caba", "AQAAAAIAAYagAAAAEDN7rAn6sgPnPXgmtRr+zwXQvoquif0KnAiu1NFPPW50xY0SVJD0FLMz+U9dIOXj+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5952fa7-855f-4745-baac-01c11596bbe7", "AQAAAAIAAYagAAAAEC+nqjeC/ZbLeYNpulRarlo5lLZCHOUGz1FOhPV4HVBPu4Hq9rFPQHaz2v5DtWVkyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "382ba878-1ced-43e3-bb2d-2fec32cc9baf", "AQAAAAIAAYagAAAAEBL7RTWAbRBk1Hmt2pIjg7jKprE9nNMIqRAVPT3nXRwg+IImqK5bx4QTdDMIE94DFQ==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 19, 54, 45, 54, DateTimeKind.Utc).AddTicks(4681));
        }
    }
}
