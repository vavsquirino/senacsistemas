using ListaAtividades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.Dominio
{
    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; } // 0 - pendente, 1 - concluída

        private readonly AtividadeRepositorio repositorio = new(); // instancia repositório criada para ser usadas diversas vezes

        public bool Criar() // criar uma nova atividade
        {
            if (!ValidarTitulo()) // verificar se o título é válido
            {
                return false;
            }

            repositorio.Criar(Titulo); // inserir no banco de dados

            return true;
        }

        public bool AtualizarSituacao()
        {
            if (!ValidarId()) // verificar se o id é válido (id maior que 0)
            {
                return false;
            }

            if (!ValidarSituacao()) // verificar se a situação é válida (situacao diferente de concluído)
            {
                return false;
            }

            Atividade atividadeEmAndamento = repositorio.BuscarAtividadeEmAndamento(); // buscar a atividade em andamento
            Situacao novaSituacao = BuscarProximaSituacao(); // buscar a próxima situação 

            if (atividadeEmAndamento.Id > 0 && atividadeEmAndamento.Situacao == novaSituacao) // verificar se a atividade em andamento é diferente da situação atual
            {
                return false;
            } // se a atividade em andamento for diferente da situação atual, não é possível atualizar a situação

            repositorio.AtualizarSituacao(Id, (int) novaSituacao); // atualizar a situação no banco de dados
            return true;
        }

        public Atividade BuscarAtividadeEmAndamento()
        {
            return new Atividade();
        }

        public List<Atividade> ListarAtividadePendentes()
        {
            return [];
        }

        private bool ValidarId()
        {
            return Id > 0;
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrEmpty(Titulo);
        }

        private bool ValidarSituacao()
        {
            return Situacao != Situacao.Concluído; // verificar se a situação é diferente de concluído
        }
        private Situacao BuscarProximaSituacao()
        {
            if (Situacao == Situacao.Pendente)
            {
                return Situacao.Realizando; // se a situação for pendente, retorna realizando
            }

            return Situacao.Concluído; // se a situação for concluído, retorna concluído
        }
    }

}

