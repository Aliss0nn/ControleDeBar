using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        public override void VisualizarContasEmAberto(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Pedido", "Ocupado");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", mesa.id, mesa.pedidio, mesa.estaOcupado);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o Pedido: ");
            string pedido = Console.ReadLine();

            Console.Write("Digite se a mesa esta ocupada: ");
            string estaOcupado = Console.ReadLine();

            Console.Write("Digite o id: ");
            int id = Convert.ToInt32(Console.ReadLine());


            return new Mesa(pedido, estaOcupado, id);
        }

        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            this.repositorioBase = repositorioMesa;

            nomeEntidade = "Mesa";
            sufixo = "s";

        }


    }
}
