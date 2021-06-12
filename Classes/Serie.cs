using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries.Classes
{
    class Serie : EntidadeBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Titulo: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de início: " + Ano + Environment.NewLine;

            return retorno;
        }

        public string retornaTitulo()
        {
            return Titulo;
        }
        public int retornaId()
        {
            return Id;
        }
    }
}
