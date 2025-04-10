using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class Alter_Table_Users_Idx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Users",
                newName: "zipCode");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Users",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Users",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Users",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Long",
                table: "Users",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Lat",
                table: "Users",
                newName: "latitude");

            migrationBuilder.AddColumn<string>(
                name: "identity_id",
                table: "Users",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "ix_users_email",
                table: "Users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_users_identity_id",
                table: "Users",
                column: "identity_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_users_email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "ix_users_identity_id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "identity_id",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "zipCode",
                table: "Users",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Users",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "Users",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Users",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "Users",
                newName: "Long");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "Users",
                newName: "Lat");
        }
    }
}
