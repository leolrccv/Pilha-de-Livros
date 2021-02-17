using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica {
    class Pilha {
        public Livro Topo { get; set; }

        public void Push(Livro aux) {
            //if (vazia()) //Verifica se a pilha está vazia
            //{
            //    Topo = aux;
            //}
            //else
            //{
            aux.Anterior = Topo;
            Topo = aux;
            //}
            Console.WriteLine("Elemento inserido com sucesso!");
            return;
        }

        private bool Vazia() {
            if (Topo == null)
                return true;
            return false;
        }

        public void Imprimir() {
            if (Vazia()) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Impossível Imprimir! Pilha Vazia!");
                Console.ResetColor();
            }
            else {
                Livro aux = Topo;
                Console.WriteLine("Os elementos na pilha são:");
                do {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine(">>>FIM<<");
            }
        }

        public void Pop() {
            if (Vazia()) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Impossível Remover! Pilha Vazia!");
                Console.ResetColor();
            }
            else {
                Topo = Topo.Anterior;
                Console.WriteLine("Elemento Removido!");
            }
        }

        public void QtdElementos() {
            int cont = 0;
            if (Vazia()) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pilha Vazia!");
                Console.ResetColor();
            }
            else {
                Livro aux = Topo;
                do {
                    cont++;
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine("Quantidade de elementos na pilha: " + cont);
            }
        }

        public void BuscarLivro() {
            string titulo;
            bool disponivel = false;

            if (Vazia()) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pilha Vazia!");
                Console.ResetColor();
            }
            else {
                Livro aux = Topo;
                Console.Write("Digite o título que deseja buscar: ");
                titulo = Console.ReadLine();
                do {
                    if (aux.Titulo == titulo) {
                        Console.WriteLine("O livro está disponivel na biblioteca!!");
                        disponivel = true;
                    }
                    aux = aux.Anterior;
                } while (aux != null);
                if (disponivel == false) Console.WriteLine("Não temos esse livro");
            }
        }
    }
}
