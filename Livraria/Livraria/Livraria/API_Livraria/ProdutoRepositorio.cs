using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Livraria
{
    public class ProdutoRepositorio: iProdutoRepositorio
    {
        public List<Produto> Produtos { get; set; }

        public  ProdutoRepositorio( List<Produto> Produtos)
        {
            this.Produtos = Produtos;
        }

        public void Imprimir()
        {
            Produtos.ForEach(i => i.Imprimir());
        }
        public void Cadastrar(Produto p)
        {
            Produtos.Add(p);
        }

    }
}
