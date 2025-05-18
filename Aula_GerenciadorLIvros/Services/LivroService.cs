using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_GerenciadorLIvros.Models;

namespace Aula_GerenciadorLIvros.Services
{
    public class LivroService
    {
        // Cadastro de livros  
        private List<Livros> novoLivros = new List<Livros>(); // MEU BANCO TEMPORARIO  

        public void CadastroLivros()
        {
            Console.Clear();

            Livros novoLivro = new Livros();

            Console.WriteLine("== Cadastro Realizado ==");

            do
            {
                Console.WriteLine("TItulo");
                novoLivro.Titulo = Console.ReadLine();
            } while (string.IsNullOrEmpty(novoLivro.Titulo));
            do
            {
                Console.WriteLine("Autor");
                novoLivro.Autor = Console.ReadLine();
            } while (string.IsNullOrEmpty(novoLivro.Autor));

            Console.WriteLine("Genero");
            novoLivro.Genero = Console.ReadLine();
            Console.WriteLine("Descrição");
            novoLivro.Descricao = Console.ReadLine();

            bool anoValido;
            do
            {
                Console.WriteLine("Ano de Publicação");

                string anoDigitado = Console.ReadLine();

                int anoTemp;

                anoValido = int.TryParse(anoDigitado, out anoTemp) && anoTemp > 0 && anoTemp <= DateTime.Now.Year;

                if (!anoValido)
                    Console.WriteLine($"Ano inválido! Digite entre 1 e {DateTime.Now.Year}");

            } while (!anoValido);
            novoLivros.Add(novoLivro);
        }

        public void ListarLivros() // Alterado de static para não estático  
        {
            Console.Clear();
            Console.WriteLine("=== LISTA DE LIVROS ===\n");

            foreach (Livros meuslivros in novoLivros)
            {
                Console.WriteLine($"Título: {meuslivros.Titulo}");
                Console.WriteLine($"Autor: {meuslivros.Autor}\n");
            }
            Console.ReadKey();
        }
    }
}
