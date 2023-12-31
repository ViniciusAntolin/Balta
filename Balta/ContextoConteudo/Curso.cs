﻿using Balta.ContextoConteudo.Enums;

namespace Balta.ContextoConteudo
{
    public class Curso : Conteudo
    {
        public Curso(string titulo, string url)
            : base(titulo, url)
        {
            Modulos = new List<Modulo>();
        }

        public Curso(string titulo, string url, IList<Modulo>? modulos, int duracaoEmMinutos, ENivelConteudo nivel)
            : base(titulo, url)
        {
            Modulos = modulos;
            DuracaoEmMinutos = duracaoEmMinutos;
            Nivel = nivel;
        }

        public string? Tag { get; set; }
        public IList<Modulo>? Modulos { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public ENivelConteudo Nivel { get; set; }
    }
}
