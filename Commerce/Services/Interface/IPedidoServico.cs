using Commerce.Data.Entities;
using Commerce.Models;

namespace Commerce.Services.Interface
{
    public interface IPedidoServico
    {
        Task<Pedido> RegistrarPedido(List<ProdutoDTO> produtos);
    }
}
