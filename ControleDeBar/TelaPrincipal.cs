using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Controle de Medicamentos \n");

            Console.WriteLine("[1] - para Cadastrar o Garçom");
            Console.WriteLine("[2] - para Cadastrar Mesas");
            Console.WriteLine("[3] - para Cadastrar Produtos");
            Console.WriteLine("[4] - Menu de Contas\n");
         
            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
