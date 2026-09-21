namespace AlunoConsole.Controllers;

public class MenuController
{
    public bool CloseProgram { get; set; } = false;

    public void ShowMenu()
    {
        Console.WriteLine("Controle de Escola 2.0");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Ver Alunos; 2 - Ver Professores; 3 - Ver Turmas; 4 - Sair");
        var option = Console.ReadLine();

        if (option != null)
        {
            switch (option)
            {
                case "1":
                    GetAluno();
                    break;
                case "2":
                    GetProfessor();
                    break;
                case "3":
                    GetTurma();
                    break;
                case "4":
                    CloseMenu();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }

    public void GetAluno(string? id = "null")
    {
        if (id == null)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
        }
        else
        {
            Console.WriteLine("Buscando...");
            // adicionar metodo de busca
            Console.WriteLine("(!) Não encontrado");
        }
        ShowMenu();
    }

    public void GetProfessor(string? id = "null")
    {
        if (id == null)
        {
            Console.WriteLine("Nenhum professor cadastrado.");
        }
        else
        {
            Console.WriteLine("Buscando...");
            // adicionar metodo de busca
            Console.WriteLine("(!) Não encontrado");
        }
        ShowMenu();
    }

    public void GetTurma(string? id = "null")
    {
        if (id == null)
        {
            Console.WriteLine("Nenhuma turma cadastrada.");
        }
        else
        {
            Console.WriteLine("Buscando...");
            // adicionar metodo de busca
            Console.WriteLine("(!) Não encontrado");
        }
        ShowMenu();
    }

    public void CloseMenu()
    {
        Console.WriteLine("Saindo...");
        CloseProgram = true;
    }
}
