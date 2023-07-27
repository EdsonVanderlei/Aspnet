using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class removepro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Pedidos_EntregaId",
                table: "Entrega");

            migrationBuilder.RenameColumn(
                name: "EntregaId",
                table: "Entrega",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrega_EntregaId",
                table: "Entrega",
                newName: "IX_Entrega_PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Pedidos_PedidoId",
                table: "Entrega",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Pedidos_PedidoId",
                table: "Entrega");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Entrega",
                newName: "EntregaId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrega_PedidoId",
                table: "Entrega",
                newName: "IX_Entrega_EntregaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Pedidos_EntregaId",
                table: "Entrega",
                column: "EntregaId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
