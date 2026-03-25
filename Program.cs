using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            
            Console.WriteLine("\n--- CALCULADORA C# ---");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: "); 
            
            
            opcao = int.Parse(Console.ReadLine());

            
            if (opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------");

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Resultado da Soma: " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Resultado da Subtração: " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Resultado da Multiplicação: " + (num1 * num2));
                        break;
                    case 4:
                        
                        if (num2 == 0)
                        {
                            Console.WriteLine("Erro: Não é possível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("Resultado da Divisão: " + (num1 / num2));
                        }
                        break;
                }
            }
            else if (opcao == 0)
            {
                Console.WriteLine("Saindo da calculadora... Até logo!");
            }
            else
            {
                Console.WriteLine("Erro: Opção inválida!");
            }

        } while (opcao != 0);
    }
}
