// See https://aka.ms/new-console-template for more information
var livros = new List<string>();

while (true)
{
    Console.WriteLine("_________MENU PRINCIPAL_________");
    Console.WriteLine("1- Cadastrar Livros");
    Console.WriteLine("2- Listar Livros");
    Console.WriteLine("3- Remover Livros");
    Console.WriteLine("0- Sair");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o Título do Livro");

            var nomeLivro = Console.ReadLine();

            livros.Add(nomeLivro);

            Console.WriteLine("Cadastro Efetuado com sucesso");

            break;
        case "2":
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
            break;
        case "3":

            Console.WriteLine("DIgite o nome do Livro");

            var removerLivro = Console.ReadLine();

            var removido = livros.Remove(removerLivro);

            if(removido)
            {

            Console.WriteLine("Removido com sucesso");

            }else
            {
                Console.WriteLine("Livro não encontrado");
            }

                break;
        case "0":
            Console.WriteLine("Encerrando a aaplicação...");
            return;
        default:
            Console.WriteLine("Op~ção Inválida");
            break;
    }
}

