using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;

namespace ControleDeBar.ModuloFuncionario
{
    public class TelaGarcom : TelaBase
    {
        public TelaGarcom(RepositorioGarcom repositorioGarcom)
        {
            this.repositorioBase = repositorioGarcom;

            nomeEntidade = "Garçom";           
        }

        public override void VisualizarContasEmAberto(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Telefone");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Garcom garcom in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", garcom.id, garcom.nome, garcom.telefone);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do Garçom: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o número do telefone do Garçom: ");
            int telefone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o id: ");
            int id = Convert.ToInt32(Console.ReadLine());
           

            return new Garcom(telefone,nome,id);
        }
    }
}