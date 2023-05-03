using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ModuloFuncionario;
using ControleDeBar.ModuloMesa;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;


namespace ControleDeBar.Conta
{
    public class TelaConta : TelaBase
    {
        #region
        private RepositorioGarcom repositorioGarcom;
        private RepositorioMesa repositorioMesa;
        private RepositorioConta repositorioConta;

        private TelaGarcom telaGarcom;
        private TelaMesa telaMesa;       
        #endregion

    
        public TelaConta(RepositorioGarcom repositorioGarcom, 
            RepositorioMesa repositorioMesa,
            RepositorioConta repositorioConta,
            TelaGarcom telaGarcom, TelaMesa telaMesa)
        {
            this.repositorioBase = repositorioConta;
            this.repositorioGarcom = repositorioGarcom;
            this.repositorioMesa = repositorioMesa;
            this.repositorioConta = repositorioConta;
            this.telaGarcom = telaGarcom;
            this.telaMesa = telaMesa;

            nomeEntidade = "Conta";
            sufixo = "s";
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


            return new Conta(mesa, garcom , totalDaComanda,pedido);            
        }

        private Pedido ObterPedido()
        {
            Console.Write("Digite o Pedido: ");
            string pedido = Console.ReadLine();

            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            return new Pedido(quantidade, pedido);
        }

        private Garcom ObterGarcom()
        {
            this.telaGarcom.VisualizarRegistros(false);

            Console.Write("\nDigite o id do Garçom: ");
            int idGarcom = Convert.ToInt32(Console.ReadLine());

            Garcom garcom = (Garcom)repositorioGarcom.SelecionarPorId(idGarcom);

            Console.WriteLine();

            return garcom;
        }
    
        private Mesa ObterMesa()
        {
            this.telaMesa.VisualizarRegistros(false);

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

            Console.WriteLine("[1] para Abrir uma nova Conta ");
            Console.WriteLine("[2] para Visualizar as Contas");       
            Console.WriteLine("[3] para Fechar as Contas");
            Console.WriteLine("[4] para ver o total faturado\n");



            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void AbrirNovaConta()
        {
            base.InserirNovoRegistro();
        }

        
    }
}
