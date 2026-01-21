
# ClearPay

ClearPay é um sistema de liquidação financeira projetado para receber transações de múltiplos parceiros, calcular recebíveis e gerenciar o ciclo completo de liquidação.  
O projeto foi concebido com foco em arquitetura, domínio de negócio e evolução incremental, começando pelo módulo de cadastro de merchants como base estrutural do sistema.

O cadastro de merchants não é o objetivo final do ClearPay, mas sim um passo necessário para garantir consistência, rastreabilidade e governança antes da ingestão e liquidação de transações.

## Fluxo macro esperado do sistema

De forma simplificada, o fluxo principal do ClearPay será:

1. Parceiros realizam o cadastro e manutenção de merchants
2. Parceiros injetam transações financeiras no sistema
3. O ClearPay processa as transações
4. O sistema calcula os recebíveis com base em regras de negócio
5. Os valores são organizados para liquidação e repasse

Neste momento, o foco do desenvolvimento está no primeiro estágio: cadastro, atualização e cancelamento de merchants.

## Arquitetura

O ClearPay segue uma arquitetura em camadas inspirada em princípios de Clean Architecture e Domain-Driven Design (DDD), priorizando:

- Separação clara de responsabilidades
- Independência de frameworks
- Facilidade de evolução e manutenção
- Código agnóstico à infraestrutura sempre que possível

### Estrutura de Pastas

```
ClearPay
├─ Api
│  └─ Controllers
│
├─ Application
│  ├─ UseCases
│  └─ DTOs
│
├─ Domain
│  ├─ Merchants
│  ├─ Transactions
│  └─ Settlement
│
├─ Infrastructure
│  ├─ Database
│  ├─ Repositories
│  └─ Messaging
│
├─ Program.cs
└─ ClearPay.csproj
```


## Tecnologias Utilizadas

- .NET (C#)
- ASP.NET Core
- Banco de dados relacional (definição independente de fornecedor)
- Git para controle de versão

O projeto evita dependência direta de tecnologias específicas sempre que possível, priorizando abstrações.

## Metodologia e Princípios

- Design orientado ao domínio
- Separação de responsabilidades
- Evolução incremental
- Documentação como parte do desenvolvimento
- Foco em legibilidade e clareza antes de otimizações prematuras

## Como Executar o Projeto

Pré-requisitos:
- .NET SDK instalado

Passos:

1. Clonar o repositório
2. Acessar a pasta do projeto
3. Executar:

```
dotnet restore
dotnet run
```

O projeto está em desenvolvimento ativo e novas funcionalidades serão adicionadas de forma incremental.
