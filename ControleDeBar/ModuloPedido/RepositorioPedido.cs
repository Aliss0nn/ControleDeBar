using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloPedido
{
    public class RepositorioPedido : RepositorioBase
    {

        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Pedido)base.SelecionarPorId(id);
        }

        public RepositorioPedido(ArrayList listaPedidos)
        {
            this.listaRegistros = listaPedidos;
        }


    }
}
