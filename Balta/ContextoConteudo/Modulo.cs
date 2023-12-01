﻿using Balta.ContextoCompartilhado;

namespace Balta.ContextoConteudo
{
    public class Modulo : Base
    {
        public Modulo() => Aulas = new List<Aula>();
        public int Ordem { get; set; }
        public string? Titulo { get; set; }
        public IList<Aula>? Aulas { get; set; }
    }
}
