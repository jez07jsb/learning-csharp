using AlunoConsole.Controllers;

namespace AlunoConsole;

public class Program
{
    private readonly string FileTestPath = @"C:\Users\jez07\Downloads";

    private static MenuController menuController = new();

    static void Main(string[] args)
    {
        menuController.ShowMenu();

        if (menuController.CloseProgram) return;
        else Console.WriteLine("(/) Not allowed command");
    }
}
