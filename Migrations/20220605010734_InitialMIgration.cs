using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Control_Finance_WebAPI.Migrations
{
    public partial class InitialMIgration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.EnsureSchema(
            //    name: "devgeniusadm");

            //migrationBuilder.CreateTable(
            //    name: "__MigrationHistory",
            //    columns: table => new
            //    {
            //        MigrationId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
            //        ContextKey = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
            //        Model = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
            //        ProductVersion = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_dbo.__MigrationHistory", x => new { x.MigrationId, x.ContextKey });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ExpenseCategory",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DtCreated = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ExpenseCategory", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "User",
            //    schema: "devgeniusadm",
            //    columns: table => new
            //    {
            //        CPF = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PassWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DtCreated = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_User", x => x.CPF);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "webpages_Membership",
            //    columns: table => new
            //    {
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ConfirmationToken = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //        IsConfirmed = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
            //        LastPasswordFailureDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PasswordFailuresSinceLastSuccess = table.Column<int>(type: "int", nullable: false),
            //        Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        PasswordChangedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PasswordSalt = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        PasswordVerificationToken = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //        PasswordVerificationTokenExpirationDate = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__webpages__1788CC4C1E4F1542", x => x.UserId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "webpages_OAuthMembership",
            //    columns: table => new
            //    {
            //        Provider = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        ProviderUserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__webpages__F53FC0ED813EC02C", x => new { x.Provider, x.ProviderUserId });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "webpages_Roles",
            //    columns: table => new
            //    {
            //        RoleId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__webpages__8AFACE1AA0256449", x => x.RoleId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Account",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserCPF = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
            //        Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Account", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Account_devgeniusadm.User_UserCPF",
            //            column: x => x.UserCPF,
            //            principalSchema: "devgeniusadm",
            //            principalTable: "User",
            //            principalColumn: "CPF");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Balance",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Value = table.Column<double>(type: "float", nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        User_CPF = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Balance", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Balance_User_User_CPF",
            //            column: x => x.User_CPF,
            //            principalSchema: "devgeniusadm",
            //            principalTable: "User",
            //            principalColumn: "CPF");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "webpages_UsersInRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        RoleId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__webpages__AF2760AD1B8EF48F", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "fk_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "webpages_Roles",
            //            principalColumn: "RoleId");
            //        table.ForeignKey(
            //            name: "fk_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Account",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FormOfPayment",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Balance_Id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FormOfPayment", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_FormOfPayment_Balance_Balance_Id",
            //            column: x => x.Balance_Id,
            //            principalTable: "Balance",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MonthlyExpense",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        QtdPlots = table.Column<int>(type: "int", nullable: false),
            //        CurrentPlot = table.Column<int>(type: "int", nullable: false),
            //        DueDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ExpenseCategory_Id = table.Column<int>(type: "int", nullable: true),
            //        FormOfPayment_Id = table.Column<int>(type: "int", nullable: true),
            //        User_CPF = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MonthlyExpense", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_MonthlyExpense_ExpenseCategory_ExpenseCategory_Id",
            //            column: x => x.ExpenseCategory_Id,
            //            principalTable: "ExpenseCategory",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_MonthlyExpense_FormOfPayment_FormOfPayment_Id",
            //            column: x => x.FormOfPayment_Id,
            //            principalTable: "FormOfPayment",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_MonthlyExpense_User_User_CPF",
            //            column: x => x.User_CPF,
            //            principalSchema: "devgeniusadm",
            //            principalTable: "User",
            //            principalColumn: "CPF");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VariableExpense",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
            //        UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true),
            //        FormOfPayment_Id = table.Column<int>(type: "int", nullable: true),
            //        User_CPF = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
            //        Place = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "('')")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VariableExpense", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_VariableExpense_FormOfPayment_FormOfPayment_Id",
            //            column: x => x.FormOfPayment_Id,
            //            principalTable: "FormOfPayment",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_VariableExpense_User_User_CPF",
            //            column: x => x.User_CPF,
            //            principalSchema: "devgeniusadm",
            //            principalTable: "User",
            //            principalColumn: "CPF");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Account_UserCPF",
            //    table: "Account",
            //    column: "UserCPF");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Balance_User_CPF",
            //    table: "Balance",
            //    column: "User_CPF");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FormOfPayment_Balance_Id",
            //    table: "FormOfPayment",
            //    column: "Balance_Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MonthlyExpense_ExpenseCategory_Id",
            //    table: "MonthlyExpense",
            //    column: "ExpenseCategory_Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MonthlyExpense_FormOfPayment_Id",
            //    table: "MonthlyExpense",
            //    column: "FormOfPayment_Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MonthlyExpense_User_CPF",
            //    table: "MonthlyExpense",
            //    column: "User_CPF");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VariableExpense_FormOfPayment_Id",
            //    table: "VariableExpense",
            //    column: "FormOfPayment_Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VariableExpense_User_CPF",
            //    table: "VariableExpense",
            //    column: "User_CPF");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__webpages__8A2B6160A6ABCDC5",
            //    table: "webpages_Roles",
            //    column: "RoleName",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_webpages_UsersInRoles_RoleId",
            //    table: "webpages_UsersInRoles",
            //    column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "MonthlyExpense");

            migrationBuilder.DropTable(
                name: "VariableExpense");

            migrationBuilder.DropTable(
                name: "webpages_Membership");

            migrationBuilder.DropTable(
                name: "webpages_OAuthMembership");

            migrationBuilder.DropTable(
                name: "webpages_UsersInRoles");

            migrationBuilder.DropTable(
                name: "ExpenseCategory");

            migrationBuilder.DropTable(
                name: "FormOfPayment");

            migrationBuilder.DropTable(
                name: "webpages_Roles");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Balance");

            migrationBuilder.DropTable(
                name: "User",
                schema: "devgeniusadm");
        }
    }
}
