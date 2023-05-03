using ControleDeBar.Conta;
using ControleDeBar.ModuloFuncionario;
using ControleDeBar.ModuloMesa;

using ControleDeBar.ModuloProduto;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace ControleDeBar
{
    public class Program
    {
      




        static void Main(string[] args)
        {

            
            #region instâncias
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            RepositorioProduto repositorioProduto = new RepositorioProduto(new ArrayList());
            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());

            TelaPrincipal telaprincipal = new TelaPrincipal();
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);
            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
            TelaConta telaConta = new TelaConta(repositorioGarcom, repositorioMesa, repositorioConta, telaGarcom, telaMesa);
            #endregion

            static void CadastrarAutomaticamente(RepositorioGarcom repositorioGarcom, RepositorioMesa repositorioMesa, RepositorioProduto repositorioProduto)
            {
                Garcom garcom1 = new Garcom(88445566, "Mario", 1);
                Garcom garcom2 = new Garcom(22445599, "Felipe", 2);
                Garcom garcom3 = new Garcom(44553366, "Wesley", 3);

                repositorioGarcom.Inserir(garcom1);
                repositorioGarcom.Inserir(garcom2);
                repositorioGarcom.Inserir(garcom3);

                Mesa mesa1 = new Mesa("Batata Frita", "Sim", 1);
                Mesa mesa2 = new Mesa("Cerveja e Fritas", "Sim", 2);

                repositorioMesa.Inserir(mesa1);
                repositorioMesa.Inserir(mesa2);

                Produto produto1 = new Produto(20, "Batata Frita");
                Produto produto2 = new Produto(8, "Cerveja");

                repositorioProduto.Inserir(produto1);
                repositorioProduto.Inserir(produto2);
            }


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
                        CadastrarAutomaticamente(repositorioGarcom, repositorioMesa, repositorioProduto);
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
                    string subMenu = telaConta.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaConta.AbrirNovaConta();
                    }
                    else if (subMenu == "2")
                    {
                        
                        ArrayList registros = new ArrayList();
                        telaConta.VisualizarContasEmAberto(registros);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {

                    }
                    else if (subMenu == "4")
                    {

                    }
                }



            }

           


        }
    }
}
