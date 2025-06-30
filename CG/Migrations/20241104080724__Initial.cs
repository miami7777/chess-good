using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class _Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoryCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListOrder = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoryCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoryStatusCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ListOrder = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoryStatusCourses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ListOrder = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentsTrainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsTrainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tariffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceMonth = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    PriceYear = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    ServicesIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdvanced = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tariffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DismissDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    DateBirthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChessTitle = table.Column<int>(type: "int", nullable: true),
                    Stage = table.Column<int>(type: "int", nullable: true),
                    Trophy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainerPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviewTrainerPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartStudy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndStudy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YearReceiveTitle = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    TrainerId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_StudentsTrainers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentsTrainers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_StudentsTrainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "StudentsTrainers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TariffsId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Tariffs_TariffsId",
                        column: x => x.TariffsId,
                        principalTable: "Tariffs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    StartTimeCourse = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTimeCourse = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeCourse = table.Column<int>(type: "int", nullable: false),
                    Purchases = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_DirectoryCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "DirectoryCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_DirectoryStatusCourses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "DirectoryStatusCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Webinars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TypeWebinar = table.Column<int>(type: "int", nullable: false),
                    StartTimeWebinar = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTimeWebinar = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Purchases = table.Column<int>(type: "int", nullable: false),
                    AvailableSeats = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    ImageWebinar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviewImageWebinar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Webinars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Webinars_AspNetUsers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Webinars_DirectoryCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "DirectoryCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Webinars_DirectoryStatusCourses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "DirectoryStatusCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    FileContentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TypeCourseFiles = table.Column<int>(type: "int", nullable: false),
                    OfferThumbNail = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseFiles_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NavigationTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChapterPreviewId = table.Column<int>(type: "int", nullable: true),
                    ChapterVideoId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                    table.ForeignKey(
                        name: "Chapters_PreviewCourseFiles_FK1",
                        column: x => x.ChapterPreviewId,
                        principalTable: "CourseFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Chapters_VideoCourseFiles_FK1",
                        column: x => x.ChapterVideoId,
                        principalTable: "CourseFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseDetails_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseDetails_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "admin", "ADMIN" },
                    { "2", null, "organizer", "ORGANIZER" },
                    { "3", null, "user", "USER" },
                    { "4", null, "member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ChessTitle", "City", "ConcurrencyStamp", "Country", "DateBirthday", "DismissDate", "Email", "EmailConfirmed", "EndStudy", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Patronymic", "PhoneNumber", "PhoneNumberConfirmed", "PreviewTrainerPhoto", "Profile", "Rating", "Region", "SecurityStamp", "Sex", "Stage", "StartStudy", "StudentId", "Surname", "TrainerId", "TrainerPhoto", "Trophy", "TwoFactorEnabled", "UserName", "YearReceiveTitle" },
                values: new object[,]
                {
                    { "1", 0, "avatar-3.jpg", null, null, "dade7352-99d8-4d59-97da-e20589a4e172", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin@admin.ru", true, null, false, null, "Максим", "ADMIN@ADMIN.RU", "ADMIN", "AQAAAAIAAYagAAAAENBWiQ7LmE/0iACzh4rOExb4IASRdM7Ud5uVQll7pQf8i9IEDd5iag83e5ReecFH7w==", "Владимирович", null, false, null, null, null, null, "", 0, null, null, null, "Королёв", null, null, null, false, "admin", null },
                    { "2", 0, "avatar-3.jpg", null, "Ставрополь", "da421212-58c3-4a1e-92e0-252bb023541a", "Россия", new DateTime(1983, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "trainer@trainer.ru", true, null, false, null, "Максим", "TRAINER@TRAINER.RU", "TRAINER1", "AQAAAAIAAYagAAAAEHf7uKDdilwT1H4dfCQy36x3ZYjgQhjecb9sODwCPBPGS66Jnxh/uTOnfaaiyCTXJQ==", "Владимирович", null, false, "trainer-6.jpg", "team-9.jpg", null, "Ставропольский край", "", 0, null, null, null, "Королёв", null, null, null, false, "trainer1", null },
                    { "3", 0, "avatar-1.jpg", 7, "Краснодар", "8539d257-4c91-4a22-8c9d-e74f59aa439d", "Россия", new DateTime(1998, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "trainer@trainer.ru", true, null, false, null, "Майя", "TRAINER@TRAINER.RU", "TRAINER2", "AQAAAAIAAYagAAAAEK5hItGnWVGkAWjL63sVCVfUjOi62pl2jInBkFoCOMVICPXwF8IXAJYwaWuVH9OGFA==", "Владимировна", null, false, "trainer-4.jpg", "team-7.jpg", null, "Краснодарский край", "", 1, null, null, null, "Порожняк", null, "trainer-1-3.jpg", "Чемпионка Краснодарского края 2022 года", false, "trainer2", null },
                    { "4", 0, "avatar-2.jpg", null, "Ростов-на-Дону", "02c7a3a2-9f8a-4757-9b25-6c5d700592ab", "Россия", new DateTime(1984, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "trainer@trainer.ru", true, null, false, null, "Мурат", "TRAINER@TRAINER.RU", "TRAINER3", "AQAAAAIAAYagAAAAEGmk/dpGISWptCh8LHkT1U9pKqbFQAFbuDJ0+LwVYSoveB6F5mNXiSbpb97JX4CErw==", "Муратович", null, false, "trainer-5.jpg", "team-8.jpg", null, "Ростовская область", "", 0, 10, null, null, "Болотчиев", null, "trainer-1-4.jpg", null, false, "trainer3", null },
                    { "5", 0, null, null, null, "35e3790b-c31c-4f25-ab0a-5db1b09c9041", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user@user.ru", true, null, false, null, null, "USER@USER.RU", "USER", "AQAAAAIAAYagAAAAEFApXCvHATkQCxTPFmy/oDY0GtdvwooIHLLi2MK8TPfUcQgfD3hy5gpPFCqmW7b7sw==", null, null, false, null, null, null, null, "", 0, null, null, null, null, null, null, null, false, "user", null },
                    { "6", 0, null, null, "Краснодар", "b50c60c7-dd10-418d-8202-05a55067162c", "Россия", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "student@student.ru", true, null, false, null, "name", "STUDENT@STUDENT.RU", "STUDENT1", "AQAAAAIAAYagAAAAEHkgwYu9wPFNb0WNzIaFgaBMcl1SW58oJM/EDKndZ/gShcUmpKnHfNE6bQFOP7eyxw==", null, null, false, null, null, null, "Краснодарский край", "", 0, null, null, null, null, null, null, null, false, "student1", null },
                    { "7", 0, null, null, null, "2030d8f1-4c79-433d-bf1b-9ba4c19dc2e5", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "student@student.ru", true, null, false, null, null, "STUDENT@STUDENT.RU", "STUDENT2", "AQAAAAIAAYagAAAAEDrnzs6sdQWTzDFh5Qt3fL+B/XRpgWBN0PeC6iHzrHEKnFkLEILCrO8GNIk2J2Qw2g==", null, null, false, null, null, null, null, "", 0, null, null, null, null, null, null, null, false, "student2", null },
                    { "8", 0, null, null, null, "7620082c-edac-469f-a0f5-5bddf2fff69e", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "student@student.ru", true, null, false, null, null, "STUDENT@STUDENT.RU", "STUDENT3", "AQAAAAIAAYagAAAAEAUAF++xTRYUwxb54gj7HyRYBtPrjg/IUScYq3x5JuLBSm9ki/FkXiJgeBVJkluf7Q==", null, null, false, null, null, null, null, "", 0, null, null, null, null, null, null, null, false, "student3", null },
                    { "9", 0, null, null, null, "9c1fe686-8cac-4f06-825b-dd97aa2099a8", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "student@student.ru", true, null, false, null, null, "STUDENT@STUDENT.RU", "STUDENT4", "AQAAAAIAAYagAAAAEGnwmkSpqWVIVcX47mfa4BVpZxt56LWZm/MEGczFchn15y+Guv5lm264LDhVp+VTVw==", null, null, false, null, null, null, null, "", 0, null, null, null, null, null, null, null, false, "student4", null }
                });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterPreviewId", "ChapterVideoId", "CreatedDate", "Description", "Header", "Name", "NavigationTitle" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(713), "Прослушав курс вы поймете основные идеи данного гамбита, и историю возникновения. Узнаете кто из современников играет этот дебют.\r\n                                        Научитесь играть в комбинационные активные шахматы.", "", "Принятый северный гамбит", "Основная идея гамбита" },
                    { 2, null, null, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(738), "Обсуждается возможный план игры в миттельшпиле. Основные плюсы и минусы данного дебюта.", "Глубокий разбор основных линий в дебюте, последнии новинки.", "Основные варианты дебюта", "Основные варианты" },
                    { 3, null, null, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(754), "Расматривается основные возражения против северного гамбита. Способы уйти в удобные для черных линии.Обсуждается возможный план игры в миттельшпиле.", "", "Отказанный северный гамбит", "Как защищаться черным в северном гамбите" }
                });

            migrationBuilder.InsertData(
                table: "DirectoryCategory",
                columns: new[] { "Id", "Color", "CreatedDate", "Description", "Icon", "IsActive", "ListOrder", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "ffbb2c", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(5911), "", "book", true, 1, "Основы шахмат", "" },
                    { 2, "5578ff", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(5946), "", "door-open", true, 2, "Дебют", "" },
                    { 3, "e80368", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(5963), "", "medium", true, 3, "Миттельшпиль", "" },
                    { 4, "e361ff", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(5980), "", "door-closed", true, 4, "Эндшпиль", "" },
                    { 5, "47aeff", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(5996), "", "shuffle", true, 5, "Стратегия", "" },
                    { 6, "ffa76e", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6011), "", "star", true, 6, "Тактика", "" },
                    { 7, "11dbcf", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6027), "", "stop-circle-fill", true, 7, "Матовые конструкции", "" },
                    { 8, "4233ff", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6043), "", "stop-circle", true, 8, "Патовые конструкции", "" },
                    { 9, "b2904f", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6059), "", "textarea-t", true, 9, "Тактические приемы", "" },
                    { 10, "b20969", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6076), "", "people-fill", true, 10, "Чемпионы мира", "" },
                    { 11, "ff5828", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6092), "", "stack", true, 11, "Литература", "" },
                    { 12, "29cc61", new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6110), "", "list-task", true, 12, "Задачи", "" }
                });

            migrationBuilder.InsertData(
                table: "DirectoryStatusCourses",
                columns: new[] { "Id", "CreatedDate", "Description", "EngName", "ListOrder", "Name", "RusName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6139), "", null, 1, "Опубликован", null },
                    { 2, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(6159), "", null, 2, "В разработке", null },
                    { 3, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8621), "", null, 3, "На модерации", null },
                    { 4, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8647), "", null, 4, "Одобрен", null },
                    { 5, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8664), "", null, 5, "В продаже", null },
                    { 6, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8689), "", null, 6, "В архиве", null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "ListOrder", "Name", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(877), "Занимается онлайн года 4,5 точно. Тренеры Майя Порожняк и Мурат Болотчиев ❤️❤️❤️самые лучшие тренера! Активные, позитивные, интересные!", "testimonials-1.jpg", 1, "Виктория Нос", 5, "Мама ученика" },
                    { 2, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1025), "Сын занимается около полугода, очень доволен!\r\n                                    На урок всегда идет с удовольвствием. Тренеру Максиму Королёву - отдельная благодарность!", "testimonials-2.jpg", 2, "Иван Савелов", 5, "Отец ученика" },
                    { 3, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1042), "Занимается онлайн года 4,5 точно. Тренеры Майя Порожняк и Мурат Болотчиев ❤️❤️❤️самые лучшие тренера! Активные, позитивные, интересные!", "testimonials-3.jpg", 3, "Виктория Нос", 5, "Мама ученика" },
                    { 4, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1058), "Мой сын начал заниматься в шахматной школе почти год назад и мы просто в восторге от результатов! Каждое занятие не только увлекательно, но и полезно.", "testimonials-4.jpg", 4, "Yana", 4, "Мать ученика" },
                    { 5, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1074), "Рекомендую школу шахмат!\r\n                                    Там работают самые добрые , умные люди !", "testimonials-5.jpg", 5, "Светлана Лацерда", 5, "Ученица" },
                    { 6, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1095), "Это просто ужасно!Ужасный дебют, как можно такой дебют рекомендовать играть своим ученикам. ", "testimonials-5.jpg", 6, "Денис Медведев", 1, "Приобрел курс по дебюту Дамиано" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "TariffsId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8855), "Пробный урок", "Пробный урок", null },
                    { 2, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8873), "Доступ к открытым курсам", "Доступ к открытым курсам", null },
                    { 3, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8888), "Доступ к открытым вебинарам", "Доступ к открытым вебинарам", null },
                    { 4, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8903), null, "Доступ к закрытым курсам", null },
                    { 5, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8919), "Доступ к закрытым курсам", "Доступ к закрытым вебинарам", null },
                    { 6, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(9152), "Доступ к закрытым вебинарам, 10 вебинаров в месяц длительность 1 час 30 мин.", "Доступ к закрытым вебинарам, 10 вебинаров в месяц длительность 1 час 30 мин.", null },
                    { 7, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(9175), "Доступ к индивидуальным занятиям 10 занятий в месяц длительность 1 час 30 мин.", "Доступ к индивидуальным занятиям 10 занятий в месяц длительность 1 час 30 мин.", null }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreatedDate", "Description", "Key", "Name", "Section", "Value" },
                values: new object[] { 1, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(1118), "Заголовок на главной странице на первом баннере", "HeaderMain", "Главный заголовок", "Headers", "Шахматная школа" });

            migrationBuilder.InsertData(
                table: "Tariffs",
                columns: new[] { "Id", "CreatedDate", "Description", "IsAdvanced", "IsFeatured", "Name", "PriceMonth", "PriceYear", "ServicesIds" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(402), "Бесплатно", false, false, "Бесплатно", 0m, null, "1;2;3" },
                    { 2, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(646), "Самостоятельное обучение", false, true, "Самостоятельное обучение", 3000m, null, "1;2;3;4;5" },
                    { 3, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(671), "Групповые занятия", false, false, "Групповые занятия", 7000m, null, "1;2;3;4;5;6" },
                    { 4, new DateTime(2024, 11, 4, 8, 7, 23, 857, DateTimeKind.Utc).AddTicks(690), "Индивидуальные занятия", true, false, "Индивидуальные занятия", 12000m, null, "1;2;3;4;5;6;7" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "2", "3" },
                    { "2", "4" },
                    { "3", "5" },
                    { "4", "6" },
                    { "4", "7" },
                    { "4", "8" },
                    { "4", "9" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Currency", "Description", "Duration", "EndTimeCourse", "Likes", "Name", "Price", "Purchases", "StartTimeCourse", "StatusId", "TrainerId", "TypeCourse", "Views" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8731), 0, "Один из острейших дебютов в шахматах, так как там с первых же ходов жертвуются две пешки. В данном видео рассматриваются ловушки за белых и черных, \r\n                        которых так много в представленном дебютном варианте. Изучив их, вы сможете вылавливать тех соперников, которые слабо знакомы с тонкостями \r\n                        Северного гамбита. К тому же многие из этих ловушек очень красивы, поэтому даже если вы не собираетесь применять данный вариант на практике, то все \r\n                        равно получите незабываемое эстетическое удовольствие от просмотра этого ролика.", 120, new DateTime(2024, 8, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), 25, "Северный гамбит", 165m, 30, new DateTime(2024, 8, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, "3", 0, 50 },
                    { 2, 2, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8768), 0, "В курсе рассказывается как ставить ловушки в северном гамбите", 60, new DateTime(2024, 8, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), 25, "Ловушки в северном гамбите", 125m, 30, new DateTime(2024, 8, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, "3", 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "Webinars",
                columns: new[] { "Id", "AvailableSeats", "CategoryId", "CreatedDate", "Currency", "Description", "Duration", "EndTimeWebinar", "ImageWebinar", "Likes", "Name", "PreviewImageWebinar", "Price", "Purchases", "StartTimeWebinar", "StatusId", "TrainerId", "TypeWebinar", "Views" },
                values: new object[,]
                {
                    { 1, 30, 2, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8801), 0, "Майя Порожняк расскажет вам про один из самых романтических дебютов в Шахматной Истории, о северном гамбите, дебют, где белые жертвуют две пешки ради развития сверхмощной инициативы.", 120, new DateTime(2024, 8, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "events-item-3.jpg", 25, "Северный гамбит", "events-item-3.jpg", 165m, 30, new DateTime(2024, 8, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, "3", 0, 50 },
                    { 2, 30, 2, new DateTime(2024, 11, 4, 8, 7, 23, 856, DateTimeKind.Utc).AddTicks(8831), 0, "Роль шахмат в развитии интуиции и творческого мышления учащихся", 120, new DateTime(2024, 8, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "events-item-4.jpg", 25, "Шахматная интуиция", "events-item-4.jpg", 165m, 30, new DateTime(2024, 8, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, "3", 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "CourseDetails",
                columns: new[] { "Id", "ChapterId", "CourseId", "CreatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StudentId",
                table: "AspNetUsers",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TrainerId",
                table: "AspNetUsers",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_ChapterPreviewId",
                table: "Chapters",
                column: "ChapterPreviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_ChapterVideoId",
                table: "Chapters",
                column: "ChapterVideoId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetails_ChapterId",
                table: "CourseDetails",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetails_CourseId",
                table: "CourseDetails",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_CourseId",
                table: "CourseFiles",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StatusId",
                table: "Courses",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TrainerId",
                table: "Courses",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_TariffsId",
                table: "Services",
                column: "TariffsId");

            migrationBuilder.CreateIndex(
                name: "IX_Webinars_CategoryId",
                table: "Webinars",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Webinars_StatusId",
                table: "Webinars",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Webinars_TrainerId",
                table: "Webinars",
                column: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CourseDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Webinars");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Tariffs");

            migrationBuilder.DropTable(
                name: "CourseFiles");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DirectoryCategory");

            migrationBuilder.DropTable(
                name: "DirectoryStatusCourses");

            migrationBuilder.DropTable(
                name: "StudentsTrainers");
        }
    }
}
