using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLeasing.Web.Migrations
{
    public partial class UpdateDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_propertyTypes_PropertyTypeId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_propertyImages_Properties_PropertyId",
                table: "propertyImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_propertyTypes",
                table: "propertyTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_propertyImages",
                table: "propertyImages");

            migrationBuilder.RenameTable(
                name: "propertyTypes",
                newName: "PropertyTypes");

            migrationBuilder.RenameTable(
                name: "propertyImages",
                newName: "PropertyImages");

            migrationBuilder.RenameIndex(
                name: "IX_propertyImages_PropertyId",
                table: "PropertyImages",
                newName: "IX_PropertyImages_PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyTypes",
                table: "PropertyTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyImages",
                table: "PropertyImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PropertyTypes_PropertyTypeId",
                table: "Properties",
                column: "PropertyTypeId",
                principalTable: "PropertyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyImages_Properties_PropertyId",
                table: "PropertyImages",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertyTypes_PropertyTypeId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyImages_Properties_PropertyId",
                table: "PropertyImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyTypes",
                table: "PropertyTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyImages",
                table: "PropertyImages");

            migrationBuilder.RenameTable(
                name: "PropertyTypes",
                newName: "propertyTypes");

            migrationBuilder.RenameTable(
                name: "PropertyImages",
                newName: "propertyImages");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyImages_PropertyId",
                table: "propertyImages",
                newName: "IX_propertyImages_PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_propertyTypes",
                table: "propertyTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_propertyImages",
                table: "propertyImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_propertyTypes_PropertyTypeId",
                table: "Properties",
                column: "PropertyTypeId",
                principalTable: "propertyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_propertyImages_Properties_PropertyId",
                table: "propertyImages",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
