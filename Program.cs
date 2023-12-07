//using System;
using System.Collections.Generic;
using System.Linq;

class Carro
{
    public string Marca { get; set; }
    public double Valor { get; set; }
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}

class Program
{
    static void Main()
    {
        List<Carro> listaCarros = new List<Carro>();

        Console.WriteLine("Informe os carros (para encerrar, digite 'sair' no campo da marca):");
        while (true)
        {
            Carro novoCarro = LerCarro();
            if (novoCarro.Marca.ToLower() == "sair")
                break;

            listaCarros.Add(novoCarro);
        }

        listaCarros = listaCarros.OrderByDescending(c => c.Valor).ToList();

        Console.WriteLine("\nCarros ordenados pelo valor (do maior para o menor):");
        foreach (var carro in listaCarros)
        {
            Console.WriteLine($"Marca: {carro.Marca}, Valor: {carro.Valor:C}, Cor: {carro.Cor}, Modelo: {carro.Modelo}, Ano: {carro.Ano}");
        }
    }

    static Carro LerCarro()
    {
        Carro carro = new Carro();

        Console.Write("Marca: ");
        carro.Marca = Console.ReadLine();

        if (carro.Marca.ToLower() == "sair")
            return carro;

        Console.Write("Valor: ");
        double.TryParse(Console.ReadLine(), out carro.Valor);

        Console.Write("Cor: ");
        carro.Cor = Console.ReadLine();

        Console.Write("Modelo: ");
        carro.Modelo = Console.ReadLine();

        Console.Write("Ano: ");
        int.TryParse(Console.ReadLine(), out carro.Ano);

        return carro;
    }
}//


//using System;

class Program
{
    static int[] vetor;

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares");
            Console.WriteLine("7 - Sair");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        CarregarVetor();
                        break;
                    case 2:
                        ListarVetor();
                        break;
                    case 3:
                        ExibirPares();
                        break;
                    case 4:
                        ExibirImpares();
                        break;
                    case 5:
                        QuantidadeParesPosicoesImpares();
                        break;
                    case 6:
                        QuantidadeImparesPosicoesPares();
                        break;
                    case 7:
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            Console.WriteLine();
        } while (opcao != 7);
    }

    static void CarregarVetor()
    {
        Console.WriteLine("Informe o tamanho do vetor:");
        int tamanho = int.Parse(Console.ReadLine());
        vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"Informe o valor para a posição {i}:");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vetor carregado com sucesso!");
    }

    static void ListarVetor()
    {
        Console.WriteLine("Vetor:");

        if (vetor != null)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Vetor não carregado.");
        }
    }

    static void ExibirPares()
    {
        Console.WriteLine("Números pares do vetor:");

        if (vetor != null)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i] + " ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Vetor não carregado.");
        }
    }

    static void ExibirImpares()
    {
        Console.WriteLine("Números ímpares do vetor:");

        if (vetor != null)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.Write(vetor[i] + " ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Vetor não carregado.");
        }
    }

    static void QuantidadeParesPosicoesImpares()
    {
        int count = 0;

        if (vetor != null && vetor.Length > 1)
        {
            for (int i = 1; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Quantidade de números pares nas posições ímpares: {count}");
        }
        else
        {
            Console.WriteLine("Vetor não carregado ou não possui posições ímpares suficientes.");
        }
    }

    static void QuantidadeImparesPosicoesPares()
    {
        int count = 0;

        if (vetor != null && vetor.Length > 1)
        {
            for (int i = 0; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Quantidade de números ímpares nas posições pares: {count}");
        }
        else
        {
            Console.WriteLine("Vetor não carregado ou não possui posições pares suficientes.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int soma = 0;
        int maior = int.MinValue;
        int menor = int.MaxValue;

        do
        {
            Console.Write("Digite um valor inteiro: ");
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                if (valor > maior)
                {
                    maior = valor;
                }

                if (valor < menor)
                {
                    menor = valor;
                }

                soma += valor;

                contador++;
            }
            else
            {
                Console.WriteLine("Por favor, digite um valor inteiro válido.");
            }
        } while (contador < 20);

        double media = (double)soma / contador;

        Console.WriteLine($"Maior valor: {maior}");
        Console.WriteLine($"Menor valor: {menor}");
        Console.WriteLine($"Média dos valores: {media}");

        Console.ReadLine();
    }
}//

//using System;

class Program
{
    static void Main()
    {
        double totalComprasAVista = 0;
        double totalComprasAPrazo = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write($"Digite o código da {i}ª transação (V para à vista, P para a prazo): ");
            string codigo = Console.ReadLine();

            Console.Write("Digite o valor da transação: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (codigo.ToUpper() == "V")
            {
                totalComprasAVista += valor;
            }
            else if (codigo.ToUpper() == "P")
            {
                totalComprasAPrazo += valor;
            }
            else
            {
                Console.WriteLine("Código inválido. Tente novamente.");
                i--; 
            }
        }

        double valorTotalCompras = totalComprasAVista + totalComprasAPrazo;

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Valor total das compras à vista: {totalComprasAVista:C}");
        Console.WriteLine($"Valor total das compras a prazo: {totalComprasAPrazo:C}");
        Console.WriteLine($"Valor total das compras efetuadas: {valorTotalCompras:C}");

        Console.ReadLine();
    }
}//

//using System;

class Carro
{
    // Propriedades
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int Ano { get; set; }
    public double Preco { get; set; }

    // Construtor
    public Carro(string modelo, string cor, int ano, double preco)
    {
        Modelo = modelo;
        Cor = cor;
        Ano = ano;
        Preco = preco;
    }

    // Método para imprimir os atributos do carro
    public void ImprimirDetalhes()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Preço: {Preco:C}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Carro carro1 = new Carro("Toyota Corolla", "Prata", 2022, 50000.0);
        Carro carro2 = new Carro("Honda Civic", "Preto", 2021, 48000.0);
        Carro carro3 = new Carro("Ford Focus", "Azul", 2023, 55000.0);

        Console.WriteLine("Detalhes do Carro 1:");
        carro1.ImprimirDetalhes();

        Console.WriteLine("Detalhes do Carro 2:");
        carro2.ImprimirDetalhes();

        Console.WriteLine("Detalhes do Carro 3:");
        carro3.ImprimirDetalhes();
    }//

    //using System;

    public class Carro
    {
        public string Acelerar()
        {
            return "O carro está em movimento";
        }

        public string Freiar()
        {
            return "O carro está parado";
        }
    }

    class Program
    {
        static void Main()
        {
            Carro meuCarro = new Carro();

            string mensagemAcelerar = meuCarro.Acelerar();
            Console.WriteLine(mensagemAcelerar);

            string mensagemFreiar = meuCarro.Freiar();
            Console.WriteLine(mensagemFreiar);
        }
    }//

    //using System;

    class Program
    {
        static void Main()
        {
            int totalPessoas = 200;

            double somaSalarios = 0;
            int somaFilhos = 0;
            double maiorSalario = double.MinValue;
            double menorSalario = double.MaxValue;
            int pessoasAte1500 = 0;

            for (int i = 1; i <= totalPessoas; i++)
            {
                Console.WriteLine($"Digite o salário da pessoa {i}:");
                double salario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Digite o número de filhos da pessoa {i}:");
                int numFilhos = Convert.ToInt32(Console.ReadLine());

                somaSalarios += salario;
                somaFilhos += numFilhos;

                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }
                if (salario < menorSalario)
                {
                    menorSalario = salario;
                }

                if (salario <= 1500)
                {
                    pessoasAte1500++;
                }
            }

            double mediaSalarios = somaSalarios / totalPessoas;
            double mediaFilhos = (double)somaFilhos / totalPessoas;

            double porcentagemAte1500 = (double)pessoasAte1500 / totalPessoas * 100;

            Console.WriteLine($"Média do salário: {mediaSalarios:C}");
            Console.WriteLine($"Média do número de filhos: {mediaFilhos:F2}");
            Console.WriteLine($"Maior salário: {maiorSalario:C}");
            Console.WriteLine($"Menor salário: {menorSalario:C}");
            Console.WriteLine($"Porcentagem de pessoas com salários até R$1500,00: {porcentagemAte1500:F2}%");
        }
    }//