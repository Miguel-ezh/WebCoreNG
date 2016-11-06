using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCoreNG.Migrations
{
    public partial class schemav2 : Migration
    {
        /// <summary>
        /// SQLite dont support drop columns
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "EmailSend",
            //    table: "Submissions");

            //migrationBuilder.DropColumn(
            //    name: "RequestDate",
            //    table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "SentEmail",
                table: "Submissions",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Accounts",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "SentEmail",
            //    table: "Submissions");

            //migrationBuilder.DropColumn(
            //    name: "Country",
            //    table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "EmailSend",
                table: "Submissions",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestDate",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
