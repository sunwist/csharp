using System;
using System.Globalization;

namespace exemploEstoque
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int qtd)
        {
            quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            quantidade -= qtd;
        }

        // sobreposicao
        public override string ToString()
        {
            return nome + ", $ " + preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " + quantidade + " unidades, Total $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}
