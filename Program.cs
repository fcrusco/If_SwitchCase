using System;

namespace If_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção (1-3):");
            Console.WriteLine("1. Mostrar mensagem de boas-vindas");
            Console.WriteLine("2. Exibir a data e hora atual");
            Console.WriteLine("3. Dizer o dia da semana em extenso");
            Console.Write("Digite a opção: ");

            string opcao = Console.ReadLine() ?? "1";

            // Demonstração com IF
            Console.WriteLine("\n== Estrutura IF ==");
            if (opcao == "1")
            {
                Console.WriteLine("Bem-vindo ao exemplo de IF!");
            }
            else if (opcao == "2")
            {
                Console.WriteLine($"Data e hora atual: {DateTime.Now}");
            }
            else if (opcao == "3")
            {
                Console.WriteLine($"Hoje é: {DateTime.Now.DayOfWeek}");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            // Demonstração com SWITCH CASE
            Console.WriteLine("\n== Estrutura SWITCH CASE ==");
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Bem-vindo ao exemplo de Switch!");
                    break;
                case "2":
                    Console.WriteLine($"Data e hora atual: {DateTime.Now}");
                    break;
                case "3":
                    // Exemplo usando switch aninhado para mostrar o nome do dia em português
                    string nomeDia = DateTime.Now.DayOfWeek switch
                    {
                        DayOfWeek.Sunday => "Domingo",
                        DayOfWeek.Monday => "Segunda-feira",
                        DayOfWeek.Tuesday => "Terça-feira",
                        DayOfWeek.Wednesday => "Quarta-feira",
                        DayOfWeek.Thursday => "Quinta-feira",
                        DayOfWeek.Friday => "Sexta-feira",
                        DayOfWeek.Saturday => "Sábado",
                        _ => "Desconhecido"
                    };
                    Console.WriteLine($"Hoje é: {nomeDia}");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
