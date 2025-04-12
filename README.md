# 💳 Sistema Bancário em C# - Console

Este é um sistema bancário simples feito em **C#**, com funcionamento 100% via console, ideal para praticar lógica de programação e controle de fluxo. Inspirado em um projeto Python com foco em clareza, usabilidade e organização.

---

## 📋 Funcionalidades

- **Depósito**  
  Permite adicionar valores positivos ao saldo.

- **Saque**  
  Limite de R$ 500 por operação.  
  Máximo de 3 saques por sessão.  
  Verifica saldo e restrições antes da operação.

- **Extrato**  
  Mostra todas as movimentações (depósitos e saques) e o saldo atual.

- **Sair**  
  Encerra o sistema de forma limpa.

---

## 🧠 Lógica Principal

- Saldo e extrato são atualizados conforme o usuário interage.
- O terminal é limpo a cada nova exibição de menu para melhor visualização.
- Todas as entradas são validadas para evitar erros de execução.
- O código é simples e direto, ideal para fins educacionais.

---

## ▶️ Como executar

1. **Clone o repositório** ou copie o arquivo `.cs`.
2. Compile e execute com o `dotnet`:
   ```bash
   dotnet new console -o SistemaBancario
   cd SistemaBancario
   # Substitua o conteúdo de Program.cs pelo código
   dotnet run
