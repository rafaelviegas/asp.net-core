﻿
namespace casa_do_codigo.Models
{
    public class ItemPedido
    {
    public int Id { get; private set; }
    public Produto Produto { get; private set; }
    public int Quantidade { get; private set; }
    public decimal PrecoUnitario { get; private set; }
    public decimal Subtotal { get { return this.Quantidade * this.PrecoUnitario; }  }

    public ItemPedido(int id, Produto produto, int quantidade): this(produto,quantidade){
            this.Id = id;
    }

    public ItemPedido(Produto produto, int quantidade)
    {
        this.Produto = produto;
        this.Quantidade = quantidade;
        this.PrecoUnitario = produto.Preco;
    }
        protected ItemPedido(){}

    }
}
