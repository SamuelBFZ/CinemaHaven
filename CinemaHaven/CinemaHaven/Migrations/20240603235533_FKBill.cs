using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaHaven.Migrations
{
    public partial class FKBill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pays_Bills_BillId",
                table: "Pays");

            migrationBuilder.DropForeignKey(
                name: "FK_Pays_PaymentMethods_PaymentMethodId",
                table: "Pays");

            migrationBuilder.DropIndex(
                name: "IX_Pays_BillId",
                table: "Pays");

            migrationBuilder.DropColumn(
                name: "BillId",
                table: "Pays");

            migrationBuilder.AddColumn<Guid>(
                name: "PayId",
                table: "Bills",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PayId",
                table: "Bills",
                column: "PayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Pays_PayId",
                table: "Bills",
                column: "PayId",
                principalTable: "Pays",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pays_PaymentMethods_PaymentMethodId",
                table: "Pays",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Pays_PayId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Pays_PaymentMethods_PaymentMethodId",
                table: "Pays");

            migrationBuilder.DropIndex(
                name: "IX_Bills_PayId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "PayId",
                table: "Bills");

            migrationBuilder.AddColumn<Guid>(
                name: "BillId",
                table: "Pays",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pays_BillId",
                table: "Pays",
                column: "BillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pays_Bills_BillId",
                table: "Pays",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pays_PaymentMethods_PaymentMethodId",
                table: "Pays",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
