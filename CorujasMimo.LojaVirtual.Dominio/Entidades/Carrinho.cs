using System.Collections.Generic;
using System.Linq;

namespace CorujasMimo.LojaVirtual.Dominio.Entidades
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> _itemCarrinho = new List<ItemCarrinho>();
        //Adicionar
        public void AdicionarItem(Produtos produtos, int quantidade)
        {
            ItemCarrinho item = _itemCarrinho.FirstOrDefault(p => p.Produtos.ProdutoId == produtos.ProdutoId);

            if (item == null)
            {
                _itemCarrinho.Add(new ItemCarrinho
                {
                    Produtos = produtos,
                    Quantidade = quantidade
                });
            }
        }
        
        //Remover item do carrinho
        public void RemoverItem(Produtos produtos)
        {
            _itemCarrinho.RemoveAll(l => l.Produtos.ProdutoId == produtos.ProdutoId);
        }

        //Limpar carrinho
        public void LimparCarrinho(Produtos produtos)
        {
            _itemCarrinho.Clear();
        }
        
        //Obrter o valor total
        public decimal ObterValorTotal()
        {
            return _itemCarrinho.Sum(e => e.Produtos.Preco * e.Quantidade);
        }

        //Itens do carrinho
        public IEnumerable<ItemCarrinho> ItensCarrinho
        {
            get {return _itemCarrinho; }
        }
    }
}

