using System;

namespace AppCadastroSeries
{
    public class Serie : EntidadeBase
    {
        //Atributos

        private Genero Genero { get; set; }

        private string Título { get; set; }

        private string Descricao { get; set; }
        
        private int Ano { get; set; }

        private bool Excluído {get; set; }

        //Métodos

        public Serie(int id, Genero genero, string título, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Título = título;
            this.Descricao = descricao;
            this.Ano = ano;

            this.Excluído = false;
        }

        public override string ToString()
        {
             //Environment.NewLine https://dosc.microsoft.com/en-us/dotnet/aps/sustem.environment.new
            string retorno = "";
            retorno += "Gênero:" + this.Genero + Environment.NewLine;
            retorno += "Título:" + this.Título + Environment.NewLine;
            retorno += "Descrição:" + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início:" + this.Ano;

            retorno += "Excluído:" + this.Excluído;
            return retorno;
        }

        public string retornaTítulo()
        {
            return this.Título;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluído()
        {
            return this.Excluído;
        }
        public void Excluir()
        {
            this.Excluído = true;
        }
    }
}