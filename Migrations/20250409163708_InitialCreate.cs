using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experiments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<int>(type: "integer", nullable: false),
                    NumberExperimentTest = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Sender = table.Column<string>(type: "text", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    Receiver = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MentalModelNavigationConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SearchBarTop = table.Column<bool>(type: "boolean", nullable: false),
                    SearchBarBottom = table.Column<bool>(type: "boolean", nullable: false),
                    NavBarTop = table.Column<bool>(type: "boolean", nullable: false),
                    NavBarBottom = table.Column<bool>(type: "boolean", nullable: false),
                    Filter = table.Column<bool>(type: "boolean", nullable: false),
                    AutoCompleteBottom = table.Column<bool>(type: "boolean", nullable: false),
                    AutoCompleteTop = table.Column<bool>(type: "boolean", nullable: false),
                    ShoppingCartTopLeft = table.Column<bool>(type: "boolean", nullable: false),
                    ShoppingCartTopRight = table.Column<bool>(type: "boolean", nullable: false),
                    ShoppingCartBottomRight = table.Column<bool>(type: "boolean", nullable: false),
                    ShoppingCartBottomLeft = table.Column<bool>(type: "boolean", nullable: false),
                    MegaDropDown = table.Column<bool>(type: "boolean", nullable: false),
                    SideMenuLeft = table.Column<bool>(type: "boolean", nullable: false),
                    SideMenuRight = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Breadcrumbs = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ExperimentTestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentalModelNavigationConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NavigationSelections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SideNavigationSearchBarTop = table.Column<bool>(type: "boolean", nullable: false),
                    SideNavigationSearchbarBottom = table.Column<bool>(type: "boolean", nullable: false),
                    HorizontalNavigation = table.Column<bool>(type: "boolean", nullable: false),
                    SideNavigationUserInformationTop = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    MegaDropDown = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavigationSelections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ParentTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTypes_ProductTypes_ParentTypeId",
                        column: x => x.ParentTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Prename = table.Column<string>(type: "text", nullable: false),
                    Group = table.Column<string>(type: "text", nullable: false),
                    CurrentExperimentPosition = table.Column<int>(type: "integer", nullable: false),
                    StartedUserExperienceAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    FinishedUserExperienceAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExperimentTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<int>(type: "integer", nullable: false),
                    EstimatedExecutionTime = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DetailDescription = table.Column<string>(type: "text", nullable: false),
                    HeadDetailDescription = table.Column<string>(type: "text", nullable: false),
                    GoalInstruction = table.Column<string>(type: "text", nullable: false),
                    ExperimentId = table.Column<int>(type: "integer", nullable: false),
                    Configuration = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperimentTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperimentTests_Experiments_ExperimentId",
                        column: x => x.ExperimentId,
                        principalTable: "Experiments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Trademark = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeletedMails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Sender = table.Column<string>(type: "text", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    Receiver = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<string>(type: "text", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletedMails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeletedMails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBehaviours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClickedOnHelp = table.Column<bool>(type: "boolean", nullable: true),
                    NumberClickedOnHelp = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClickedOnSettings = table.Column<bool>(type: "boolean", nullable: true),
                    NumberClickedOnSettings = table.Column<int>(type: "integer", nullable: true),
                    TimeReadingWelcomeModal = table.Column<int>(type: "integer", nullable: true),
                    ClickedOnHint = table.Column<bool>(type: "boolean", nullable: true),
                    NumberClickedOnHint = table.Column<int>(type: "integer", nullable: true),
                    WelcomeModalTipIndex = table.Column<int>(type: "integer", nullable: true),
                    LastUpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBehaviours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBehaviours_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ProgressiveVisualizationExperiment = table.Column<bool>(type: "boolean", nullable: false),
                    ProgressiveVisualizationExperimentTest = table.Column<bool>(type: "boolean", nullable: false),
                    AutoStartNextExperiment = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSettings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperimentFeedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Consistency = table.Column<int>(type: "integer", nullable: false),
                    CognitiveStress = table.Column<int>(type: "integer", nullable: false),
                    Learnability = table.Column<int>(type: "integer", nullable: false),
                    MentalModel = table.Column<int>(type: "integer", nullable: false),
                    Understandable = table.Column<int>(type: "integer", nullable: false),
                    ExperimentTestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperimentFeedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperimentFeedbacks_ExperimentTests_ExperimentTestId",
                        column: x => x.ExperimentTestId,
                        principalTable: "ExperimentTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperimentFeedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperimentTestExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestId = table.Column<int>(type: "integer", nullable: false),
                    FinishedExecutionAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    StartedExecutionAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ExecutionTime = table.Column<double>(type: "double precision", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    TimeReadingDescription = table.Column<int>(type: "integer", nullable: false),
                    OpenedDescAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperimentTestExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperimentTestExecutions_ExperimentTests_ExperimentTestId",
                        column: x => x.ExperimentTestId,
                        principalTable: "ExperimentTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperimentTestExecutions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeyPads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyPadType = table.Column<string>(type: "text", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: false),
                    Width = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    ConnectionType = table.Column<string>(type: "text", nullable: false),
                    TouchType = table.Column<string>(type: "text", nullable: false),
                    EnergyType = table.Column<string>(type: "text", nullable: false),
                    KeyPadLayout = table.Column<string>(type: "text", nullable: false),
                    SignalTransmission = table.Column<string>(type: "text", nullable: false),
                    BatteryTime = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyPads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyPads_ProductTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeyPads_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mixers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Volume = table.Column<int>(type: "integer", nullable: false),
                    Function = table.Column<string>(type: "text", nullable: false),
                    Lenght = table.Column<string>(type: "text", nullable: false),
                    Colr = table.Column<string>(type: "text", nullable: false),
                    Power = table.Column<int>(type: "integer", nullable: false),
                    Material = table.Column<string>(type: "text", nullable: false),
                    OriginCountry = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mixers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mixers_ProductTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mixers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notebooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Arbeitsspeicher = table.Column<int>(type: "integer", nullable: false),
                    Festplatte = table.Column<int>(type: "integer", nullable: false),
                    Os = table.Column<string>(type: "text", nullable: false),
                    KeyPadFormat = table.Column<string>(type: "text", nullable: false),
                    ProcessorType = table.Column<string>(type: "text", nullable: false),
                    NumberProcessorCores = table.Column<int>(type: "integer", nullable: false),
                    GraphicCardModel = table.Column<string>(type: "text", nullable: false),
                    NumberPerformanceCors = table.Column<int>(type: "integer", nullable: false),
                    MaxBatteryTime = table.Column<int>(type: "integer", nullable: false),
                    NumberUsbAdapters = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notebooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notebooks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalComputers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ram = table.Column<int>(type: "integer", nullable: false),
                    StorageCapacity = table.Column<int>(type: "integer", nullable: false),
                    Os = table.Column<string>(type: "text", nullable: false),
                    KeyPadFormat = table.Column<string>(type: "text", nullable: false),
                    ProcessorType = table.Column<string>(type: "text", nullable: false),
                    NumberProcessorCores = table.Column<int>(type: "integer", nullable: false),
                    GraphicCardModel = table.Column<string>(type: "text", nullable: false),
                    NumberPerformanceCors = table.Column<int>(type: "integer", nullable: false),
                    ClockFrequency = table.Column<float>(type: "real", nullable: false),
                    NumberUsbAdapters = table.Column<int>(type: "integer", nullable: false),
                    Cache = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ProductCategory = table.Column<string>(type: "text", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalComputers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalComputers_ProductTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalComputers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ProductPropertyId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_ProductProperties_ProductPropertyId",
                        column: x => x.ProductPropertyId,
                        principalTable: "ProductProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperimentSelectionTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Time = table.Column<int>(type: "integer", nullable: false),
                    ExperimentId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    SettingId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperimentSelectionTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperimentSelectionTimes_Experiments_ExperimentId",
                        column: x => x.ExperimentId,
                        principalTable: "Experiments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperimentSelectionTimes_UserSettings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "UserSettings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExperimentSelectionTimes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserNavigationTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    FromExperimentId = table.Column<int>(type: "integer", nullable: true),
                    ToExperimentId = table.Column<int>(type: "integer", nullable: false),
                    FinishedNavigation = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    StartedNavigation = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UserSettingId = table.Column<int>(type: "integer", nullable: true),
                    NumberClicks = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNavigationTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNavigationTimes_ExperimentTests_FromExperimentId",
                        column: x => x.FromExperimentId,
                        principalTable: "ExperimentTests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserNavigationTimes_ExperimentTests_ToExperimentId",
                        column: x => x.ToExperimentId,
                        principalTable: "ExperimentTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNavigationTimes_UserSettings_UserSettingId",
                        column: x => x.UserSettingId,
                        principalTable: "UserSettings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserNavigationTimes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ErrorCorrectionExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    FailedClicks = table.Column<int>(type: "integer", nullable: false),
                    ExecutionTime = table.Column<double>(type: "double precision", nullable: true),
                    NumberClicks = table.Column<int>(type: "integer", nullable: true),
                    FirstClick = table.Column<string>(type: "text", nullable: false),
                    TimeToClickOnUndo = table.Column<int>(type: "integer", nullable: true),
                    ClickedOnUndo = table.Column<bool>(type: "boolean", nullable: false),
                    TaskSuccess = table.Column<bool>(type: "boolean", nullable: false),
                    ClickedOnDeletedItems = table.Column<bool>(type: "boolean", nullable: false),
                    UndoSnackBarPosition = table.Column<string>(type: "text", nullable: false),
                    CorrectInput = table.Column<bool>(type: "boolean", nullable: false),
                    TimeToClickOnDeletedItems = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorCorrectionExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ErrorCorrectionExperimentExecutions_ExperimentTestExecution~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FittsLawExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    ClickReactionTimes = table.Column<string>(type: "text", nullable: false),
                    NumberFailedClicks = table.Column<int>(type: "integer", nullable: false),
                    ExecutionTime = table.Column<int>(type: "integer", nullable: false),
                    Tasks = table.Column<string>(type: "text", nullable: false),
                    TaskSuccess = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FittsLawExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FittsLawExperimentExecutions_ExperimentTestExecutions_Exper~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormAndFeedbackExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    NumberClicks = table.Column<int>(type: "integer", nullable: false),
                    ExecutionTime = table.Column<int>(type: "integer", nullable: false),
                    NumberFormValidations = table.Column<int>(type: "integer", nullable: false),
                    NumberErrors = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormAndFeedbackExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormAndFeedbackExperimentExecutions_ExperimentTestExecution~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HicksLawExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    CategoryLinkClickDates = table.Column<string>(type: "text", nullable: true),
                    FailedClicks = table.Column<int>(type: "integer", nullable: false),
                    ExecutionTime = table.Column<double>(type: "double precision", nullable: true),
                    NumberClicks = table.Column<int>(type: "integer", nullable: true),
                    NumberUsedSearchBar = table.Column<int>(type: "integer", nullable: true),
                    ProductLimit = table.Column<int>(type: "integer", nullable: false),
                    CategoryLimit = table.Column<int>(type: "integer", nullable: false),
                    TimeToClickFirstCategoryLink = table.Column<int>(type: "integer", nullable: false),
                    ClickedOnFilters = table.Column<bool>(type: "boolean", nullable: false),
                    FirstChoiceAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    SecondChoiceAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ThirdChoiceAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    FirstClick = table.Column<string>(type: "text", nullable: false),
                    UsedFilters = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HicksLawExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HicksLawExperimentExecutions_ExperimentTestExecutions_Exper~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MentalModelExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    ClickedRoutes = table.Column<string>(type: "text", nullable: true),
                    FailedClicks = table.Column<int>(type: "integer", nullable: false),
                    ClickedOnSearchBar = table.Column<bool>(type: "boolean", nullable: false),
                    UsedFilters = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    FirstClick = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    UsedFilter = table.Column<bool>(type: "boolean", nullable: false),
                    UsedBreadcrumbs = table.Column<bool>(type: "boolean", nullable: false),
                    ExecutionTime = table.Column<double>(type: "double precision", nullable: true),
                    NumberClicks = table.Column<int>(type: "integer", nullable: true),
                    NumberUsedSearchBar = table.Column<int>(type: "integer", nullable: true),
                    TimeToClickFirstCategory = table.Column<int>(type: "integer", nullable: true),
                    TimeToClickSearchBar = table.Column<int>(type: "integer", nullable: true),
                    TimeToClickShoppingCart = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentalModelExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MentalModelExperimentExecutions_ExperimentTestExecutions_Ex~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecallRecognitionExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    CategoryLinkClickDates = table.Column<string>(type: "text", nullable: true),
                    FailedClicks = table.Column<int>(type: "integer", nullable: false),
                    ClickedOnSearchBar = table.Column<bool>(type: "boolean", nullable: false),
                    ExecutionTime = table.Column<double>(type: "double precision", nullable: true),
                    NumberClicks = table.Column<int>(type: "integer", nullable: true),
                    NumberUsedSearchBar = table.Column<int>(type: "integer", nullable: true),
                    TimeToClickSearchBar = table.Column<int>(type: "integer", nullable: true),
                    UsedBreadcrumbs = table.Column<bool>(type: "boolean", nullable: false),
                    TimeToClickFirstCategoryLink = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecallRecognitionExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecallRecognitionExperimentExecutions_ExperimentTestExecuti~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestorffExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    ReactionTimes = table.Column<string>(type: "text", nullable: false),
                    NumberFailedClicks = table.Column<int>(type: "integer", nullable: false),
                    NumberClicks = table.Column<int>(type: "integer", nullable: false),
                    ExecutionTime = table.Column<int>(type: "integer", nullable: false),
                    Tasks = table.Column<string>(type: "text", nullable: false),
                    NumberDeletedMails = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestorffExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestorffExperimentExecutions_ExperimentTestExecutions_Exper~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeletedMails_UserId",
                table: "DeletedMails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ErrorCorrectionExperimentExecutions_ExperimentTestExecution~",
                table: "ErrorCorrectionExperimentExecutions",
                column: "ExperimentTestExecutionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentFeedbacks_ExperimentTestId",
                table: "ExperimentFeedbacks",
                column: "ExperimentTestId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentFeedbacks_UserId",
                table: "ExperimentFeedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentSelectionTimes_ExperimentId",
                table: "ExperimentSelectionTimes",
                column: "ExperimentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentSelectionTimes_SettingId",
                table: "ExperimentSelectionTimes",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentSelectionTimes_UserId",
                table: "ExperimentSelectionTimes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTestExecutions_ExperimentTestId",
                table: "ExperimentTestExecutions",
                column: "ExperimentTestId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTestExecutions_UserId",
                table: "ExperimentTestExecutions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTests_ExperimentId",
                table: "ExperimentTests",
                column: "ExperimentId");

            migrationBuilder.CreateIndex(
                name: "IX_FittsLawExperimentExecutions_ExperimentTestExecutionId",
                table: "FittsLawExperimentExecutions",
                column: "ExperimentTestExecutionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormAndFeedbackExperimentExecutions_ExperimentTestExecution~",
                table: "FormAndFeedbackExperimentExecutions",
                column: "ExperimentTestExecutionId");

            migrationBuilder.CreateIndex(
                name: "IX_HicksLawExperimentExecutions_ExperimentTestExecutionId",
                table: "HicksLawExperimentExecutions",
                column: "ExperimentTestExecutionId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPads_ProductId",
                table: "KeyPads",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPads_TypeId",
                table: "KeyPads",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MentalModelExperimentExecutions_ExperimentTestExecutionId",
                table: "MentalModelExperimentExecutions",
                column: "ExperimentTestExecutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mixers_ProductId",
                table: "Mixers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Mixers_TypeId",
                table: "Mixers",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notebooks_ProductId",
                table: "Notebooks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalComputers_ProductId",
                table: "PersonalComputers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalComputers_TypeId",
                table: "PersonalComputers",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeId",
                table: "Products",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_ProductId",
                table: "ProductSpecifications",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_ProductPropertyId",
                table: "ProductSpecifications",
                column: "ProductPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ParentTypeId",
                table: "ProductTypes",
                column: "ParentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecallRecognitionExperimentExecutions_ExperimentTestExecuti~",
                table: "RecallRecognitionExperimentExecutions",
                column: "ExperimentTestExecutionId");

            migrationBuilder.CreateIndex(
                name: "IX_RestorffExperimentExecutions_ExperimentTestExecutionId",
                table: "RestorffExperimentExecutions",
                column: "ExperimentTestExecutionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBehaviours_UserId",
                table: "UserBehaviours",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNavigationTimes_FromExperimentId",
                table: "UserNavigationTimes",
                column: "FromExperimentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNavigationTimes_ToExperimentId",
                table: "UserNavigationTimes",
                column: "ToExperimentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNavigationTimes_UserId",
                table: "UserNavigationTimes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNavigationTimes_UserSettingId",
                table: "UserNavigationTimes",
                column: "UserSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSettings_UserId",
                table: "UserSettings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeletedMails");

            migrationBuilder.DropTable(
                name: "ErrorCorrectionExperimentExecutions");

            migrationBuilder.DropTable(
                name: "ExperimentFeedbacks");

            migrationBuilder.DropTable(
                name: "ExperimentSelectionTimes");

            migrationBuilder.DropTable(
                name: "FittsLawExperimentExecutions");

            migrationBuilder.DropTable(
                name: "FormAndFeedbackExperimentExecutions");

            migrationBuilder.DropTable(
                name: "HicksLawExperimentExecutions");

            migrationBuilder.DropTable(
                name: "KeyPads");

            migrationBuilder.DropTable(
                name: "Mails");

            migrationBuilder.DropTable(
                name: "MentalModelExperimentExecutions");

            migrationBuilder.DropTable(
                name: "MentalModelNavigationConfigs");

            migrationBuilder.DropTable(
                name: "Mixers");

            migrationBuilder.DropTable(
                name: "NavigationSelections");

            migrationBuilder.DropTable(
                name: "Notebooks");

            migrationBuilder.DropTable(
                name: "PersonalComputers");

            migrationBuilder.DropTable(
                name: "ProductSpecifications");

            migrationBuilder.DropTable(
                name: "RecallRecognitionExperimentExecutions");

            migrationBuilder.DropTable(
                name: "RestorffExperimentExecutions");

            migrationBuilder.DropTable(
                name: "UserBehaviours");

            migrationBuilder.DropTable(
                name: "UserNavigationTimes");

            migrationBuilder.DropTable(
                name: "ProductProperties");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ExperimentTestExecutions");

            migrationBuilder.DropTable(
                name: "UserSettings");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "ExperimentTests");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Experiments");
        }
    }
}
