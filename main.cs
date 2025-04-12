using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SistemaBancario
{
    static void Main()
    {
        decimal saldo = 0;
        decimal limite = 500;
        string extrato = "";
        int numeroSaques = 0;
        const int LIMITE_SAQUES = 3;
        string opcao;

        while (true)
        {
            LimparTerminal();

            // Menu principal
            Console.WriteLine("=============== MENU ===============");
            Console.WriteLine("[d] Depositar");
            Console.WriteLine("[s] Sacar");
            Console.WriteLine("[e] Extrato");
            Console.WriteLine("[q] Sair");
            Console.WriteLine("====================================");
            Console.Write("=> ");
            opcao = Console.ReadLine().ToLower().Trim();

            if (opcao == "d") // Depósito
            {
                LimparTerminal();
                Console.WriteLine("=== DEPÓSITO ===");
                Console.Write("Informe o valor do depósito: R$ ");

                if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor > 0)
                {
                    saldo += valor;
                    extrato += $"Depósito: R$ {valor:F2}\n";
                    Console.WriteLine("Depósito realizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Operação falhou! Valor inválido.");
                }
                Pause();
            }
            else if (opcao == "s") // Saque
            {
                LimparTerminal();
                Console.WriteLine("=== SAQUE ===");
                Console.Write("Informe o valor do saque: R$ ");

                if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor > 0)
                {
                    bool excedeuSaldo = valor > saldo;
                    bool excedeuLimite = valor > limite;
                    bool excedeuSaques = numeroSaques >= LIMITE_SAQUES;

                    if (excedeuSaldo)
                        Console.WriteLine("Saldo insuficiente.");
                    else if (excedeuLimite)
                        Console.WriteLine("O valor do saque excede o limite.");
                    else if (excedeuSaques)
                        Console.WriteLine("Número máximo de saques atingido.");
                    else
                    {
                        saldo -= valor;
                        extrato += $"Saque: R$ {valor:F2}\n";
                        numeroSaques++;
                        Console.WriteLine("Saque realizado com sucesso.");
                    }
                }
                else
                {
                    Console.WriteLine("Operação falhou! Valor inválido.");
                }
                Pause();
            }
            else if (opcao == "e") // Extrato
            {
                LimparTerminal();
                Console.WriteLine("=========== EXTRATO ===========");
                Console.WriteLine(!string.IsNullOrWhiteSpace(extrato) ? extrato : "Nenhuma movimentação registrada.");
                Console.WriteLine($"Saldo disponível: R$ {saldo:F2}");
                Console.WriteLine("================================");
                Pause();
            }
            else if (opcao == "q") // Sair
            {
                LimparTerminal();
                Console.WriteLine("Obrigado por usar nosso sistema bancário!");
                break;
            }
            else // Opção inválida
            {
                LimparTerminal();
                Console.WriteLine("Opção inválida. Tente novamente.");
                Pause();
            }
        }
    }

    static void LimparTerminal()
    {
        Console.Clear();
    }

    static void Pause()
    {
        Console.WriteLine("\nPressione [Enter] para continuar...");
        Console.ReadLine();
    }
}