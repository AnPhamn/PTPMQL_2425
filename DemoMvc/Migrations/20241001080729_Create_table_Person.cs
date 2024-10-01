using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DEMOMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HovaTen",
                table: "Person",
                newName: "hoVaten");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Person",
                newName: "queQuan");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    CCCDID = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<string>(type: "TEXT", nullable: true),
                    Sex = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.CCCDID);
                    table.ForeignKey(
                        name: "FK_Employee_Person_CCCDID",
                        column: x => x.CCCDID,
                        principalTable: "Person",
                        principalColumn: "CCCDID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.RenameColumn(
                name: "hoVaten",
                table: "Person",
                newName: "HovaTen");

            migrationBuilder.RenameColumn(
                name: "queQuan",
                table: "Person",
                newName: "Address");
        }
    }
}
