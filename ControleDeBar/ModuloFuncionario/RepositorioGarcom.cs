using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;



namespace ControleDeBar.ModuloFuncionario
{
    public class RepositorioGarcom : RepositorioBase
    {

        public RepositorioGarcom(ArrayList listaGarcom)
        {
            this.listaRegistros = listaGarcom;
        }

        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Garcom)base.SelecionarPorId(id);
        }
    }
}







  
