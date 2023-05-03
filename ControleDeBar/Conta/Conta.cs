using ControleDeBar.ModuloFuncionario;
using ControleDeBar.ModuloMesa;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleDeBar.Conta
{
    public class Conta : EntidadeBase
    {
        Mesa mesa;
        Pedido pedido;
        Garcom garcom;
        int totalDaComanda;
        public bool estaAberto;

        public Conta( Mesa mesa,Garcom garcom, int totalDaComanda, Pedido pedido)
        {
            this.mesa = mesa;
            this.pedido = pedido;
            this.garcom = garcom;
            this.totalDaComanda = totalDaComanda;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta contaAtualizada = (Conta)registroAtualizado;

            mesa = contaAtualizada.mesa;
           
            garcom = contaAtualizada.garcom;
            totalDaComanda = contaAtualizada.totalDaComanda;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if(totalDaComanda == 0)
                erros.Add(totalDaComanda);

            return erros;
        }

        public void Fechar()
        {
            if (estaAberto)
            {
                estaAberto = false;              
            }
        }




    }
}
