using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Conta
{
    public  class RepositorioConta : RepositorioBase
    {
        public RepositorioConta(ArrayList listaContas)
        {
            this.listaRegistros = listaContas;
        }

        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Conta)base.SelecionarPorId(id);
        }

        public ArrayList SelecionarContasEmAberto()
        {
            ArrayList contasEmAberto = new ArrayList();

            foreach (Conta c in listaRegistros)
            {
                if (c.estaAberto)
                    contasEmAberto.Add(c);
            }

            return contasEmAberto;
        }



    }
}
