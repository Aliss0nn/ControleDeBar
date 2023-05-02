using ControleDeBar.Conta;
using ControleDeBar.ModuloFuncionario;
using ControleDeBar.ModuloMesa;
using ControleDeBar.ModuloPedido;
using ControleDeBar.ModuloProduto;
using System;
using System.Collections;

namespace ControleDeBar
{
    public class Program
    {

        static void Main(string[] args)
        {

            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            RepositorioProduto repositorioProduto = new RepositorioProduto(new ArrayList());
            RepositorioPedido repositorioPedido = new RepositorioPedido(new ArrayList());
            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());


            TelaPrincipal telaprincipal = new TelaPrincipal();
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);
            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
            TelaPedido telaPedido = new TelaPedido(repositorioPedido);
            TelaConta telaConta = new TelaConta(repositorioConta);



            while (true)
            {
                string opcao = telaprincipal.ApresentarMenu();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string subMenu = telaGarcom.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaGarcom.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaGarcom.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaGarcom.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaGarcom.ExcluirRegistro();
                    }
                }

                if (opcao == "2")
                {
                    string subMenu = telaMesa.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaMesa.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaMesa.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaMesa.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaMesa.ExcluirRegistro();
                    }
                }
                if (opcao == "3")
                {
                    string subMenu = telaProduto.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaProduto.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaProduto.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaProduto.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaProduto.ExcluirRegistro();
                    }
                }
                if (opcao == "4")
                {
                    string subMenu = telaPedido.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaPedido.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaPedido.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaPedido.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaPedido.ExcluirRegistro();
                    }

                }
                if (opcao == "5")
                {
                    string subMenu = telaConta.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaConta.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        ArrayList registros = new ArrayList();
                        telaConta.VisualizarContasEmAberto(registros);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaPedido.ExcluirRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaPedido.ExcluirRegistro();
                    }
                }



            }

        }
    }
}
