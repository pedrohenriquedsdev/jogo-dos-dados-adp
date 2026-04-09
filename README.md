# 🎲 Jogo dos Dados

> Jogo de corrida com dados em C#, com foco em eventos aleatórios, lógica por turnos e refatoração de métodos.

---

## 📋 Sobre o Projeto

O **Jogo dos Dados** é uma aplicação console desenvolvida em C# que simula uma corrida entre jogadores utilizando dados. A cada turno, os participantes lançam os dados e avançam de acordo com o resultado obtido. O projeto explora conceitos de geração de eventos aleatórios, controle de fluxo por turnos e boas práticas de organização e refatoração de código.

---

## ✨ Funcionalidades

- Corrida entre múltiplos jogadores baseada no lançamento de dados
- Geração de resultados aleatórios a cada turno
- Lógica de turnos alternados entre os participantes
- Exibição do progresso de cada jogador durante a corrida
- Detecção automática do vencedor ao final da partida
- Código estruturado com foco em refatoração e legibilidade

---

## 🗂️ Estrutura do Projeto

```
jogo-dos-dados-adp/
├── JogoDosDados.ConsoleApp/   # Projeto principal (console)
├── .vscode/                   # Configurações do VS Code
├── JogoDosDados.slnx          # Arquivo de solução .NET
└── .gitignore
```

---

## 🚀 Como Executar

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) 8.0 ou superior

### Passos

1. Clone o repositório:
   ```bash
   git clone https://github.com/pedrohenriquedsdev/jogo-dos-dados-adp.git
   cd jogo-dos-dados-adp
   ```

2. Restaure as dependências:
   ```bash
   dotnet restore
   ```

3. Execute o projeto:
   ```bash
   dotnet run --project JogoDosDados.ConsoleApp
   ```

---

## 🎮 Como Funciona

O jogo segue a lógica de uma corrida por turnos:

1. Cada jogador lança um dado por turno
2. O resultado do dado determina quantas posições o jogador avança na corrida
3. Os turnos se alternam até que um jogador alcance ou ultrapasse a linha de chegada
4. O primeiro a atingir a meta é declarado vencedor

**Exemplo de rodada:**

```
--- Turno 1 ---
🎲 Jogador 1 tirou 4  → Posição: 4
🎲 Jogador 2 tirou 6  → Posição: 6

--- Turno 2 ---
🎲 Jogador 1 tirou 5  → Posição: 9
🎲 Jogador 2 tirou 3  → Posição: 9

...

🏆 Jogador 1 venceu a corrida!
```

---

## 🛠️ Tecnologias Utilizadas

- **C#** — linguagem principal
- **.NET** — plataforma de execução
- **Console App** — interface de entrada e saída
- **`Random`** — geração de eventos aleatórios

---

## 💡 Conceitos Abordados

- Geração de números aleatórios com `Random`
- Estruturas de repetição e controle de fluxo (`while`, `for`, `if`)
- Refatoração de métodos para melhor legibilidade
- Separação de responsabilidades entre classes e métodos
- Programação orientada a objetos em C#

---

## 👤 Autor

**Pedro Henrique**

[![GitHub](https://img.shields.io/badge/GitHub-pedrohenriquedsdev-181717?style=flat&logo=github)](https://github.com/pedrohenriquedsdev)
