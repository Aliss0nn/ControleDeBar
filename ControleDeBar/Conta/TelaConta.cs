using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ModuloFuncionario;
using ControleDeBar.ModuloMesa;
using ControleDeBar.ModuloPedido;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Conta
{
    public class TelaConta : TelaBase
    {
        #region
        private RepositorioGarcom repositorioGarcom;
        private RepositorioMesa repositorioMesa;
        private RepositorioPedido repositorioPedido;
        private RepositorioConta repositorioConta;
             
        private TelaGarcom telaGarcom;
        private TelaPedido telaPedido;
        private TelaMesa telaMesa;
        #endregion


        public TelaConta(RepositorioConta repositorioConta )
        {
            this.repositorioBase = repositorioConta;         
        }


       public override void VisualizarContasEmAberto(ArrayList registros)
        {
            Console.WriteLine();

            Console.WriteLine("{0, -10} | {1, -40}", "Id", "Status");

            Console.WriteLine("-------------------------------------------------------------------");

            foreach (Conta conta in registros)
            {
                string status = conta.estaAberto ? "Aberto" : "Fechado";

                Console.WriteLine("{0, -10} | {1, -40} | {2, -20} | {3, -20} | {4, -10}",
                    conta.id, status);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {          
            Mesa mesa = ObterMesa();

            Pedido pedido = ObterPedido();

            Garcom garcom = ObterGarcom();

            Console.Write("Digite o total Da Comanda: ");
            int totalDaComanda = int.Parse(Console.ReadLine());


            return new Conta(mesa, pedido, garcom , totalDaComanda);            
        }

        private Garcom ObterGarcom()
        {
            telaGarcom.VisualizarRegistros(false);

            Console.Write("\nDigite o id do Garçom: ");
            int idGarcom = Convert.ToInt32(Console.ReadLine());

            Garcom garcom = (Garcom)repositorioGarcom.SelecionarPorId(idGarcom);

            Console.WriteLine();

            return garcom;
        }

        private Pedido ObterPedido()
        {
            telaPedido.VisualizarRegistros(false);

            Console.Write("\nDigite o id do Pedido: ");
            int idPedido = Convert.ToInt32(Console.ReadLine());

            Pedido pedido = (Pedido)repositorioPedido.SelecionarPorId(idPedido);

            Console.WriteLine();

            return pedido;
        }

        private Mesa ObterMesa()
        {
            telaMesa.VisualizarRegistros(false);

            Console.Write("\nDigite o id do Pedido: ");
            int idMesa = Convert.ToInt32(Console.ReadLine());

            Mesa mesa = (Mesa)repositorioMesa.SelecionarPorId(idMesa);

            Console.WriteLine();

            return mesa;
        }


        public override void ExcluirRegistro()
        {
            MostrarCabecalho("Cadastro de Empréstimos", "Fechando um empréstimo...");



            ArrayList ContasemAberto = repositorioConta.SelecionarContasEmAberto();

            if (ContasemAberto.Count == 0)
            {
                MostrarMensagem("Nenhuma Conta Cadastrada", ConsoleColor.DarkYellow);
                return;
            }

            VisualizarContasEmAberto(ContasemAberto);

            //Escolher uma Conta

            Console.Write("Digite o id da Conta: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Conta conta = (Conta)repositorioConta.SelecionarPorId(id);

            //Fechar a Conta
            conta.Fechar();

            MostrarMensagem("Conta fechada com sucesso!", ConsoleColor.Green);
        }

        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Contas \n");

            Console.WriteLine("Digite 1 para Abrir uma nova Conta ");
            Console.WriteLine("Digite 2 para Visualizar as Contas");
       
            Console.WriteLine("Digite 3 para Fechar as Contas\n");
           
            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        
    }
}
