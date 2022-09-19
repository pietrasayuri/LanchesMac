using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDbContext appDbContext, CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _appDbContext.Pedidos.Add(pedido);
            _appDbContext.SaveChanges();

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItems; 

            foreach(var carrinhoitem in carrinhoCompraItens)
            {
                var pedidoDetail = new PedidoDetalhe()
                {
                    Quantidade = carrinhoitem.Quantidade,
                    LancheId = carrinhoitem.Lanche.LancheId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoitem.Lanche.Preco
                };
                _appDbContext.PedidoDetalhes.Add(pedidoDetail);
            }
            _appDbContext.SaveChanges(); 
        }
    }
}
