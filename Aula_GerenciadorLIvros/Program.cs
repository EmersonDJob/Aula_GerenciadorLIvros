// See https://aka.ms/new-console-template for more information
using Aula_GerenciadorLIvros.Models;
using Aula_GerenciadorLIvros.Services;

//var livros = new List<string>();


LivroService livrosService = new LivroService();

while (true)
{
    Console.WriteLine("_________MENU PRINCIPAL_________");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar Livros");
    Console.WriteLine("2 - Listar Livros");
    Console.WriteLine("3 - Remover Livros");
    Console.WriteLine("0 - Sair");
    Console.WriteLine();

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();

            Console.WriteLine("Digite o nome do Livro");

            livrosService.CadastroLivros();

            break;

        case "2":

            livrosService.ListarLivros();

            break;            

        case "3":
            Console.Clear();

            Console.WriteLine("Digite o nome do Livro");         

             break;
        case "0":
            Console.WriteLine("Encerrando a aplicação...");
            return;
        default:
            Console.WriteLine();
            Console.WriteLine("Opção Inválida");
            break;
    }
}

