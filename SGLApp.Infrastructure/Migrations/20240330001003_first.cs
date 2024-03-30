using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGLApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Firstmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditTransmissions",
                columns: table => new
                {
                    Auto_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentNumber = table.Column<int>(type: "int", nullable: true),
                    transaction_reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Vc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankBranch = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditTransmissions", x => x.Auto_Id);
                });

            migrationBuilder.CreateTable(
                name: "RealTimeTickets",
                columns: table => new
                {
                    RealTimeTicket_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POSID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrawNo = table.Column<int>(type: "int", nullable: true),
                    DrawDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TicketNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermBet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DirectNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectBet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FullTicket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IMEI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POSBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    POSDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EncryptedData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNetwork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesSynced = table.Column<int>(type: "int", nullable: true),
                    Canceled = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealTimeTickets", x => x.RealTimeTicket_Id);
                });

            migrationBuilder.CreateTable(
                name: "WinningTickets",
                columns: table => new
                {
                    WinningTicket_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sale = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Upload = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Agent_code = table.Column<int>(type: "int", nullable: false),
                    Terminal_Sale = table.Column<int>(type: "int", nullable: false),
                    Ticket_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payout = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ticket_Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ticket_Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinningTickets", x => x.WinningTicket_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditTransmissions");

            migrationBuilder.DropTable(
                name: "RealTimeTickets");

            migrationBuilder.DropTable(
                name: "WinningTickets");
        }
    }
}
