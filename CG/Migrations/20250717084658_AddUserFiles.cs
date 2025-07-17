using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvatarFilesId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreviewTrainerPhotoId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainerPhotoId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileContentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TypeUserFiles = table.Column<int>(type: "int", nullable: false),
                    OfferThumbNail = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "organizer", "ORGANIZER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "member", "MEMBER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "AvatarFilesId", "ConcurrencyStamp", "PasswordHash", "PreviewTrainerPhotoId", "TrainerPhotoId" },
                values: new object[] { null, "9c385c4d-e26c-4d52-b427-21fab1cf6b30", "AQAAAAIAAYagAAAAEIvSvP0qDtSe9NfyO1vlzR8HFkGeec+VmVxme7e2/jxg6YD4Ot6Rez/5lNa8YxpGpA==", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "AvatarFilesId", "ConcurrencyStamp", "PasswordHash", "PreviewTrainerPhotoId", "TrainerPhotoId" },
                values: new object[] { null, "d23ed234-5cc5-4f59-9345-ecdbebdad64d", "AQAAAAIAAYagAAAAEG0dgWcV0zPlD2EKkvT6iwBYaV9OlUDNt+VgkHr4Tk+L3NdQ8uvl40Aizqf+Zd9jsg==", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "AvatarFilesId", "ConcurrencyStamp", "PasswordHash", "PreviewTrainerPhotoId", "TrainerPhotoId" },
                values: new object[] { null, "2fc69175-5346-4c72-b775-bd397a880e84", "AQAAAAIAAYagAAAAEGKTNH81s+ee8NrlrknAma7zDTSR3CiA2+p/g4bWxX45JUPfMZPoVALwI+uENanY2g==", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "AvatarFilesId", "ConcurrencyStamp", "PasswordHash", "PreviewTrainerPhotoId", "TrainerPhotoId" },
                values: new object[] { null, "3fe0d0b2-ae14-4b46-ba85-d3d146545f19", "AQAAAAIAAYagAAAAEP8AP7YuGoPhFVpKvhF0/MRBRWq9vFvOmm7c8Z69PX3y4SE3JkI9VmHz6DlCRzHkMQ==", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "AvatarFilesId", "ConcurrencyStamp", "PasswordHash", "PreviewTrainerPhotoId", "TrainerPhotoId" },
                values: new object[] { null, "77829a8c-9b2b-4f47-9b0f-1ff98fb01fab", "AQAAAAIAAYagAAAAEHahu5Wpo2BEmSBFkYOdyv/yk5/c6sifUHjBVhLeqmulyZnlpfxPzgl9Is63uXnbRg==", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "AvatarFilesId", "ConcurrencyStamp", "PasswordHash", "PreviewTrainerPhotoId", "TrainerPhotoId" },
                values: new object[] { null, "ae2c7cad-2baa-4fc9-8071-41288bd73a2d", "AQAAAAIAAYagAAAAENJBoQD5zIe0Wx3sbzVxqtEg6atEIGwWnnX6pacdQKqS6Rev64PhIxs+MqLnCcofkQ==", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "AvatarFilesId", "ConcurrencyStamp", "PasswordHash", "PreviewTrainerPhotoId", "TrainerPhotoId" },
                values: new object[] { null, "18681c27-7540-4c69-b388-918fe2f77176", "AQAAAAIAAYagAAAAEKRPDeFiHjyMnXKFG9+t+F8J9sIj43vij6suKAmPWVxmsV8Y7oY5QX+kJs71i7nzsg==", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "AvatarFilesId", "ConcurrencyStamp", "PasswordHash", "PreviewTrainerPhotoId", "TrainerPhotoId" },
                values: new object[] { null, "f779ccd3-6f03-4b5a-9481-3e9b081eeba2", "AQAAAAIAAYagAAAAEG9PDAMbm2a+nolXRDDRnfJboCPTbJ2EEf/gllrcNrZiSeBMFg+Y8Rn9vJvpiT226Q==", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "AvatarFilesId", "ConcurrencyStamp", "PasswordHash", "PreviewTrainerPhotoId", "TrainerPhotoId" },
                values: new object[] { null, "45c7e40f-f9cc-4ddb-9fa5-3e7e9537915c", "AQAAAAIAAYagAAAAEGQ9/5GY9YlxcTKyL3vvLydvvIGGV/MnNUheCZsEvUdwoPisk1bSoSabYhIdMfi3pQ==", null, null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 46, 56, 843, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.CreateIndex(
                name: "IX_UserFiles_UserId",
                table: "UserFiles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFiles");

            migrationBuilder.DropColumn(
                name: "AvatarFilesId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PreviewTrainerPhotoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TrainerPhotoId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "trainer", "TRAINER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "student", "STUDENT" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62b22193-3e5e-4b67-9808-d2b355891bec", "AQAAAAIAAYagAAAAEF5SKIVLhqiiL/09A73S2kB8yL07+maLZQ/lYVC0R2zXLzaKnsiq2WVM+swsuB5oLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be6b876e-2400-412d-a186-e55d569120f6", "AQAAAAIAAYagAAAAEBAVTBxnN4/3O6eSk9O/r+yGukRjPA725TCo9llCFrRN/hr85rRR52FSumEIv18MPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72b9c263-1806-4923-9ae5-2b2a6525f929", "AQAAAAIAAYagAAAAEClmNgecOhyARG0NATzRydLjgf1roytQboCp4Tl0K4SCvkYETT+fRkBj9OZQYOXaKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1feb6567-a95b-453e-87dc-71743993b304", "AQAAAAIAAYagAAAAEOVi8ffVMbKxAameDzvPl/9nN8QTMIHORE9zEWG71xaNNhSq3XZr/8yWU2JCOp028g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eba36306-dc57-48db-abda-63f272f002c9", "AQAAAAIAAYagAAAAELwpmqSdIZu+XgokzrxFQQ4AThpaxFoPxjIZolUlT0rqIRZNRWej5UDjC6d8RMnZGw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e92cea23-f727-4816-82e5-a4316f8e59d8", "AQAAAAIAAYagAAAAEHcIqQyDjAO1BHu3hm6sQJEWlSz+wHdtCD2BW7Ix2Cl4BXILnv3dDhk9+NyyS0XsJg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b37420cc-e826-494e-bf6a-b32d1fc39be6", "AQAAAAIAAYagAAAAEJE2JrE/IACKigc2YbQCiS0PuY6+LsqXTKXOdTGXe30zvFIMWg/bWkHUStJgL+WFHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d574a25f-ef0e-46c7-b5d5-b58a2691e6e5", "AQAAAAIAAYagAAAAECilb2h9VVdLP2GdRZgAAf3qye8+o5DACuqN1VGKTkhV5kIWg6Bo5Tp/tkGmOavisA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f8cb050-94a7-4551-b15a-eb07ebaf2d45", "AQAAAAIAAYagAAAAEFvEUomj+pq56h5q5h6e3Uyh4pIXjg2jWchnW/RDqdNg1wKRb/j4xv58RfQrKLq9Ww==" });

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
        }
    }
}
