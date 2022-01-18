using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Treino1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            Inicio:
            Console.WriteLine("Entre com os Dados do produto:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço Unitario: R$");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(p1);

            Console.WriteLine("Deseja Proseguir para pagamento? (s/n)");
            char resposta = char.Parse(Console.ReadLine());
            if(resposta == 'n' || resposta == 'N')
            {
                Console.WriteLine("Ação Cancelada pelo Usuario!");
                goto Inicio;
            }
            else if(resposta == 's' || resposta == 'S')
            {
                Console.Clear();
                Console.WriteLine(p1);
                Console.WriteLine(p1.ValorTotal().ToString("F2", CultureInfo.InvariantCulture));
                Pagamento:
                Console.WriteLine("Confirma o valor total da compra? (s/n)");
                char resposta2 = char.Parse(Console.ReadLine());
                if(resposta2 == 'n' || resposta2 == 'N')
                {
                    Console.WriteLine("Ação Cancelada pelo Usuario!");
                    goto Inicio;
                }
                else if(resposta2 == 's' || resposta2 == 'S')
                {
                    Console.Clear();
                    Console.WriteLine("Compra Efetuada com sucesso!");
                    Console.WriteLine(p1);
                    Console.WriteLine(p1.ValorTotal());
                }
                else
                {
                    Console.WriteLine("Digite uma opção valida!");
                    goto Pagamento;
                }
            }

            Console.ReadLine();
        }
    }
}
