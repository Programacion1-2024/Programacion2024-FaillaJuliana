using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEmpleado",
                table: "Venta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpleado",
                table: "Prestamo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdLibro",
                table: "CopiaLibro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdEmpleado",
                table: "Venta",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdEmpleado",
                table: "Prestamo",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_CopiaLibro_IdLibro",
                table: "CopiaLibro",
                column: "IdLibro");

            migrationBuilder.AddForeignKey(
                name: "FK_CopiaLibro_Libro_IdLibro",
                table: "CopiaLibro",
                column: "IdLibro",
                principalTable: "Libro",
                principalColumn: "IdLibro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Empleado_IdEmpleado",
                table: "Prestamo",
                column: "IdEmpleado",
                principalTable: "Empleado",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Empleado_IdEmpleado",
                table: "Venta",
                column: "IdEmpleado",
                principalTable: "Empleado",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CopiaLibro_Libro_IdLibro",
                table: "CopiaLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Empleado_IdEmpleado",
                table: "Prestamo");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Empleado_IdEmpleado",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_IdEmpleado",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_IdEmpleado",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_CopiaLibro_IdLibro",
                table: "CopiaLibro");

            migrationBuilder.DropColumn(
                name: "IdEmpleado",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "IdEmpleado",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "IdLibro",
                table: "CopiaLibro");
        }
    }
}
