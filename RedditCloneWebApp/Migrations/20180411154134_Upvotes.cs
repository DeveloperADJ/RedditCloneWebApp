using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RedditCloneWebApp.Migrations
{
    public partial class Upvotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Votes",
                table: "Posts",
                newName: "Upvotes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Upvotes",
                table: "Posts",
                newName: "Votes");
        }
    }
}
