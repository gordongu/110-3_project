using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.IO;

namespace WanderList.Migrations
{
    public partial class InsertLocs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			FileInfo insertFile = new FileInfo(@"scripts\insert.sql");
			string insertScript = insertFile.OpenText().ReadToEnd();
			migrationBuilder.Sql(insertScript);
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
