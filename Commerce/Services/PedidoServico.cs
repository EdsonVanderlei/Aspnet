using Commerce.Data.Entities;
using Commerce.Models;
using Commerce.Services.Interface;

namespace Commerce.Services
{
    public class PedidoServico : IPedidoServico
    {


        public Task<Pedido> RegistrarPedido(List<ProdutoDTO> produtos)
        {
            throw new NotImplementedException();
        }
    }
}
