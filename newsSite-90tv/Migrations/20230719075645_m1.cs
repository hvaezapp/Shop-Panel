using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShopPanel.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    RoleLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    BirthDayDate = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserImagePath = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    gender = table.Column<byte>(nullable: false),
                    isEnable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Appversion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    isEnable = table.Column<bool>(nullable: false),
                    link = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false),
                    versionCode = table.Column<int>(nullable: false),
                    versionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Appversion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Brand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    nameen = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    type = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Color",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    nameen = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Favorite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    appuser_id = table.Column<long>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    product_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Favorite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_filemanager",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    path = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_filemanager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Ostans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Ostans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Plan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    count = table.Column<byte>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    isEnable = table.Column<bool>(nullable: false),
                    nameen = table.Column<string>(nullable: true),
                    namefa = table.Column<string>(nullable: true),
                    offpercent = table.Column<int>(nullable: false),
                    plantype = table.Column<byte>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    type = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Plan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_PropertyPart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    key = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_PropertyPart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ReportReason",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ReportReason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Appsetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    about = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    ownername = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    shabacode = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false),
                    user_id = table.Column<string>(nullable: true),
                    wage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Appsetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Appsetting_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_UserApp",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User_id = table.Column<string>(nullable: true),
                    birthdate = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    firstName = table.Column<string>(nullable: true),
                    gender = table.Column<byte>(nullable: false),
                    image = table.Column<string>(nullable: true),
                    isEnable = table.Column<bool>(nullable: false),
                    lastName = table.Column<string>(nullable: true),
                    mobile = table.Column<string>(nullable: true),
                    mobileActiveCode = table.Column<string>(nullable: true),
                    mobileActiveStatus = table.Column<bool>(nullable: false),
                    nationalcode = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false),
                    token = table.Column<string>(nullable: true),
                    type = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_UserApp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_UserApp_AspNetUsers_User_id",
                        column: x => x.User_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Properties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    category_id = table.Column<int>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isEnable = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Properties_Tbl_Category_category_id",
                        column: x => x.category_id,
                        principalTable: "Tbl_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Size",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cat_id = table.Column<int>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isEnable = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Size", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Size_Tbl_Category_cat_id",
                        column: x => x.cat_id,
                        principalTable: "Tbl_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    ostan_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_City_Tbl_Ostans_ostan_id",
                        column: x => x.ostan_id,
                        principalTable: "Tbl_Ostans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Property",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cat_id = table.Column<int>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    part_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Property", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Property_Tbl_Category_cat_id",
                        column: x => x.cat_id,
                        principalTable: "Tbl_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Property_Tbl_PropertyPart_part_id",
                        column: x => x.part_id,
                        principalTable: "Tbl_PropertyPart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    appuser_id = table.Column<long>(nullable: false),
                    body = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Contact_Tbl_UserApp_appuser_id",
                        column: x => x.appuser_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Order",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    appuser_id = table.Column<long>(nullable: false),
                    codeorder = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    finishdateMiladi = table.Column<DateTime>(nullable: false),
                    finishdateShamsi = table.Column<string>(nullable: true),
                    isEnable = table.Column<bool>(nullable: false),
                    isfinish = table.Column<bool>(nullable: false),
                    postprice = table.Column<int>(nullable: false),
                    posttype = table.Column<byte>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    sumprice = table.Column<int>(nullable: false),
                    useradd_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Order_Tbl_UserApp_appuser_id",
                        column: x => x.appuser_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_payment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    amount = table.Column<long>(nullable: false),
                    appuser_id = table.Column<long>(nullable: false),
                    comment = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isSuccess = table.Column<bool>(nullable: false),
                    isenable = table.Column<bool>(nullable: false),
                    order_id = table.Column<long>(nullable: false),
                    refid = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_payment_Tbl_UserApp_appuser_id",
                        column: x => x.appuser_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Salsman",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    appuser_id = table.Column<long>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isEnable = table.Column<bool>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    user_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Salsman", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Salsman_Tbl_UserApp_appuser_id",
                        column: x => x.appuser_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Salsman_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_UserAlarm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    appuser_id = table.Column<long>(nullable: false),
                    body = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_UserAlarm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_UserAlarm_Tbl_UserApp_appuser_id",
                        column: x => x.appuser_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_PropertiesValue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isEnable = table.Column<bool>(nullable: false),
                    properties_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_PropertiesValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_PropertiesValue_Tbl_Properties_properties_id",
                        column: x => x.properties_id,
                        principalTable: "Tbl_Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_SizeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cat_id = table.Column<int>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    size_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_SizeCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_SizeCategory_Tbl_Category_cat_id",
                        column: x => x.cat_id,
                        principalTable: "Tbl_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_SizeCategory_Tbl_Size_size_id",
                        column: x => x.size_id,
                        principalTable: "Tbl_Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Banner",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    appuser_id = table.Column<long>(nullable: false),
                    category_id = table.Column<int>(nullable: false),
                    city_id = table.Column<int>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    ostan_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    todate = table.Column<DateTime>(nullable: false),
                    viewcount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Banner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Banner_Tbl_UserApp_appuser_id",
                        column: x => x.appuser_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Banner_Tbl_Category_category_id",
                        column: x => x.category_id,
                        principalTable: "Tbl_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Banner_Tbl_City_city_id",
                        column: x => x.city_id,
                        principalTable: "Tbl_City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Banner_Tbl_Ostans_ostan_id",
                        column: x => x.ostan_id,
                        principalTable: "Tbl_Ostans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Useraddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(nullable: true),
                    appuser_id = table.Column<long>(nullable: false),
                    city_id = table.Column<int>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    isenable = table.Column<bool>(nullable: false),
                    lat = table.Column<string>(nullable: true),
                    lot = table.Column<string>(nullable: true),
                    mobile = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    ostan_id = table.Column<int>(nullable: false),
                    phone = table.Column<string>(nullable: true),
                    postalcode = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Useraddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Useraddress_Tbl_UserApp_appuser_id",
                        column: x => x.appuser_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Useraddress_Tbl_City_city_id",
                        column: x => x.city_id,
                        principalTable: "Tbl_City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Useraddress_Tbl_Ostans_ostan_id",
                        column: x => x.ostan_id,
                        principalTable: "Tbl_Ostans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_sellerBank",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BankNom = table.Column<string>(nullable: true),
                    bankname = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    owner = table.Column<string>(nullable: true),
                    seller_id = table.Column<long>(nullable: false),
                    shabNom = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false),
                    user_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_sellerBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_sellerBank_Tbl_Salsman_seller_id",
                        column: x => x.seller_id,
                        principalTable: "Tbl_Salsman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_sellerBank_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Shop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(nullable: true),
                    cat_id = table.Column<int>(nullable: false),
                    city_id = table.Column<int>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    enable = table.Column<bool>(nullable: false),
                    image = table.Column<string>(nullable: true),
                    lat = table.Column<string>(nullable: true),
                    lot = table.Column<string>(nullable: true),
                    ostan_id = table.Column<int>(nullable: false),
                    seller_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    summary = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    user_id = table.Column<string>(nullable: true),
                    viewCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Shop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Shop_Tbl_Category_cat_id",
                        column: x => x.cat_id,
                        principalTable: "Tbl_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Shop_Tbl_City_city_id",
                        column: x => x.city_id,
                        principalTable: "Tbl_City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Shop_Tbl_Ostans_ostan_id",
                        column: x => x.ostan_id,
                        principalTable: "Tbl_Ostans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Shop_Tbl_Salsman_seller_id",
                        column: x => x.seller_id,
                        principalTable: "Tbl_Salsman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Shop_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_BannerImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    banner_id = table.Column<long>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_BannerImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_BannerImage_Tbl_Banner_banner_id",
                        column: x => x.banner_id,
                        principalTable: "Tbl_Banner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Checkout",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    bank_id = table.Column<long>(nullable: false),
                    checkoutprice = table.Column<int>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    seller_id = table.Column<long>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Checkout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Checkout_Tbl_sellerBank_bank_id",
                        column: x => x.bank_id,
                        principalTable: "Tbl_sellerBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Checkout_Tbl_Salsman_seller_id",
                        column: x => x.seller_id,
                        principalTable: "Tbl_Salsman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Checkout_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_CheckoutRequest",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    bank_id = table.Column<long>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    requestprice = table.Column<int>(nullable: false),
                    seller_id = table.Column<long>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_CheckoutRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_CheckoutRequest_Tbl_sellerBank_bank_id",
                        column: x => x.bank_id,
                        principalTable: "Tbl_sellerBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_CheckoutRequest_Tbl_Salsman_seller_id",
                        column: x => x.seller_id,
                        principalTable: "Tbl_Salsman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_CheckoutRequest_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_FollowShop",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    userapp_id = table.Column<long>(nullable: false),
                    usertoken = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_FollowShop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_FollowShop_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_FollowShop_Tbl_UserApp_userapp_id",
                        column: x => x.userapp_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Products",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User_id = table.Column<string>(nullable: true),
                    brand_id = table.Column<int>(nullable: false),
                    cat_id = table.Column<int>(nullable: false),
                    code = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    enable = table.Column<bool>(nullable: false),
                    garanty = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    isexist = table.Column<bool>(nullable: false),
                    ispublish = table.Column<bool>(nullable: false),
                    keyword = table.Column<string>(nullable: true),
                    likeCount = table.Column<int>(nullable: false),
                    offpercent = table.Column<int>(nullable: false),
                    price = table.Column<long>(nullable: false),
                    qty = table.Column<int>(nullable: false),
                    seller_id = table.Column<long>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    summary = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    viewCount = table.Column<int>(nullable: false),
                    weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_AspNetUsers_User_id",
                        column: x => x.User_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_Brand_brand_id",
                        column: x => x.brand_id,
                        principalTable: "Tbl_Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_Category_cat_id",
                        column: x => x.cat_id,
                        principalTable: "Tbl_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_Salsman_seller_id",
                        column: x => x.seller_id,
                        principalTable: "Tbl_Salsman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ShopAdvertise",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    appuser_id = table.Column<long>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    fromdateMiladi = table.Column<DateTime>(nullable: false),
                    fromdateShamsi = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    todateMiladi = table.Column<DateTime>(nullable: false),
                    todateShamsi = table.Column<string>(nullable: true),
                    users_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ShopAdvertise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ShopAdvertise_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ShopAdvertise_AspNetUsers_users_id",
                        column: x => x.users_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ShopComment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsEnable = table.Column<bool>(nullable: false),
                    appuser_id = table.Column<long>(nullable: false),
                    body = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    replyto = table.Column<int>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ShopComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ShopComment_Tbl_UserApp_appuser_id",
                        column: x => x.appuser_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ShopComment_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ShopPlanState",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    expiredateml = table.Column<DateTime>(nullable: false),
                    expiredatesh = table.Column<string>(nullable: true),
                    plan_id = table.Column<int>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    startdateml = table.Column<DateTime>(nullable: false),
                    startdatesh = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ShopPlanState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ShopPlanState_Tbl_Plan_plan_id",
                        column: x => x.plan_id,
                        principalTable: "Tbl_Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ShopPlanState_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Buy",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    buyer_id = table.Column<long>(nullable: false),
                    buyeradd_id = table.Column<int>(nullable: false),
                    buystatus = table.Column<byte>(nullable: false),
                    color_id = table.Column<int>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    posttype = table.Column<byte>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    product_id = table.Column<long>(nullable: false),
                    qty = table.Column<int>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    size_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    totalprice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Buy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Buy_Tbl_UserApp_buyer_id",
                        column: x => x.buyer_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Buy_Tbl_Useraddress_buyeradd_id",
                        column: x => x.buyeradd_id,
                        principalTable: "Tbl_Useraddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Buy_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Buy_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    appuser_id = table.Column<long>(nullable: false),
                    body = table.Column<string>(nullable: true),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isEnable = table.Column<bool>(nullable: false),
                    product_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_comment_Tbl_UserApp_appuser_id",
                        column: x => x.appuser_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_comment_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_orderdetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    color_id = table.Column<int>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    order_id = table.Column<long>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    product_id = table.Column<long>(nullable: false),
                    qty = table.Column<int>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    size_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    totalprice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_orderdetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_orderdetail_Tbl_Order_order_id",
                        column: x => x.order_id,
                        principalTable: "Tbl_Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_orderdetail_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_orderdetail_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProductColor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    color_id = table.Column<int>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    product_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductColor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductColor_Tbl_Color_color_id",
                        column: x => x.color_id,
                        principalTable: "Tbl_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductColor_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProductGallary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    imagepath = table.Column<string>(nullable: true),
                    product_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductGallary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductGallary_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProductProperties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    product_id = table.Column<long>(nullable: false),
                    properties_id = table.Column<int>(nullable: false),
                    propertiesvalue_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductProperties_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductProperties_Tbl_Properties_properties_id",
                        column: x => x.properties_id,
                        principalTable: "Tbl_Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductProperties_Tbl_PropertiesValue_propertiesvalue_id",
                        column: x => x.propertiesvalue_id,
                        principalTable: "Tbl_PropertiesValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProductProperty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    product_id = table.Column<long>(nullable: false),
                    property_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductProperty_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductProperty_Tbl_Property_property_id",
                        column: x => x.property_id,
                        principalTable: "Tbl_Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProductSeller",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isEnable = table.Column<bool>(nullable: false),
                    isExist = table.Column<bool>(nullable: false),
                    ismainseller = table.Column<bool>(nullable: false),
                    offpercent = table.Column<byte>(nullable: false),
                    price = table.Column<long>(nullable: false),
                    productType = table.Column<byte>(nullable: false),
                    product_id = table.Column<long>(nullable: false),
                    qty = table.Column<byte>(nullable: false),
                    seller_id = table.Column<long>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductSeller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductSeller_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductSeller_Tbl_Salsman_seller_id",
                        column: x => x.seller_id,
                        principalTable: "Tbl_Salsman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductSeller_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    product_id = table.Column<long>(nullable: false),
                    size_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductSize_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductSize_Tbl_Size_size_id",
                        column: x => x.size_id,
                        principalTable: "Tbl_Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ReportProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    appuser_id = table.Column<long>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    message = table.Column<string>(nullable: true),
                    product_id = table.Column<long>(nullable: false),
                    reason_id = table.Column<int>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ReportProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ReportProduct_Tbl_UserApp_appuser_id",
                        column: x => x.appuser_id,
                        principalTable: "Tbl_UserApp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ReportProduct_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_ReportProduct_Tbl_ReportReason_reason_id",
                        column: x => x.reason_id,
                        principalTable: "Tbl_ReportReason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_AdvertisePlanState",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    adv_id = table.Column<long>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    expiredateml = table.Column<DateTime>(nullable: false),
                    expiredatesh = table.Column<string>(nullable: true),
                    plan_id = table.Column<int>(nullable: false),
                    startdateml = table.Column<DateTime>(nullable: false),
                    startdatesh = table.Column<string>(nullable: true),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_AdvertisePlanState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_AdvertisePlanState_Tbl_ShopAdvertise_adv_id",
                        column: x => x.adv_id,
                        principalTable: "Tbl_ShopAdvertise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_AdvertisePlanState_Tbl_Plan_plan_id",
                        column: x => x.plan_id,
                        principalTable: "Tbl_Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_BuyCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    buy_id = table.Column<long>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_BuyCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_BuyCheck_Tbl_Buy_buy_id",
                        column: x => x.buy_id,
                        principalTable: "Tbl_Buy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Sell",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    buy_id = table.Column<long>(nullable: false),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    product_id = table.Column<long>(nullable: false),
                    qty = table.Column<int>(nullable: false),
                    removableprice = table.Column<long>(nullable: false),
                    seller_id = table.Column<long>(nullable: false),
                    sellstatus = table.Column<byte>(nullable: false),
                    shop_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false),
                    totalprice = table.Column<long>(nullable: false),
                    totalsellprice = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Sell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Sell_Tbl_Buy_buy_id",
                        column: x => x.buy_id,
                        principalTable: "Tbl_Buy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Sell_Tbl_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Sell_Tbl_Salsman_seller_id",
                        column: x => x.seller_id,
                        principalTable: "Tbl_Salsman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Sell_Tbl_Shop_shop_id",
                        column: x => x.shop_id,
                        principalTable: "Tbl_Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_SellCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateMiladi = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    isenable = table.Column<bool>(nullable: false),
                    sell_id = table.Column<long>(nullable: false),
                    status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_SellCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_SellCheck_Tbl_Sell_sell_id",
                        column: x => x.sell_id,
                        principalTable: "Tbl_Sell",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_AdvertisePlanState_adv_id",
                table: "Tbl_AdvertisePlanState",
                column: "adv_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_AdvertisePlanState_plan_id",
                table: "Tbl_AdvertisePlanState",
                column: "plan_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Appsetting_user_id",
                table: "Tbl_Appsetting",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Banner_appuser_id",
                table: "Tbl_Banner",
                column: "appuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Banner_category_id",
                table: "Tbl_Banner",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Banner_city_id",
                table: "Tbl_Banner",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Banner_ostan_id",
                table: "Tbl_Banner",
                column: "ostan_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_BannerImage_banner_id",
                table: "Tbl_BannerImage",
                column: "banner_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Buy_buyer_id",
                table: "Tbl_Buy",
                column: "buyer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Buy_buyeradd_id",
                table: "Tbl_Buy",
                column: "buyeradd_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Buy_product_id",
                table: "Tbl_Buy",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Buy_shop_id",
                table: "Tbl_Buy",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_BuyCheck_buy_id",
                table: "Tbl_BuyCheck",
                column: "buy_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Checkout_bank_id",
                table: "Tbl_Checkout",
                column: "bank_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Checkout_seller_id",
                table: "Tbl_Checkout",
                column: "seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Checkout_shop_id",
                table: "Tbl_Checkout",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CheckoutRequest_bank_id",
                table: "Tbl_CheckoutRequest",
                column: "bank_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CheckoutRequest_seller_id",
                table: "Tbl_CheckoutRequest",
                column: "seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CheckoutRequest_shop_id",
                table: "Tbl_CheckoutRequest",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_City_ostan_id",
                table: "Tbl_City",
                column: "ostan_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_comment_appuser_id",
                table: "Tbl_comment",
                column: "appuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_comment_product_id",
                table: "Tbl_comment",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Contact_appuser_id",
                table: "Tbl_Contact",
                column: "appuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_FollowShop_shop_id",
                table: "Tbl_FollowShop",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_FollowShop_userapp_id",
                table: "Tbl_FollowShop",
                column: "userapp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Order_appuser_id",
                table: "Tbl_Order",
                column: "appuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_orderdetail_order_id",
                table: "Tbl_orderdetail",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_orderdetail_product_id",
                table: "Tbl_orderdetail",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_orderdetail_shop_id",
                table: "Tbl_orderdetail",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_payment_appuser_id",
                table: "Tbl_payment",
                column: "appuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductColor_color_id",
                table: "Tbl_ProductColor",
                column: "color_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductColor_product_id",
                table: "Tbl_ProductColor",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductGallary_product_id",
                table: "Tbl_ProductGallary",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductProperties_product_id",
                table: "Tbl_ProductProperties",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductProperties_properties_id",
                table: "Tbl_ProductProperties",
                column: "properties_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductProperties_propertiesvalue_id",
                table: "Tbl_ProductProperties",
                column: "propertiesvalue_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductProperty_product_id",
                table: "Tbl_ProductProperty",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductProperty_property_id",
                table: "Tbl_ProductProperty",
                column: "property_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_User_id",
                table: "Tbl_Products",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_brand_id",
                table: "Tbl_Products",
                column: "brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_cat_id",
                table: "Tbl_Products",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_seller_id",
                table: "Tbl_Products",
                column: "seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_shop_id",
                table: "Tbl_Products",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductSeller_product_id",
                table: "Tbl_ProductSeller",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductSeller_seller_id",
                table: "Tbl_ProductSeller",
                column: "seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductSeller_shop_id",
                table: "Tbl_ProductSeller",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductSize_product_id",
                table: "Tbl_ProductSize",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductSize_size_id",
                table: "Tbl_ProductSize",
                column: "size_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Properties_category_id",
                table: "Tbl_Properties",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_PropertiesValue_properties_id",
                table: "Tbl_PropertiesValue",
                column: "properties_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Property_cat_id",
                table: "Tbl_Property",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Property_part_id",
                table: "Tbl_Property",
                column: "part_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ReportProduct_appuser_id",
                table: "Tbl_ReportProduct",
                column: "appuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ReportProduct_product_id",
                table: "Tbl_ReportProduct",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ReportProduct_reason_id",
                table: "Tbl_ReportProduct",
                column: "reason_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Salsman_appuser_id",
                table: "Tbl_Salsman",
                column: "appuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Salsman_user_id",
                table: "Tbl_Salsman",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Sell_buy_id",
                table: "Tbl_Sell",
                column: "buy_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Sell_product_id",
                table: "Tbl_Sell",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Sell_seller_id",
                table: "Tbl_Sell",
                column: "seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Sell_shop_id",
                table: "Tbl_Sell",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SellCheck_sell_id",
                table: "Tbl_SellCheck",
                column: "sell_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_sellerBank_seller_id",
                table: "Tbl_sellerBank",
                column: "seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_sellerBank_user_id",
                table: "Tbl_sellerBank",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Shop_cat_id",
                table: "Tbl_Shop",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Shop_city_id",
                table: "Tbl_Shop",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Shop_ostan_id",
                table: "Tbl_Shop",
                column: "ostan_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Shop_seller_id",
                table: "Tbl_Shop",
                column: "seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Shop_user_id",
                table: "Tbl_Shop",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ShopAdvertise_shop_id",
                table: "Tbl_ShopAdvertise",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ShopAdvertise_users_id",
                table: "Tbl_ShopAdvertise",
                column: "users_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ShopComment_appuser_id",
                table: "Tbl_ShopComment",
                column: "appuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ShopComment_shop_id",
                table: "Tbl_ShopComment",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ShopPlanState_plan_id",
                table: "Tbl_ShopPlanState",
                column: "plan_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ShopPlanState_shop_id",
                table: "Tbl_ShopPlanState",
                column: "shop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Size_cat_id",
                table: "Tbl_Size",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SizeCategory_cat_id",
                table: "Tbl_SizeCategory",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SizeCategory_size_id",
                table: "Tbl_SizeCategory",
                column: "size_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Useraddress_appuser_id",
                table: "Tbl_Useraddress",
                column: "appuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Useraddress_city_id",
                table: "Tbl_Useraddress",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Useraddress_ostan_id",
                table: "Tbl_Useraddress",
                column: "ostan_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UserAlarm_appuser_id",
                table: "Tbl_UserAlarm",
                column: "appuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UserApp_User_id",
                table: "Tbl_UserApp",
                column: "User_id");
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
                name: "Tbl_AdvertisePlanState");

            migrationBuilder.DropTable(
                name: "Tbl_Appsetting");

            migrationBuilder.DropTable(
                name: "Tbl_Appversion");

            migrationBuilder.DropTable(
                name: "Tbl_BannerImage");

            migrationBuilder.DropTable(
                name: "Tbl_BuyCheck");

            migrationBuilder.DropTable(
                name: "Tbl_Checkout");

            migrationBuilder.DropTable(
                name: "Tbl_CheckoutRequest");

            migrationBuilder.DropTable(
                name: "Tbl_comment");

            migrationBuilder.DropTable(
                name: "Tbl_Contact");

            migrationBuilder.DropTable(
                name: "Tbl_Favorite");

            migrationBuilder.DropTable(
                name: "Tbl_filemanager");

            migrationBuilder.DropTable(
                name: "Tbl_FollowShop");

            migrationBuilder.DropTable(
                name: "Tbl_orderdetail");

            migrationBuilder.DropTable(
                name: "Tbl_payment");

            migrationBuilder.DropTable(
                name: "Tbl_ProductColor");

            migrationBuilder.DropTable(
                name: "Tbl_ProductGallary");

            migrationBuilder.DropTable(
                name: "Tbl_ProductProperties");

            migrationBuilder.DropTable(
                name: "Tbl_ProductProperty");

            migrationBuilder.DropTable(
                name: "Tbl_ProductSeller");

            migrationBuilder.DropTable(
                name: "Tbl_ProductSize");

            migrationBuilder.DropTable(
                name: "Tbl_ReportProduct");

            migrationBuilder.DropTable(
                name: "Tbl_SellCheck");

            migrationBuilder.DropTable(
                name: "Tbl_ShopComment");

            migrationBuilder.DropTable(
                name: "Tbl_ShopPlanState");

            migrationBuilder.DropTable(
                name: "Tbl_SizeCategory");

            migrationBuilder.DropTable(
                name: "Tbl_UserAlarm");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Tbl_ShopAdvertise");

            migrationBuilder.DropTable(
                name: "Tbl_Banner");

            migrationBuilder.DropTable(
                name: "Tbl_sellerBank");

            migrationBuilder.DropTable(
                name: "Tbl_Order");

            migrationBuilder.DropTable(
                name: "Tbl_Color");

            migrationBuilder.DropTable(
                name: "Tbl_PropertiesValue");

            migrationBuilder.DropTable(
                name: "Tbl_Property");

            migrationBuilder.DropTable(
                name: "Tbl_ReportReason");

            migrationBuilder.DropTable(
                name: "Tbl_Sell");

            migrationBuilder.DropTable(
                name: "Tbl_Plan");

            migrationBuilder.DropTable(
                name: "Tbl_Size");

            migrationBuilder.DropTable(
                name: "Tbl_Properties");

            migrationBuilder.DropTable(
                name: "Tbl_PropertyPart");

            migrationBuilder.DropTable(
                name: "Tbl_Buy");

            migrationBuilder.DropTable(
                name: "Tbl_Useraddress");

            migrationBuilder.DropTable(
                name: "Tbl_Products");

            migrationBuilder.DropTable(
                name: "Tbl_Brand");

            migrationBuilder.DropTable(
                name: "Tbl_Shop");

            migrationBuilder.DropTable(
                name: "Tbl_Category");

            migrationBuilder.DropTable(
                name: "Tbl_City");

            migrationBuilder.DropTable(
                name: "Tbl_Salsman");

            migrationBuilder.DropTable(
                name: "Tbl_Ostans");

            migrationBuilder.DropTable(
                name: "Tbl_UserApp");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
