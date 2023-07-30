using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class ToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Enderecos_EnderecoId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Pedidos_PedidoId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Pedidos_PedidoId",
                table: "PedidoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Produtos_ProdutoId",
                table: "PedidoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categoria_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrega",
                table: "Entrega");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "PedidoProduto",
                newName: "PedidosProdutos");

            migrationBuilder.RenameTable(
                name: "Entrega",
                newName: "Entregas");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProduto_ProdutoId",
                table: "PedidosProdutos",
                newName: "IX_PedidosProdutos_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProduto_PedidoId",
                table: "PedidosProdutos",
                newName: "IX_PedidosProdutos_PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrega_PedidoId",
                table: "Entregas",
                newName: "IX_Entregas_PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrega_EnderecoId",
                table: "Entregas",
                newName: "IX_Entregas_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidosProdutos",
                table: "PedidosProdutos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entregas",
                table: "Entregas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Enderecos_EnderecoId",
                table: "Entregas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Pedidos_PedidoId",
                table: "Entregas",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosProdutos_Pedidos_PedidoId",
                table: "PedidosProdutos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosProdutos_Produtos_ProdutoId",
                table: "PedidosProdutos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Enderecos_EnderecoId",
                table: "Entregas");

            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Pedidos_PedidoId",
                table: "Entregas");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosProdutos_Pedidos_PedidoId",
                table: "PedidosProdutos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosProdutos_Produtos_ProdutoId",
                table: "PedidosProdutos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidosProdutos",
                table: "PedidosProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entregas",
                table: "Entregas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "PedidosProdutos",
                newName: "PedidoProduto");

            migrationBuilder.RenameTable(
                name: "Entregas",
                newName: "Entrega");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.RenameIndex(
                name: "IX_PedidosProdutos_ProdutoId",
                table: "PedidoProduto",
                newName: "IX_PedidoProduto_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidosProdutos_PedidoId",
                table: "PedidoProduto",
                newName: "IX_PedidoProduto_PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Entregas_PedidoId",
                table: "Entrega",
                newName: "IX_Entrega_PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Entregas_EnderecoId",
                table: "Entrega",
                newName: "IX_Entrega_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrega",
                table: "Entrega",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Enderecos_EnderecoId",
                table: "Entrega",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Pedidos_PedidoId",
                table: "Entrega",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Pedidos_PedidoId",
                table: "PedidoProduto",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Produtos_ProdutoId",
                table: "PedidoProduto",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categoria_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id");
        }
    }
}
