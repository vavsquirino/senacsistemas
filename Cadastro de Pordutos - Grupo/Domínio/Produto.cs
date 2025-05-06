using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pordutos___Grupo.Domínio
{
    internal class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataProduto { get; set; }  

        private readonly ListaDeProdutosRepositorio repositorio = new ();

        public bool Criar ()
        {
            if (string.IsNullOrEmpty(nome))
            {
                return false;
            }
            if (dataProduto == DateTime.MinValue)
            {
                return false;
            } // verifica se a data é válida
            
            repositorio.Criar(nome, dataProduto);
            return true;
        }
    }
}
