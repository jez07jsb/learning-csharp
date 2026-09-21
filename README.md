# learning-csharp
Repository to learn how to write C# code

## AlunoConsole

Projeto acadêmico em C# para demonstrar fundamentos de arquitetura de software, modelagem de domínio e uso de design patterns por meio do gerenciamento de turmas de uma escola hipotética.

> O projeto está em desenvolvimento. A documentação distingue o domínio planejado da implementação atualmente disponível.

## Objetivo

Construir uma aplicação de console capaz de representar e gerenciar:

- matérias;
- professores;
- alunos;
- turmas.

O projeto tem finalidade educacional e serve como base para praticar organização de código, separação de responsabilidades, modelagem orientada a objetos e evolução incremental de uma solução .NET.

## Domínio

As principais relações do domínio são:

- uma `Turma` está associada a uma `Matéria`;
- uma `Turma` possui exatamente um `Professor` responsável;
- uma `Turma` pode possuir vários `Alunos`;
- um `Aluno` pode participar de uma ou mais turmas, conforme as regras que forem implementadas;
- um `Professor` pode lecionar uma ou mais turmas, conforme as regras que forem implementadas.

### Modelo conceitual

erDiagram
    MATERIA ||--o{ TURMA : possui
    PROFESSOR ||--o{ TURMA : ministra
    TURMA ||--o{ ALUNO : matricula

## Arquitetura e design patterns

A solução está organizada inicialmente em camadas simples:

- `Models`: entidades e conceitos do domínio;
- `Controllers`: coordenação das interações da aplicação de console;
- `Program.cs`: ponto de entrada da aplicação.

A estrutura foi preparada para evoluir com padrões de projeto adequados às necessidades do domínio, por exemplo:

- **MVC simplificado** para separar interação, coordenação e modelo;
- **Repository** para abstrair persistência e consulta de alunos, professores, matérias e turmas;
- **Service Layer** para concentrar casos de uso e regras de negócio;
- **Factory** para centralizar a criação de entidades quando houver regras de criação;
- **Strategy** para permitir diferentes critérios de consulta, matrícula ou organização de turmas.

Os padrões serão adicionados somente quando resolverem uma necessidade real, evitando complexidade desnecessária.

## Estrutura atual

learning-csharp/
??? AlunoConsole/
?   ??? Controllers/
?   ?   ??? MenuController.cs
?   ?   ??? TurmaController.cs
?   ??? Models/
?   ?   ??? Aluno.cs
?   ?   ??? Professor.cs
?   ?   ??? Turma.cs
?   ??? AlunoConsole.csproj
?   ??? Program.cs
??? README.md

A entidade `Materia` ainda deve ser criada para completar o modelo de domínio. As classes de `Aluno`, `Professor`, `Turma` e `TurmaController` estão presentes como pontos iniciais de implementação. O `MenuController` já disponibiliza opções de console para consultar alunos, professores e turmas, embora as operações de busca ainda estejam em desenvolvimento.

## Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0);
- Visual Studio 2022 com suporte ao desenvolvimento para .NET, ou outra IDE compatível;
- Windows, pois o projeto utiliza atualmente o TFM `net8.0-windows10.0.26100.0`.

## Como executar

Na raiz do repositório, execute:

```dotnet run --project AlunoConsole/AlunoConsole.csproj```

Também é possível abrir a solução no Visual Studio 2022 e executar o projeto `AlunoConsole` com __F5__ ou __Iniciar sem Depuração__.

## Fluxo atual da aplicação

Ao iniciar, a aplicação exibe um menu com as opções:

1. consultar alunos;
2. consultar professores;
3. consultar turmas;
4. sair.

As consultas e o armazenamento dos dados ainda são partes planejadas da implementação.

## Próximas evoluções

- criar a entidade `Materia`;
- definir identificadores e propriedades das entidades;
- implementar as regras de associação entre turma, matéria, professor e alunos;
- adicionar casos de uso para cadastro, consulta e matrícula;
- introduzir interfaces para serviços e repositórios;
- adicionar persistência, inicialmente em memória;
- criar testes unitários para as regras de negócio;
- documentar os padrões efetivamente aplicados no código.

## Status

Projeto acadêmico em fase inicial de modelagem e construção da interface de console.
