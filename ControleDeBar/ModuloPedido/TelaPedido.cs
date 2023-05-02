using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloPedido
{
    public class TelaPedido : TelaBase
    {
        private RepositorioProduto repositorioProduto = null;
        private TelaProduto telaProduto = null;



        public TelaPedido(RepositorioPedido repositorioPedido)
        {
            this.repositorioBase = repositorioPedido;

            nomeEntidade = "Pedido";
            sufixo = "s";

        }




        public override void VisualizarContasEmAberto(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Quantidade");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Pedido pedido in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", pedido.id, pedido.produto, pedido.quantidadeSolicitada);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Produto produto = ObterProduto();

            Console.Write("Digite a Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor aproximado do total de produtos: ");
            int total = Convert.ToInt32(Console.ReadLine());

            return new Pedido(produto, quantidade,total);
        }

        private Produto ObterProduto()
        {
            telaProduto.VisualizarRegistros(false);

            Console.Write("\nDigite o id do Produto: ");
            int idProduto = Convert.ToInt32(Console.ReadLine());

            Produto produto = (Produto)repositorioProduto.SelecionarPorId(idProduto);

            Console.WriteLine();

            return produto;
        }
    }
}
