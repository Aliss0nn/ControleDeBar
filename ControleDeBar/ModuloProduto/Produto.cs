using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public int preco;
        public string nome;

        public Produto(int preco, string nome)
        {
            this.preco = preco;
            this.nome = nome;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto produtoAtualizado = (Produto)registroAtualizado;

            this.nome = produtoAtualizado.nome;
            this.preco = produtoAtualizado.preco;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if(nome == null)
                erros.Add(nome);

            if(preco == null)
                erros.Add(preco);

            return erros;
        }
    }
}
