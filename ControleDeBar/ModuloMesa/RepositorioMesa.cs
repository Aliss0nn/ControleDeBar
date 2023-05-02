using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloMesa
{
    public class RepositorioMesa : RepositorioBase
    {

        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Mesa)base.SelecionarPorId(id);
        }


        public RepositorioMesa(ArrayList listaMesa)
        {
            this.listaRegistros = listaMesa;
        }






    }
}
