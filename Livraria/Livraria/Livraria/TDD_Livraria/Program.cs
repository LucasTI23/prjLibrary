using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Livraria;
namespace TDD_LIVRARIA
{
    class Program
    {
        static void Main(string[] args)
        {
            iProdutoRepositorio banco;
            banco = new ProdutoRepositorio(
            new List<Produto>()
            );

            banco.Cadastrar (
                new Livro(1, "DOM CASMURRO","RECORD","MACHADO DE ASSIS","123456"));

            banco.Cadastrar(
                new DVD(2, "CIDADAO KANE","PARAMOUNT", "ORSON WELLS","1948"));

            banco.Cadastrar(
            new CD(3, "CARMINS BURANA", "DECA", "1989", "ERUDITO"));

            banco.Imprimir();
            Console.ReadKey();
        }
    }
}