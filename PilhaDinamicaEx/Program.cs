using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica {

    class Program {
        static void Main(string[] args) {
            int op;

            Pilha pilha = new Pilha { Topo = null };

            do {
                Console.WriteLine("\n1-Inserir Livro\n2-Remover Livro\n3-Imprimir Pilha\n4-Quantidade de Elementos na Pilha" +
                    "\n5-Busca de Livro na Pilha por Título\n0-Sair");
                Console.Write("\nDigite uma opção: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op) {
                    case 1:
                        Livro livro;
                        livro = InserirLivro();
                        pilha.Push(livro);
                        break;

                    case 2:
                        pilha.Pop();
                        break;

                    case 3:
                        pilha.Imprimir();
                        break;

                    case 4:
                        pilha.QtdElementos();
                        break;

                    case 5:
                        pilha.BuscarLivro();
                        break;
                }
            } while (op != 0);
            
            Console.WriteLine("\nPressione qualquer tecla para fechar o programa");
            Console.ReadKey();
        }

        static Livro InserirLivro() {
            string titulo, autor;
            int isbn;

            Console.Write("Título do Livro: ");
            titulo = Console.ReadLine();

            Console.Write("Autor: ");
            autor = Console.ReadLine();

            Console.Write("Número de Identificação: ");
            isbn = int.Parse(Console.ReadLine());

            Livro x = new Livro { Titulo = titulo, Autor = autor, Isbn = isbn };
            return x;
        }
    }
}