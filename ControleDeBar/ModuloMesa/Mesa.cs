using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string pedidio = "";
        public string estaOcupado;
        public int id;

        public Mesa(string pedidio, string estaOcupado, int id)
        {
            this.pedidio = pedidio;
            this.estaOcupado = estaOcupado;
            this.id = id;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizada = (Mesa)registroAtualizado;

            this.pedidio = mesaAtualizada.pedidio;
            this.estaOcupado = mesaAtualizada.estaOcupado;
            this.id = mesaAtualizada.id;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if(this.pedidio == null)
                erros.Add(this.pedidio);

            return erros;
        }
    }
}
