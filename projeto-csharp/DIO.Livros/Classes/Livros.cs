namespace DIO.Livros
{
    public class Livros: EntidadeBase
    {
         private Genero Genero{ get; set;}
         private string Titulo{get;set;}
         private string Descricao{get;set;}
         private int Ano{get;set;}
         private int Paginas{get;set;}
         private string Autor{get;set;}
         private bool Excluido{get;set;}
         public Livros(int id, Genero genero, string titulo, string descricao, int ano, int paginas, string autor){
             this.Id = id;
             this.Genero = genero;
             this.Titulo = titulo;
             this.Descricao = descricao;
             this.Ano = ano;
             this.Paginas = paginas;
             this.Autor = autor;
             this.Excluido =  false; 
         }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Autor: " + this.Autor + Environment.NewLine;
            retorno += "Páginas: " + this.Paginas + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            return retorno;
        }
        public string retornaTitulo(){
            return this.Titulo;
        }
        public int retornaId(){
            return this.Id;
        }
        public bool retornaExcluido(){
            return Excluido;
        }
        public void Exclui(){
            this.Excluido = true;
        }
    }
}