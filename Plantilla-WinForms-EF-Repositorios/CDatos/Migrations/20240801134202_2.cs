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
            migrationBuilder.DropForeignKey(
                name: "FK_CopiaLibro_Prestamo_IdPrestamo",
                table: "CopiaLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_Libro_Venta_IdVenta",
                table: "Libro");

            migrationBuilder.DropIndex(
                name: "IX_Libro_IdVenta",
                table: "Libro");

            migrationBuilder.DropIndex(
                name: "IX_CopiaLibro_IdPrestamo",
                table: "CopiaLibro");

            migrationBuilder.DropColumn(
                name: "IdVenta",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "IdPrestamo",
                table: "CopiaLibro");

            migrationBuilder.AddColumn<int>(
                name: "IdLibro",
                table: "Venta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCopia",
                table: "Prestamo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdLibro",
                table: "Venta",
                column: "IdLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdCopia",
                table: "Prestamo",
                column: "IdCopia");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_CopiaLibro_IdCopia",
                table: "Prestamo",
                column: "IdCopia",
                principalTable: "CopiaLibro",
                principalColumn: "IdCopiaLibro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Libro_IdLibro",
                table: "Venta",
                column: "IdLibro",
                principalTable: "Libro",
                principalColumn: "IdLibro",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_CopiaLibro_IdCopia",
                table: "Prestamo");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Libro_IdLibro",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_IdLibro",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_IdCopia",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "IdLibro",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "IdCopia",
                table: "Prestamo");

            migrationBuilder.AddColumn<int>(
                name: "IdVenta",
                table: "Libro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPrestamo",
                table: "CopiaLibro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Libro_IdVenta",
                table: "Libro",
                column: "IdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_CopiaLibro_IdPrestamo",
                table: "CopiaLibro",
                column: "IdPrestamo");

            migrationBuilder.AddForeignKey(
                name: "FK_CopiaLibro_Prestamo_IdPrestamo",
                table: "CopiaLibro",
                column: "IdPrestamo",
                principalTable: "Prestamo",
                principalColumn: "IdPrestamo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Libro_Venta_IdVenta",
                table: "Libro",
                column: "IdVenta",
                principalTable: "Venta",
                principalColumn: "IdVenta",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
