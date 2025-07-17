using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFilesFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39e7e323-0a32-4a81-8a98-c67d59ab82be", "AQAAAAIAAYagAAAAEFxGaM625dJXbhDBVNL2LobIWYbsfgvUN8+OnD4vBWvNOFRi1Tw28xL5euTuHZlmIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32b95004-9f9b-49c0-bc7c-8ea3d91d0363", "AQAAAAIAAYagAAAAEFy1gyyyIOCR2E7R4/VzuOSuMJhxQv7XNNu458i7oojNFBD6aWZQqk/T2/vvOBNAqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce57e0e1-3f80-4a54-8443-9ab46f0455a7", "AQAAAAIAAYagAAAAEEIhyBLcvimZ+wqeC/Yp/CgEbdy+QKC5jqjdcM3SGT0sUrKjAEyqbGwyQzCSLq4i/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "102ed445-9b85-4bcf-9a19-4422f9d1a5aa", "AQAAAAIAAYagAAAAEGM2PbSKRRVktsBBwMSlqq6GTk6BLoQjGIg6vlQY852BInzmdskrGl29V5XH0NCh/Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c7024b7-e267-4ac3-b573-b9f614d69734", "AQAAAAIAAYagAAAAEGZ942/W2+YP11drNDvbsqTve89YUOjBo7Jg1o+q1fZwhRLMa5Kh1udn8r69tlWKyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62f1d6ca-6ed2-41a1-a4ae-93fec9cc2df9", "AQAAAAIAAYagAAAAENpS4eV5OYjK0nGE12XvdKsFH+vYnPTkr4bmK/e4drdZPArKWQfzFfSSesO3KJjWsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "746e2017-277b-4dcb-904a-f24d9e671ffe", "AQAAAAIAAYagAAAAEFr81bIKarbMkmmRQQGdBj06GYqsNL/bIDYp0nQPI+1XRUk6EretH2F7eZWsDAkRoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ceb5a34-3a71-4488-b400-100769333c40", "AQAAAAIAAYagAAAAEMw/qpWT/qYqSsIKrvSrB+0Ns7enYRUXqPad2Zo392OYRiL8f3U8vXAivkqYTzGSQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d39f57c4-03de-4a35-800e-0ccc894e2db1", "AQAAAAIAAYagAAAAEFx0bnaKFJOIJPY0aILmlqBdtx2+z3Ys6+TJqqQNS4nRCNyKMQmGX5cYfCOXD7qKVA==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "DirectoryCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "DirectoryStatusCourses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Webinars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 8, 56, 45, 13, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AvatarFilesId",
                table: "AspNetUsers",
                column: "AvatarFilesId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PreviewTrainerPhotoId",
                table: "AspNetUsers",
                column: "PreviewTrainerPhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TrainerPhotoId",
                table: "AspNetUsers",
                column: "TrainerPhotoId");

            migrationBuilder.AddForeignKey(
                name: "User_AvatarFiles_FK",
                table: "AspNetUsers",
                column: "AvatarFilesId",
                principalTable: "UserFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "User_PreviewTrainerPhotoFile_FK",
                table: "AspNetUsers",
                column: "PreviewTrainerPhotoId",
                principalTable: "UserFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "User_TrainerPhotoFile_FK",
                table: "AspNetUsers",
                column: "TrainerPhotoId",
                principalTable: "UserFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "User_AvatarFiles_FK",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "User_PreviewTrainerPhotoFile_FK",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "User_TrainerPhotoFile_FK",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AvatarFilesId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PreviewTrainerPhotoId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TrainerPhotoId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c385c4d-e26c-4d52-b427-21fab1cf6b30", "AQAAAAIAAYagAAAAEIvSvP0qDtSe9NfyO1vlzR8HFkGeec+VmVxme7e2/jxg6YD4Ot6Rez/5lNa8YxpGpA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d23ed234-5cc5-4f59-9345-ecdbebdad64d", "AQAAAAIAAYagAAAAEG0dgWcV0zPlD2EKkvT6iwBYaV9OlUDNt+VgkHr4Tk+L3NdQ8uvl40Aizqf+Zd9jsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2fc69175-5346-4c72-b775-bd397a880e84", "AQAAAAIAAYagAAAAEGKTNH81s+ee8NrlrknAma7zDTSR3CiA2+p/g4bWxX45JUPfMZPoVALwI+uENanY2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fe0d0b2-ae14-4b46-ba85-d3d146545f19", "AQAAAAIAAYagAAAAEP8AP7YuGoPhFVpKvhF0/MRBRWq9vFvOmm7c8Z69PX3y4SE3JkI9VmHz6DlCRzHkMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77829a8c-9b2b-4f47-9b0f-1ff98fb01fab", "AQAAAAIAAYagAAAAEHahu5Wpo2BEmSBFkYOdyv/yk5/c6sifUHjBVhLeqmulyZnlpfxPzgl9Is63uXnbRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae2c7cad-2baa-4fc9-8071-41288bd73a2d", "AQAAAAIAAYagAAAAENJBoQD5zIe0Wx3sbzVxqtEg6atEIGwWnnX6pacdQKqS6Rev64PhIxs+MqLnCcofkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18681c27-7540-4c69-b388-918fe2f77176", "AQAAAAIAAYagAAAAEKRPDeFiHjyMnXKFG9+t+F8J9sIj43vij6suKAmPWVxmsV8Y7oY5QX+kJs71i7nzsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f779ccd3-6f03-4b5a-9481-3e9b081eeba2", "AQAAAAIAAYagAAAAEG9PDAMbm2a+nolXRDDRnfJboCPTbJ2EEf/gllrcNrZiSeBMFg+Y8Rn9vJvpiT226Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "45c7e40f-f9cc-4ddb-9fa5-3e7e9537915c", "AQAAAAIAAYagAAAAEGQ9/5GY9YlxcTKyL3vvLydvvIGGV/MnNUheCZsEvUdwoPisk1bSoSabYhIdMfi3pQ==" });

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
        }
    }
}
