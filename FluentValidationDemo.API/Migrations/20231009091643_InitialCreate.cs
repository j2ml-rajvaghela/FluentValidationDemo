using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentValidationDemo.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employee_fluentvalidemo",
                columns: table => new
                {
                    employeeid = table.Column<long>(name: "employee_id", type: "Bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeename = table.Column<string>(name: "employee_name", type: "varchar(30)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    mobile = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_fluentvalidemo", x => x.employeeid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee_fluentvalidemo");
        }
    }
}
