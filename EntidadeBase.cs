using System;


public class EntidadeBase
{
    public abstract class EntidadeBase 
    {
        public int id;

        public abstract void AtualizarInformacoes(EntidadeBase registroAtualizado);

        public abstract ArrayList Validar();

    }
}
