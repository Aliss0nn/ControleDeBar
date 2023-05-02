using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public override void VisualizarContasEmAberto(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Preço");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Produto produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", produto.id, produto.nome, produto.preco);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do Produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço do Produto: ");
            int preco = int.Parse(Console.ReadLine());

            return new Produto(preco,nome);
        }

        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            this.repositorioBase = repositorioProduto;

            nomeEntidade = "Produto";
            sufixo = "s";
        }
    }
}
