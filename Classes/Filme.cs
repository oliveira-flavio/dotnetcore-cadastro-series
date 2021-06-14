using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries.Classes
{
    class Filme : EntidadeBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Estudio { get; set; }
        public int AnoLancamento { get; set; }
        public string TempoDuracao { get; set; }
        public bool Excluido { get; set; }

        public Filme(int id, Genero genero, string titulo, string descricao, string estudio, int anoLancamento, string tempoDuracao, bool excluido)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Estudio = estudio;
            AnoLancamento = anoLancamento;
            TempoDuracao = tempoDuracao;
            Excluido = excluido;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Titulo: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Estúdio: " + Estudio + Environment.NewLine;
            retorno += "Ano de Lançamento: " + AnoLancamento + Environment.NewLine;
            retorno += "Tempo de Duração: " + TempoDuracao + Environment.NewLine;
            retorno += "Excluído: " + Excluido;

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
        public void Excluir()
        {
            Excluido = true;
        }
        public bool retornarExcluido()
        {
            return Excluido;
        }
    }
}
