using ControleDeBar.ModuloFuncionario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Conta
{
    public class Pedido : EntidadeBase
    {
        public int quantidade;
        public string pedido;

        public Pedido(int quantidade, string pedido)
        {
            this.quantidade = quantidade;
            this.pedido = pedido;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Pedido pedidoAtualizado = (Pedido)registroAtualizado;
        }

        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }
}
