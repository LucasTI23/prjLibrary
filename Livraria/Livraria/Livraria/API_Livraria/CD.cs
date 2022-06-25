using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Livraria
{
    class CD : Produto
    {
        public string Lancamento { get; set; }
        public string Genero { get; set; }
        public CD(int ID, string Nome,
            string Fabricante, string Lancamento, string Genero) :
            base(ID, Nome, Fabricante)
        {
            this.Lancamento = Lancamento;
            this.Genero = Genero;
        }
        public override void Imprimir()
        {
            Console.WriteLine(
                "ID:{0}\nNome:{1}\nEstúdio:{2}",
                ID, Nome, Fabricante);
            Console.WriteLine(
                "Lancamento:{0}\nGenero:{1}",
                Lancamento, Genero);
        }
    }
}
