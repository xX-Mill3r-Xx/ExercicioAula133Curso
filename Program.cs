using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioAula133Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            Console.Write("Entre com o numero de Produtos: ");
            int n = int.Parse(Console.ReadLine());

            for(int i =1; i < n; i++)
            {
                Console.WriteLine($"Produto # {i} data:");
                Console.Write("Comun, usado ou importado (c/u/i)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(tipo == 'c' || tipo == 'C')
                {
                    lista.Add(new Produto(nome, preco));
                }
                else if(tipo == 'u' || tipo == 'U')
                {
                    Console.Write($"Data de Fabricação: (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, data));
                }
                else
                {
                    Console.Write("Customs free: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(nome, preco, customs));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Tag/Preço:");
            foreach(Produto p in lista)
            {
                Console.WriteLine(p.PrecoTag());
            }

            Console.ReadLine();
        }
    }
}
