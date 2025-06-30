using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba3ab2d2-ab2f-4be6-9ede-211f59ff742f", "AQAAAAIAAYagAAAAEO+xKfxUFrG33Ghubvjv0EV2QZWmUpHpD3orJMyvUfTTz6a+bnROD8rU7o7MpBzVVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "344f3667-f245-474f-bcf9-99d2b029f18e", "AQAAAAIAAYagAAAAEAAkL3fSsJKuiGDwLdXq7qhKPjl4Jki9v5Vt+ROsRdqyvKqgf7UQt9KONaSuBlmYiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58a603d7-5fee-401d-98e5-a54b32129d95", "AQAAAAIAAYagAAAAELYkKFxfix/AcfbUMsY8con3hDu67d2gH3Za/tzJAXrTtUmLgIMjWaT0gdsphWSsmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23925719-6ae3-4fe3-afcb-b55074a6a33d", "AQAAAAIAAYagAAAAEM/q8fKpK5uY3p/rwJh3YBZ4Ec0ps58NICfAqnTETIevdrAOOHieq5aY7t9Ei8zqoQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "135cbfa9-e71e-476b-b744-c645e1be0cc4", "AQAAAAIAAYagAAAAEJekmiXqSfqy8pIfhm9yP69BuR4qUm+Y5wTyd7EX6bS9UCyBrNhuUmvbSGT8JoUjwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "379d2baa-a04a-4b8b-85fe-983ddcfd50ef", "AQAAAAIAAYagAAAAEBVUih3wRQ3iudoG567n7tYvtkF1xm4/o4RM1oHI9fJsROpvYDkBv8TV3B3+1wjLvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97ca4f6e-39ad-40c7-8c28-59979a6aed09", "AQAAAAIAAYagAAAAEBFJVK8DVhZP0twM8NZ5GPwbzvcKnx59qro3IhDT3NQGs8hiaEkiVHvdPYMw163KzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6687f78f-6c0e-4dd1-a2a4-0c3edd553aa3", "AQAAAAIAAYagAAAAEI5ZgeGt3AychYWzOotuxb0AmB0CD1y3TFzOnTtUwcdjCC2RSlXcRCAjZxojFN0OxQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66032d82-a20b-4bb8-9db7-2baa2cbdd9f0", "AQAAAAIAAYagAAAAENoXAj9WQisXFEC6I5BpXAnznOhP3Hd7UmpF9frkrBBTgh2a190KlMpF4KdfRsXyBA==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 18, 13, 38, 548, DateTimeKind.Utc).AddTicks(7009));
        }
    }
}
