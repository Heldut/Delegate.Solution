using System;
using System.Collections.Generic;

namespace Delegate_Post_Inicio
{
	/*
		Aqui temos a classe POST e um metodo que popula o objeto POST.
		Também criamos um método AdicionaPostNoCorpoDoEmai e um metodo
		PostEhDaCategoriaFilmes. O primeiro coloca o titulo em um corpo de
		e-mail. O segundo verifica se a categoria é filmes. Ambos metodos
		são executados nos 2 laços for dentro do método main().
		No projeto "DELEGATE-POST" vamos ver como implementar esse
		código com o uso do DELEGATE.
	*/

	class Program
    {
		static void Main(string[] args)
		{
			List<Post> postList = new List<Post>();
			postList = PopulaObjetoPost();

			foreach (var post in postList)
			{
				if (PostEhDaCategoriaFilmes(post))
				{
					Console.WriteLine(post.Titulo);
				}
			}

			foreach (var post in postList)
			{
				if (PostEhDaCategoriaFilmes(post))
				{
					AdicionaPostNoCorpoDoEmai(post);
				}
			}
		}


		public static void AdicionaPostNoCorpoDoEmai(Post post)
		{
			Console.WriteLine("Corpo do e-mail: " + post.Titulo);
		}

		private static bool PostEhDaCategoriaFilmes(Post post)
		{
			return post.Categoria == "Filme";
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
