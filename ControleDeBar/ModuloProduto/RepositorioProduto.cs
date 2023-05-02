using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloProduto
{
    public class RepositorioProduto : RepositorioBase
    {

        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Produto)base.SelecionarPorId(id);
        }

        public RepositorioProduto(ArrayList listaProduto)
        {
            this.listaRegistros = listaProduto;
        }
    }
}
