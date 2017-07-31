

namespace casa_do_codigo.Models
{

    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }

    public Produto(int id, string nome, decimal preco)
    {
        this.Id = id;
    }
        public Produto(string nome, decimal preco)
        {
            this.Nome = nome;
            this.Preco = preco;

        }
        protected Produto(){}

    }
}
