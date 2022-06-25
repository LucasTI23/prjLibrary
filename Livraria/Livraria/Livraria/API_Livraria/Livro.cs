using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Livraria
{
    public class Livro: Produto
    {
        public string Autor { get; set; }
        public string ISBN  { get; set;}
        public Livro(int ID, string Nome, string Fabricante, string Autor, string ISBN):
            base(ID, Nome, Fabricante)
        {
            this.Autor = Autor;
            this.ISBN = ISBN;
        }

        public override void Imprimir()
        {
            Console.WriteLine(
                "ID: {0}\nNome: {1}\nFabricante: {2}",
                ID, Nome, Fabricante
                );
            Console.WriteLine(
               "Autor: {0}\nISBN: {1}",
                Autor, ISBN
               );
        }
    }
}
