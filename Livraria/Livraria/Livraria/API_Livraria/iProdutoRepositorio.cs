using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Livraria
{
    public interface iProdutoRepositorio
    {
        void Imprimir();
        void Cadastrar(Produto p);
    }
}
