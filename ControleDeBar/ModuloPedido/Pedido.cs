using ControleDeBar.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloPedido
{
    public class Pedido : EntidadeBase
    {
        public Produto produto;
        public int quantidadeSolicitada;
        public int total;

        public Pedido(Produto produto, int quantidadeSolicitada, int total)
        {
            this.produto = produto;
            this.quantidadeSolicitada = quantidadeSolicitada;
            this.total = total;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Pedido pedidoAtualizado = (Pedido)registroAtualizado;

            this.quantidadeSolicitada = pedidoAtualizado.quantidadeSolicitada;
            this.produto = pedidoAtualizado.produto;
            this.total = pedidoAtualizado.total;
            
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if(total > 0)
                erros.Add(total);

            return erros;
        }
    }
}
