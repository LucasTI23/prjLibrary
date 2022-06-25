
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Livraria
{
    public class DVD : Produto
    {
        public string Diretor { get; set; }
        public string Ano { get; set; }
        public DVD(int ID, string Nome,
            string Fabricante, string Diretor,
            string Ano) :
            base(ID, Nome, Fabricante)
        {
            this.Diretor = Diretor;
            this.Ano = Ano;
        }
        public override void Imprimir()
        {
            Console.WriteLine(
                "ID:{0}\nNome:{1}\nEstúdio:{2}",
                ID, Nome, Fabricante);
            Console.WriteLine(
                "Diretor:{0}\nAno:{1}",
                Diretor, Ano);
        }
    }
}