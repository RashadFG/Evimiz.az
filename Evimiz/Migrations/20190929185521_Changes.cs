using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Evimiz.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Metros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Newss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ViewCount = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 100, nullable: true),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    Info = table.Column<string>(nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    Author = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NumberKeyCodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Kcode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberKeyCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NumberKeyCodeSecondS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Kcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberKeyCodeSecondS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyRepairs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRepairs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Villages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regions_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstLastName = table.Column<string>(maxLength: 100, nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Info = table.Column<string>(maxLength: 200, nullable: false),
                    NumberKeyCodeId = table.Column<int>(nullable: false),
                    NumberKeyCodeSecondId = table.Column<int>(nullable: true),
                    FirstNumber = table.Column<string>(maxLength: 7, nullable: true),
                    LastNumber = table.Column<string>(maxLength: 7, nullable: true),
                    PropertyCategoryId = table.Column<int>(nullable: false),
                    RentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_NumberKeyCodes_NumberKeyCodeId",
                        column: x => x.NumberKeyCodeId,
                        principalTable: "NumberKeyCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_NumberKeyCodeSecondS_NumberKeyCodeSecondId",
                        column: x => x.NumberKeyCodeSecondId,
                        principalTable: "NumberKeyCodeSecondS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_PropertyCategorys_PropertyCategoryId",
                        column: x => x.PropertyCategoryId,
                        principalTable: "PropertyCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Rents_RentId",
                        column: x => x.RentId,
                        principalTable: "Rents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(maxLength: 100, nullable: true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    NumberKeyCodeId = table.Column<int>(nullable: false),
                    NumberKeyCodeSecondId = table.Column<int>(nullable: true),
                    SecondPhonenumber = table.Column<string>(maxLength: 7, nullable: true),
                    UserImageUrl = table.Column<string>(maxLength: 100, nullable: true),
                    Agencyabout = table.Column<string>(maxLength: 700, nullable: true),
                    İsAgent = table.Column<bool>(nullable: false),
                    İsUser = table.Column<bool>(nullable: false),
                    AgencyImageUrl = table.Column<string>(maxLength: 100, nullable: true),
                    RegionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_NumberKeyCodes_NumberKeyCodeId",
                        column: x => x.NumberKeyCodeId,
                        principalTable: "NumberKeyCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_NumberKeyCodeSecondS_NumberKeyCodeSecondId",
                        column: x => x.NumberKeyCodeSecondId,
                        principalTable: "NumberKeyCodeSecondS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    PropertyRepairId = table.Column<int>(nullable: false),
                    PropertyDocumentId = table.Column<int>(nullable: false),
                    NumberKeyCodeId = table.Column<int>(nullable: false),
                    PropertyCategoryId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    İstifadəçiId = table.Column<string>(nullable: true),
                    NumberKeyCodeSecondId = table.Column<int>(nullable: true),
                    RegionId = table.Column<int>(nullable: true),
                    MetroId = table.Column<int>(nullable: true),
                    VillageId = table.Column<int>(nullable: true),
                    RentId = table.Column<int>(nullable: true),
                    RoomId = table.Column<int>(nullable: true),
                    FloorId = table.Column<int>(nullable: true),
                    RankId = table.Column<int>(nullable: true),
                    IsVip = table.Column<bool>(nullable: false),
                    IsConfirmed = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsPremium = table.Column<bool>(nullable: false),
                    IsFavoruite = table.Column<bool>(nullable: false),
                    Area = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    About = table.Column<string>(maxLength: 1000, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    FirstPhoneNumber = table.Column<string>(maxLength: 7, nullable: true),
                    SecondPhoneNumber = table.Column<string>(maxLength: 7, nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisements_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Metros_MetroId",
                        column: x => x.MetroId,
                        principalTable: "Metros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_NumberKeyCodes_NumberKeyCodeId",
                        column: x => x.NumberKeyCodeId,
                        principalTable: "NumberKeyCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_NumberKeyCodeSecondS_NumberKeyCodeSecondId",
                        column: x => x.NumberKeyCodeSecondId,
                        principalTable: "NumberKeyCodeSecondS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_PropertyCategorys_PropertyCategoryId",
                        column: x => x.PropertyCategoryId,
                        principalTable: "PropertyCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_PropertyDocuments_PropertyDocumentId",
                        column: x => x.PropertyDocumentId,
                        principalTable: "PropertyDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_PropertyRepairs_PropertyRepairId",
                        column: x => x.PropertyRepairId,
                        principalTable: "PropertyRepairs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_Ranks_RankId",
                        column: x => x.RankId,
                        principalTable: "Ranks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Rents_RentId",
                        column: x => x.RentId,
                        principalTable: "Rents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Villages_VillageId",
                        column: x => x.VillageId,
                        principalTable: "Villages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_AspNetUsers_İstifadəçiId",
                        column: x => x.İstifadəçiId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    IsMainPhoto = table.Column<bool>(nullable: false),
                    AdvertisementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Yeni tikili" },
                    { 2, "Köhnə tikili" },
                    { 3, "Villa" },
                    { 4, "Həyət evi" },
                    { 5, "Bağ evi" },
                    { 6, "Ofis" },
                    { 7, "Qaraj" },
                    { 8, "Torpaq" },
                    { 9, "Obyekt" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 43, "Sabirabad" },
                    { 42, "Saatlı" },
                    { 41, "Oğuz" },
                    { 40, "Neftçala" },
                    { 39, "Masallı" },
                    { 33, "Quba" },
                    { 37, "Lerik" },
                    { 36, "Laçın" },
                    { 34, "Qubadlı" },
                    { 44, "Salyan" },
                    { 32, "Qobustan" },
                    { 38, "Lənkəran" },
                    { 45, "Samux" },
                    { 50, "Şəmkir" },
                    { 47, "Şabran" },
                    { 48, "Şamaxı" },
                    { 49, "Şəki" },
                    { 31, "Qəbələ" },
                    { 51, "Şuşa" },
                    { 52, "Tərtər" },
                    { 53, "Tovuz" },
                    { 54, "Ucar" },
                    { 55, "Yardımlı" },
                    { 56, "Yevlax" },
                    { 57, "Zaqatala" },
                    { 58, "Zəngilan" },
                    { 59, "Zərdab" },
                    { 46, "Siyəzən" },
                    { 30, "Qazax" },
                    { 35, "Qusar" },
                    { 28, "Kürdəmir" },
                    { 1, "Abşeron" },
                    { 2, "Ağcabədi" },
                    { 3, "Ağdam" },
                    { 4, "Ağdaş" },
                    { 5, "Ağstafa" },
                    { 29, "Qax" },
                    { 7, "Astara" },
                    { 8, "Balakən" },
                    { 9, "Beyləqan" },
                    { 10, "Bakı" },
                    { 11, "Bərdə" },
                    { 12, "Biləsuvar" },
                    { 13, "Cəbrayıl" },
                    { 14, "Cəlilabad" },
                    { 6, "Ağsu" },
                    { 16, "Gədəbəy" },
                    { 15, "Daşkəsən" },
                    { 27, "Kəlbəcər" },
                    { 26, "İsmayıllı" },
                    { 24, "Xocavənd" },
                    { 23, "Xocalı" },
                    { 25, "İmişli" },
                    { 21, "Xaçmaz" },
                    { 20, "Hacıqabul" },
                    { 19, "Göygöl" },
                    { 18, "Göyçay" },
                    { 17, "Goranboy" },
                    { 22, "Xızı" }
                });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "Count" },
                values: new object[,]
                {
                    { 23, 23 },
                    { 30, 30 },
                    { 24, 24 },
                    { 25, 25 },
                    { 26, 26 },
                    { 27, 27 },
                    { 28, 29 },
                    { 31, 31 },
                    { 38, 38 },
                    { 33, 33 },
                    { 34, 34 },
                    { 35, 35 },
                    { 36, 36 },
                    { 37, 37 },
                    { 39, 39 },
                    { 40, 40 },
                    { 22, 22 },
                    { 32, 32 },
                    { 21, 21 },
                    { 8, 8 },
                    { 19, 19 },
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 6, 6 },
                    { 7, 7 },
                    { 9, 9 },
                    { 10, 10 },
                    { 5, 5 },
                    { 12, 12 },
                    { 11, 11 },
                    { 18, 18 },
                    { 17, 17 },
                    { 16, 16 },
                    { 20, 20 },
                    { 14, 14 },
                    { 13, 13 },
                    { 15, 15 }
                });

            migrationBuilder.InsertData(
                table: "Metros",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 14, "Memar Əcəmi m." },
                    { 24, "Əhmədli m." },
                    { 22, "Ulduz m." },
                    { 21, "Sahil m." },
                    { 20, "Şah İsmayıl Xətai m." },
                    { 19, "Qara Qarayev m." },
                    { 18, "Nəsimi m." },
                    { 17, "Nəriman Nərimanov m." },
                    { 16, "Nizami m." },
                    { 15, "Neftçilər m." },
                    { 23, "Xalqlar Dostluğu m." },
                    { 13, "Koroğlu m." },
                    { 11, "İçəri Şəhər m." },
                    { 12, "İnşaatçılar m." },
                    { 1, "20 yanvar m." },
                    { 3, "Avtovağzal m." },
                    { 4, "Azadlıq prospekti m." },
                    { 5, "Bakmil m." },
                    { 2, "28 May m." },
                    { 7, "Dərnəgül m." },
                    { 8, "Elmlər Akademiyası m." },
                    { 9, "Gənclik m." },
                    { 10, "Həzi Aslanov m." },
                    { 6, "Cəfər Cabbarlı m." }
                });

            migrationBuilder.InsertData(
                table: "NumberKeyCodeSecondS",
                columns: new[] { "Id", "Kcode" },
                values: new object[,]
                {
                    { 2, "051" },
                    { 8, "012" },
                    { 7, "060" },
                    { 6, "040" },
                    { 5, "077" },
                    { 4, "070" },
                    { 3, "055" },
                    { 1, "050" }
                });

            migrationBuilder.InsertData(
                table: "NumberKeyCodes",
                columns: new[] { "Id", "Kcode" },
                values: new object[,]
                {
                    { 5, "077" },
                    { 7, "060" },
                    { 6, "040" },
                    { 4, "070" },
                    { 3, "055" },
                    { 2, "051" },
                    { 1, "050" },
                    { 8, "012" }
                });

            migrationBuilder.InsertData(
                table: "PropertyCategorys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Satılır" },
                    { 2, "Kirayə" }
                });

            migrationBuilder.InsertData(
                table: "PropertyDocuments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Kupça" },
                    { 7, "Digər sənəd" },
                    { 4, "Şəhadətnamə" },
                    { 5, "Bələdiyə sənədi" },
                    { 3, "Qeydiyyat vəsiqəsi" },
                    { 2, "Sərəncam" },
                    { 1, "Müqavilə" }
                });

            migrationBuilder.InsertData(
                table: "PropertyRepairs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Yaxşı təmirli" },
                    { 4, "Orta təmirli" },
                    { 6, "Əla təmirli" },
                    { 2, "Natamam təmirli" },
                    { 1, "Təmirsiz" },
                    { 3, "Zəif təmirli" }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Count" },
                values: new object[,]
                {
                    { 31, 31 },
                    { 23, 23 },
                    { 24, 24 },
                    { 25, 25 },
                    { 26, 26 },
                    { 27, 27 },
                    { 28, 29 },
                    { 30, 30 },
                    { 32, 32 },
                    { 36, 36 },
                    { 34, 34 },
                    { 35, 35 },
                    { 22, 22 },
                    { 37, 37 },
                    { 38, 38 },
                    { 39, 39 },
                    { 40, 40 },
                    { 33, 33 },
                    { 21, 21 },
                    { 18, 18 },
                    { 19, 19 },
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 20, 20 },
                    { 9, 9 },
                    { 8, 8 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 },
                    { 15, 15 },
                    { 16, 16 },
                    { 17, 17 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "Rents",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Aylıq" },
                    { 2, "Günluk" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Count" },
                values: new object[,]
                {
                    { 5, "5" },
                    { 6, "5+" },
                    { 4, "4" },
                    { 3, "3" },
                    { 2, "2" },
                    { 1, "1" }
                });

            migrationBuilder.InsertData(
                table: "Villages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 73, "Sahil" },
                    { 72, "Şağan" },
                    { 71, "Sabunçu" },
                    { 70, "Rəsulzadə" },
                    { 69, "Ramana" },
                    { 68, "Qobustan" },
                    { 67, "Qobu" },
                    { 66, "Qızıldaş" },
                    { 65, "Qaraçuxur" },
                    { 64, "Qara şəhər" },
                    { 63, "Qala" },
                    { 62, "Puta" },
                    { 61, "Pirşağı" },
                    { 60, "Perekeşkül" },
                    { 59, "Papanin" },
                    { 58, "NZS" },
                    { 57, "Nübar" },
                    { 56, "Novxanı" },
                    { 55, "Nasosnu" },
                    { 54, "Nardaran" },
                    { 53, "Mərdəkan" },
                    { 52, "Məhəmmədli" },
                    { 74, "Saray" },
                    { 98, "Ələt" },
                    { 76, "Şıxov" },
                    { 51, "Müşfiqabad" },
                    { 97, "Əhmədli" },
                    { 96, "Zirə" },
                    { 95, "Zığ" },
                    { 94, "Zağulba" },
                    { 93, "Zabrat 2" },
                    { 92, "Zabrat 1" },
                    { 91, "Y.Suraxanı" },
                    { 90, "Yeni Yasamal" },
                    { 89, "Y.Suraxanı" },
                    { 75, "Savalan" },
                    { 88, "Y.Ramana" },
                    { 86, "Xutor" },
                    { 85, "Xocəsən" },
                    { 84, "Xaşaxuna" },
                    { 83, "Ümid" },
                    { 82, "Türkan" },
                    { 81, "Səngəçal" },
                    { 80, "Şüvəlan" },
                    { 79, "Şuşa" },
                    { 78, "Sulutəpə" },
                    { 77, "Şubanı" },
                    { 87, "Y.Günəşli" },
                    { 50, "Montin" },
                    { 22, "Biləcəri" },
                    { 48, "Maştağa" },
                    { 21, "Bilgəh" },
                    { 20, "Bibiheybət" },
                    { 19, "Bayıl" },
                    { 18, "Balaxnı" },
                    { 17, "Bakixanov" },
                    { 16, "Bahar" },
                    { 15, "Badamdar" },
                    { 14, "Alatava 2" },
                    { 13, "Alatava 1" },
                    { 12, "Ağ şəhər" },
                    { 11, "9mkr" },
                    { 10, "8mkr" },
                    { 9, "7mkr" },
                    { 8, "6mkr" },
                    { 7, "5mkr" },
                    { 6, "4mkr" },
                    { 5, "3mkr" },
                    { 4, "28 May" },
                    { 3, "20-ci sahə" },
                    { 2, "2mkr" },
                    { 1, "1mkr" },
                    { 23, "Binə" },
                    { 49, "Mehdiabad" },
                    { 24, "Binəqədi" },
                    { 26, "Bülbülə" },
                    { 47, "Masazır" },
                    { 46, "Ləhic Bağları" },
                    { 45, "Lökbatan" },
                    { 44, "Kürdəxanı " },
                    { 43, "Köhnə Günəşli" },
                    { 42, "Kimya şəhərciyi" },
                    { 41, "Keşlə" },
                    { 40, "Həzi Aslanov merkez" },
                    { 39, "Hövsan" },
                    { 38, "Hökməli" },
                    { 37, "Güzdək" },
                    { 36, "Görədil" },
                    { 35, "Fatmayı" },
                    { 34, "Dədə Qorqud" },
                    { 33, "Dübəndi bağları" },
                    { 32, "Digah" },
                    { 31, "Corat" },
                    { 30, "Çiçək" },
                    { 29, "Ceyranbatan" },
                    { 28, "Çermet " },
                    { 27, "Buzovna" },
                    { 25, "Böyükşor" },
                    { 99, "Əmircan" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, 10, "Abşeron r." },
                    { 2, 10, "Binəqədi r." },
                    { 3, 10, "Nizami r." },
                    { 4, 10, "Nərimanov r." },
                    { 5, 10, "Nəsimi r." },
                    { 6, 10, "Pirallahı" },
                    { 7, 10, "Qaradağ r." },
                    { 8, 10, "Sabunçu r." },
                    { 9, 10, "Suraxanı r." },
                    { 10, 10, "Səbail r." },
                    { 11, 10, "Xətai r." },
                    { 12, 10, "Xəzər r." },
                    { 13, 10, "Yasamal r." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_CategoryId",
                table: "Advertisements",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_CityId",
                table: "Advertisements",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_FloorId",
                table: "Advertisements",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_MetroId",
                table: "Advertisements",
                column: "MetroId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_NumberKeyCodeId",
                table: "Advertisements",
                column: "NumberKeyCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_NumberKeyCodeSecondId",
                table: "Advertisements",
                column: "NumberKeyCodeSecondId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_PropertyCategoryId",
                table: "Advertisements",
                column: "PropertyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_PropertyDocumentId",
                table: "Advertisements",
                column: "PropertyDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_PropertyRepairId",
                table: "Advertisements",
                column: "PropertyRepairId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_RankId",
                table: "Advertisements",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_RegionId",
                table: "Advertisements",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_RentId",
                table: "Advertisements",
                column: "RentId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_RoomId",
                table: "Advertisements",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_VillageId",
                table: "Advertisements",
                column: "VillageId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_İstifadəçiId",
                table: "Advertisements",
                column: "İstifadəçiId");

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NumberKeyCodeId",
                table: "AspNetUsers",
                column: "NumberKeyCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NumberKeyCodeSecondId",
                table: "AspNetUsers",
                column: "NumberKeyCodeSecondId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RegionId",
                table: "AspNetUsers",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_AdvertisementId",
                table: "Images",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_NumberKeyCodeId",
                table: "Orders",
                column: "NumberKeyCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_NumberKeyCodeSecondId",
                table: "Orders",
                column: "NumberKeyCodeSecondId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PropertyCategoryId",
                table: "Orders",
                column: "PropertyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RentId",
                table: "Orders",
                column: "RentId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_CityId",
                table: "Regions",
                column: "CityId");
        }

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
                name: "Images");

            migrationBuilder.DropTable(
                name: "Newss");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "Metros");

            migrationBuilder.DropTable(
                name: "PropertyCategorys");

            migrationBuilder.DropTable(
                name: "PropertyDocuments");

            migrationBuilder.DropTable(
                name: "PropertyRepairs");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Villages");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "NumberKeyCodes");

            migrationBuilder.DropTable(
                name: "NumberKeyCodeSecondS");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
