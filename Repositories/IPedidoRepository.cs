using WS_Lanches.Models;

namespace WS_Lanches.Repositories
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
