using System;
using System.Collections;

namespace ControleDeBar.ModuloFuncionario
{

    public class Garcom : EntidadeBase
    {

        public int telefone;
        public string nome;
        public int id;

        public Garcom(int telefone, string nome, int id)
        {
            this.telefone = telefone;
            this.nome = nome;  
            this.id = id;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom garcomAtualizado = (Garcom)registroAtualizado;

            this.nome = garcomAtualizado.nome;
            this.telefone = garcomAtualizado.telefone;
            this.id= garcomAtualizado.id;

        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (nome == null)
                erros.Add(nome);

            return erros;

        }
    }



}
