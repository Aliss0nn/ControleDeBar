﻿using System;
using System.Collections;

public abstract class EntidadeBase 
{
        public int id;

        public abstract void AtualizarInformacoes(EntidadeBase registroAtualizado);

       public abstract ArrayList Validar();

}

