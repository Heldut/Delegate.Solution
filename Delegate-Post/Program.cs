using System;
using System.Collections.Generic;

namespace Delegate_Post
{
	/*
    
        No projeto "DELEGATE-POST-INICIO" vimos a implementação da solucão sem o uso de
        delegate. Aqui vamos implementar o delegate.
        Temos a classe POST e o método PopulaObjetoPost que preenche uma lista de POST.

    */

	class Program
    {
		delegate bool CondicaoPost(Post post);
		delegate void AcaoEmUmPost(Post post);

		static void Main(string[] args)
        {
			List<Post> posts = PopulaObjetoPost();

			ExecutaAcaoEmListaFiltradaDePosts(posts, CondicaoPost("Filme"), AcaoEmUmPost("Filme"));
		}

		public static void ExecutaAcaoEmListaFiltradaDePosts(IEnumerable posts, CondicaoPost condicaoQualquer, AcaoEmUmPost acaoQualquer)
		{
			foreach (var post in posts)
			{
				if (condicaoQualquer(post))
				{
					acaoQualquer(post);
				}
			}
		}

		public static List<Post> PopulaObjetoPost()
		{
			var posts = new List<Post> {
				new Post
				{
					Titulo = "Poderoso Chefão",
					Resumo = "Parte I",
					Categoria = "Filme"
				},
				new Post
				{
					Titulo = "Palhaço",
					Resumo = "Shelton Mello",
					Categoria = "Filme"
				},
				new Post
				{
					Titulo = "2 Colehos",
					Resumo = "Filme Nacional",
					Categoria = "Filme"
				},
				new Post
				{
					Titulo = "Game of Thrones",
					Resumo = "Winter is Coming",
					Categoria = "Série"
				},
				new Post
				{
					Titulo = "Dexter",
					Resumo = "Crocodile",
					Categoria = "Série"
				},
				new Post
				{
					Titulo = "Better Call Saul",
					Resumo = "Bingo",
					Categoria = "Série"
				},
				new Post
				{
					Titulo = "Vikings",
					Resumo = "Raid",
					Categoria = "Série"
				},
				new Post
				{
					Titulo = "10 dicas para começar uma carreira de programador",
					Resumo = "Orientações de carreira",
					Categoria = "Dica"
				},
				new Post
				{
					Titulo = "Refactoring",
					Resumo = "Improving design of existing code",
					Categoria = "Livro"
				},
				new Post
				{
					Titulo = "Visual C# 2008",
					Resumo = "Estudo da Linguagem C#",
					Categoria = "Livro"
				},
				new Post
				{
					Titulo = "Como Proramar C#",
					Resumo = "Estudo da Linguagem C# - Deitel",
					Categoria = "Livro"
				}
			};

			return posts;
		}
	}

    public class Post
    {
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public string Categoria { get; set; }
    }
}
