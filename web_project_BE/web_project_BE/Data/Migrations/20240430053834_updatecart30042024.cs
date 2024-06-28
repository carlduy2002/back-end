﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webprojectBE.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatecart30042024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "isChecked",
                table: "Cart_Details",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isChecked",
                table: "Cart_Details");
        }
    }
}
