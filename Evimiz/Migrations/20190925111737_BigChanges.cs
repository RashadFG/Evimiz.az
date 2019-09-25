using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Evimiz.Migrations
{
    public partial class BigChanges : Migration
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
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomCount = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
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
                name: "NewPlaceS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomCount = table.Column<int>(nullable: false),
                    FloorCount = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewPlaceS", x => x.Id);
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
                name: "OfficeS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomCount = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false),
                    FloorCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OldPlaceS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomCount = table.Column<int>(nullable: false),
                    FloorCount = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OldPlaceS", x => x.Id);
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
                name: "PropertyObject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomCount = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyObject", x => x.Id);
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
                name: "VillaS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomCount = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YardHouseS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomCount = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YardHouseS", x => x.Id);
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
                    NumberKeyCodeId = table.Column<int>(nullable: true),
                    NumberKeyCodeSecondId = table.Column<int>(nullable: true),
                    FirstNumber = table.Column<string>(maxLength: 7, nullable: true),
                    LastNumber = table.Column<string>(maxLength: 7, nullable: true),
                    PropertyCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_NumberKeyCodes_NumberKeyCodeId",
                        column: x => x.NumberKeyCodeId,
                        principalTable: "NumberKeyCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    PropertyCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rents_PropertyCategorys_PropertyCategoryId",
                        column: x => x.PropertyCategoryId,
                        principalTable: "PropertyCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NewPlaceId = table.Column<int>(nullable: true),
                    OldPlaceId = table.Column<int>(nullable: true),
                    HouseId = table.Column<int>(nullable: true),
                    VillaId = table.Column<int>(nullable: true),
                    YardHouseId = table.Column<int>(nullable: true),
                    OfficeId = table.Column<int>(nullable: true),
                    PropertyObjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Homes_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Homes_NewPlaceS_NewPlaceId",
                        column: x => x.NewPlaceId,
                        principalTable: "NewPlaceS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Homes_OfficeS_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "OfficeS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Homes_OldPlaceS_OldPlaceId",
                        column: x => x.OldPlaceId,
                        principalTable: "OldPlaceS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Homes_PropertyObject_PropertyObjectId",
                        column: x => x.PropertyObjectId,
                        principalTable: "PropertyObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Homes_VillaS_VillaId",
                        column: x => x.VillaId,
                        principalTable: "VillaS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Homes_YardHouseS_YardHouseId",
                        column: x => x.YardHouseId,
                        principalTable: "YardHouseS",
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
                    NumberKeyCodeId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
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
                    PropertyCategoryId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    About = table.Column<string>(maxLength: 200, nullable: false),
                    PropertyRepairId = table.Column<int>(nullable: false),
                    PropertyDocumentId = table.Column<int>(nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    NumberKeyCodeId = table.Column<int>(nullable: true),
                    NumberKeyCodeSecondId = table.Column<int>(nullable: true),
                    FirstPhoneNumber = table.Column<string>(maxLength: 7, nullable: true),
                    SecondPhoneNumber = table.Column<string>(maxLength: 7, nullable: true),
                    İstifadəçiId = table.Column<string>(nullable: true),
                    IsVip = table.Column<bool>(nullable: false),
                    IsConfirmed = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsPremium = table.Column<bool>(nullable: false),
                    IsFavoruite = table.Column<bool>(nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    MetronId = table.Column<int>(nullable: true),
                    MetroId = table.Column<int>(nullable: true),
                    VillageId = table.Column<int>(nullable: true),
                    HomeId = table.Column<int>(nullable: false),
                    RentId = table.Column<int>(nullable: true)
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
                        name: "FK_Advertisements_Homes_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Homes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_Advertisements_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_Rents_RentId",
                        column: x => x.RentId,
                        principalTable: "Rents",
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
                    { 42, "Saatlı" },
                    { 41, "Oğuz" },
                    { 40, "Neftçala" },
                    { 39, "Masallı" },
                    { 38, "Lənkəran" },
                    { 33, "Quba" },
                    { 36, "Laçın" },
                    { 35, "Qusar" },
                    { 34, "Qubadlı" },
                    { 43, "Sabirabad" },
                    { 32, "Qobustan" },
                    { 37, "Lerik" },
                    { 44, "Salyan" },
                    { 50, "Şəmkir" },
                    { 46, "Siyəzən" },
                    { 47, "Şabran" },
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
                    { 45, "Samux" },
                    { 30, "Qazax" },
                    { 48, "Şamaxı" },
                    { 28, "Kürdəmir" },
                    { 29, "Qax" },
                    { 1, "Abşeron" },
                    { 2, "Ağcabədi" },
                    { 3, "Ağdam" },
                    { 4, "Ağdaş" },
                    { 5, "Ağstafa" },
                    { 6, "Ağsu" },
                    { 7, "Astara" },
                    { 8, "Balakən" },
                    { 10, "Bakı" },
                    { 11, "Bərdə" },
                    { 12, "Biləsuvar" },
                    { 13, "Cəbrayıl" },
                    { 9, "Beyləqan" },
                    { 15, "Daşkəsən" },
                    { 27, "Kəlbəcər" },
                    { 26, "İsmayıllı" },
                    { 14, "Cəlilabad" },
                    { 24, "Xocavənd" },
                    { 23, "Xocalı" },
                    { 22, "Xızı" },
                    { 21, "Xaçmaz" },
                    { 25, "İmişli" },
                    { 19, "Göygöl" },
                    { 18, "Göyçay" },
                    { 17, "Goranboy" },
                    { 16, "Gədəbəy" },
                    { 20, "Hacıqabul" }
                });

            migrationBuilder.InsertData(
                table: "Metros",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 15, "Neftçilər m." },
                    { 16, "Nizami m." },
                    { 17, "Nəriman Nərimanov m." },
                    { 18, "Nəsimi m." },
                    { 20, "Şah İsmayıl Xətai m." },
                    { 21, "Sahil m." },
                    { 22, "Ulduz m." },
                    { 23, "Xalqlar Dostluğu m." },
                    { 24, "Əhmədli m." },
                    { 14, "Memar Əcəmi m." },
                    { 19, "Qara Qarayev m." },
                    { 13, "Koroğlu m." },
                    { 8, "Elmlər Akademiyası m." },
                    { 11, "İçəri Şəhər m." },
                    { 12, "İnşaatçılar m." },
                    { 2, "28 May m." },
                    { 3, "Avtovağzal m." },
                    { 4, "Azadlıq prospekti m." },
                    { 1, "20 yanvar m." },
                    { 6, "Cəfər Cabbarlı m." },
                    { 7, "Dərnəgül m." },
                    { 9, "Gənclik m." },
                    { 10, "Həzi Aslanov m." },
                    { 5, "Bakmil m." }
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
                    { 5, "Bələdiyə sənədi" },
                    { 1, "Müqavilə" },
                    { 3, "Qeydiyyat vəsiqəsi" },
                    { 4, "Şəhadətnamə" },
                    { 2, "Sərəncam" }
                });

            migrationBuilder.InsertData(
                table: "PropertyRepairs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Təmirsiz" },
                    { 2, "Natamam təmirli" },
                    { 3, "Zəif təmirli" },
                    { 4, "Orta təmirli" },
                    { 5, "Yaxşı təmirli" },
                    { 6, "Əla təmirli" }
                });

            migrationBuilder.InsertData(
                table: "Villages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 71, "Sabunçu" },
                    { 64, "Qara şəhər" },
                    { 65, "Qaraçuxur" },
                    { 66, "Qızıldaş" },
                    { 70, "Rəsulzadə" },
                    { 68, "Qobustan" },
                    { 69, "Ramana" },
                    { 63, "Qala" },
                    { 67, "Qobu" },
                    { 62, "Puta" },
                    { 58, "NZS" },
                    { 60, "Perekeşkül" },
                    { 59, "Papanin" },
                    { 72, "Şağan" },
                    { 57, "Nübar" },
                    { 56, "Novxanı" },
                    { 55, "Nasosnu" },
                    { 54, "Nardaran" },
                    { 53, "Mərdəkan" },
                    { 52, "Məhəmmədli" },
                    { 61, "Pirşağı" },
                    { 73, "Sahil" },
                    { 77, "Şubanı" },
                    { 75, "Savalan" },
                    { 97, "Əhmədli" },
                    { 96, "Zirə" },
                    { 95, "Zığ" },
                    { 94, "Zağulba" },
                    { 93, "Zabrat 2" },
                    { 92, "Zabrat 1" },
                    { 91, "Y.Suraxanı" },
                    { 90, "Yeni Yasamal" },
                    { 89, "Y.Suraxanı" },
                    { 88, "Y.Ramana" },
                    { 74, "Saray" },
                    { 87, "Y.Günəşli" },
                    { 85, "Xocəsən" },
                    { 84, "Xaşaxuna" },
                    { 83, "Ümid" },
                    { 82, "Türkan" },
                    { 81, "Səngəçal" },
                    { 80, "Şüvəlan" },
                    { 79, "Şuşa" },
                    { 78, "Sulutəpə" },
                    { 51, "Müşfiqabad" },
                    { 76, "Şıxov" },
                    { 86, "Xutor" },
                    { 50, "Montin" },
                    { 45, "Lökbatan" },
                    { 48, "Maştağa" },
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
                    { 98, "Ələt" },
                    { 21, "Bilgəh" },
                    { 22, "Biləcəri" },
                    { 23, "Binə" },
                    { 24, "Binəqədi" },
                    { 47, "Masazır" },
                    { 46, "Ləhic Bağları" },
                    { 44, "Kürdəxanı " },
                    { 43, "Köhnə Günəşli" },
                    { 42, "Kimya şəhərciyi" },
                    { 41, "Keşlə" },
                    { 40, "Həzi Aslanov merkez" },
                    { 39, "Hövsan" },
                    { 38, "Hökməli" },
                    { 37, "Güzdək" },
                    { 49, "Mehdiabad" },
                    { 36, "Görədil" },
                    { 34, "Dədə Qorqud" },
                    { 33, "Dübəndi bağları" },
                    { 32, "Digah" },
                    { 31, "Corat" },
                    { 30, "Çiçək" },
                    { 29, "Ceyranbatan" },
                    { 28, "Çermet " },
                    { 27, "Buzovna" },
                    { 26, "Bülbülə" },
                    { 25, "Böyükşor" },
                    { 35, "Fatmayı" },
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

            migrationBuilder.InsertData(
                table: "Rents",
                columns: new[] { "Id", "Name", "PropertyCategoryId" },
                values: new object[,]
                {
                    { 1, "Aylıq", 2 },
                    { 2, "Günluk", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_CategoryId",
                table: "Advertisements",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_HomeId",
                table: "Advertisements",
                column: "HomeId");

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
                name: "IX_Advertisements_RegionId",
                table: "Advertisements",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_RentId",
                table: "Advertisements",
                column: "RentId");

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
                name: "IX_Homes_HouseId",
                table: "Homes",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Homes_NewPlaceId",
                table: "Homes",
                column: "NewPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Homes_OfficeId",
                table: "Homes",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Homes_OldPlaceId",
                table: "Homes",
                column: "OldPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Homes_PropertyObjectId",
                table: "Homes",
                column: "PropertyObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Homes_VillaId",
                table: "Homes",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_Homes_YardHouseId",
                table: "Homes",
                column: "YardHouseId");

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
                name: "IX_Regions_CityId",
                table: "Regions",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_PropertyCategoryId",
                table: "Rents",
                column: "PropertyCategoryId");
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
                name: "Homes");

            migrationBuilder.DropTable(
                name: "Metros");

            migrationBuilder.DropTable(
                name: "PropertyDocuments");

            migrationBuilder.DropTable(
                name: "PropertyRepairs");

            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "Villages");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "NewPlaceS");

            migrationBuilder.DropTable(
                name: "OfficeS");

            migrationBuilder.DropTable(
                name: "OldPlaceS");

            migrationBuilder.DropTable(
                name: "PropertyObject");

            migrationBuilder.DropTable(
                name: "VillaS");

            migrationBuilder.DropTable(
                name: "YardHouseS");

            migrationBuilder.DropTable(
                name: "PropertyCategorys");

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
