using System;

namespace DIO.Livros{
    class Program{
        static LivroRepositorio repositorio =  new LivroRepositorio();
        static void Main(string[] args){
            string opcaoUsuario = Menu();

            while(opcaoUsuario.ToUpper() != "X"){
                switch (opcaoUsuario){
                    case "1":
                        ListarLivros();
                        break;
                    case "2":
                        InserirLivro();
                        break;
                    case "3":
                        AtualizarLivro();
                        break;
                    case "4":
                        ExcluirLivro();
                        break;
                    case "5":
                        VisualizarLivro();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        private static void VisualizarLivro(){
            Console.Write("Digite o id do livro:");
            int indiceLivro = int.Parse(Console.ReadLine());

            var livro = repositorio.retornaPorId(indiceLivro);
            Console.WriteLine(livro);
        }
        private static void ExcluirLivro(){
            Console.Write("Digite o id do livro:");
            int indiceLivro = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceLivro);
        }
        private static void AtualizarLivro(){
            Console.WriteLine("Digite o id do livro: ");
            int indiceLivro = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero =  int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do livro: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento do livro:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do autor: ");
            string entradaNomeAutor = Console.ReadLine();

            Console.Write("Digite o número de páginas: ");
            int entradaNumPag = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do livro: ");
            string entradaDescricao = Console.ReadLine();

            Livros atualizaLivro = new Livros(
                id: indiceLivro,
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno,
                paginas: entradaNumPag,
                autor: entradaNomeAutor
            );
            repositorio.Atualiza(indiceLivro, atualizaLivro);
        }
        private static void ListarLivros(){
            Console.WriteLine("Listar Livros");
            var lista =  repositorio.Lista();

            if(lista.Count == 0){
                Console.WriteLine("Nenhum livro cadastrado");
                return;
            }

            foreach(var livro in lista){
                var excluido = livro.retornaExcluido();
                if(!excluido)
                    Console.WriteLine("#ID {0}: - {1}", livro.retornaId(), livro.retornaTitulo());
            }
        }
        private static void InserirLivro(){
            Console.WriteLine("Inserir livro novo");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero =  int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do livro: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento do livro:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do autor: ");
            string entradaNomeAutor = Console.ReadLine();

            Console.Write("Digite o número de páginas: ");
            int entradaNumPag = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do livro: ");
            string entradaDescricao = Console.ReadLine();

            Livros novoLivro = new Livros(
                id: repositorio.Proximoid(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno,
                paginas: entradaNumPag,
                autor: entradaNomeAutor
            );
            repositorio.Insere(novoLivro);
        }
        private static string Menu(){
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Listar Livros");
            Console.WriteLine("2 - Inserir novo livro");
            Console.WriteLine("3 - Atualizar livro");
            Console.WriteLine("4 - Excluir livro");
            Console.WriteLine("5 - Visualizar livro");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
