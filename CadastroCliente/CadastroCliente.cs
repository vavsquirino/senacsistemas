using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class CadastroCliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public EnderecoCliente endereco { get; set; }
        public GeneroCliente genero { get; set; }
        public string nomeSocial { get; set; }
        public EtniaCliente etnia { get; set; }
        public bool estrangeiro { get; set; }
        public TipoCliente tipo { get; set; }
    } 
}
