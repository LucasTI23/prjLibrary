using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Livraria
{
    public abstract class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public Produto(int ID, string Nome, string Fabricante)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.Fabricante = Fabricante;
        }
        public abstract void Imprimir();
    }
}
