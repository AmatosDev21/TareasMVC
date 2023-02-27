using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(Select Id from AspNetRoles 
                                 where Id = '252c458f-b10a-4728-840f-77051811d4c4')
                                 BEGIN
	                             INSERT AspNetRoles (Id, [Name], [NormalizedName])
	                             VALUES ('252c458f-b10a-4728-840f-77051811d4c4', 'admin', 'ADMIN')
                                 END");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles Where Id = '252c458f-b10a-4728-840f-77051811d4c4'");
        }
    }
}
