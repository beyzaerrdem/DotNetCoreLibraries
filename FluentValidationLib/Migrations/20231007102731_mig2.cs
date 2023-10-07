using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentValidationLib.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthdayTime",
                table: "Customers",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthdayTime",
                table: "Customers");
        }
    }
}
