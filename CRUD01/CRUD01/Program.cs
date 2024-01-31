List<string> listAlunos = new List<string>();
string opcao = "5";
string aluno = string.Empty;

do
{
    Console.WriteLine("---Cadastro Escolar---");
    Console.WriteLine("----------------------");

    Console.WriteLine("[1] Cadastrar aluno");
    Console.WriteLine("[2] Consultar alunos cadastrados");
    Console.WriteLine("[3] Atualizar cadastro de aluno");
    Console.WriteLine("[4] Deletar aluno");
    Console.WriteLine("[0] Para sair");

    opcao = Console.ReadLine();

    Console.WriteLine();

    if (opcao == "1")
    {
        Console.WriteLine("Digite o nome do aluno");
        aluno = Console.ReadLine();
        listAlunos.Add(aluno);
    }
    if (opcao == "2")
    {
        Console.WriteLine("Alunos cadastrados");
        for (int i = 0; i < listAlunos.Count; i++)
        {
            Console.WriteLine(listAlunos[i]);
        }
        Console.ReadLine();
    }
    if (opcao == "3")
    {
        Console.WriteLine("Alunos cadastrados");
        for (int i = 0; i < listAlunos.Count; i++)
        {
            Console.WriteLine($"{i+1} - {listAlunos[i]}");
        }
        
        Console.WriteLine("Digite o número do aluno que será editado");
        int numAluno = int.Parse(Console.ReadLine());

        Console.WriteLine($"Aluno {listAlunos[numAluno-1]} será editado");

        Console.WriteLine($"Digite o novo nome do aluno {listAlunos[numAluno-1]}");

        aluno = Console.ReadLine();
        listAlunos[numAluno-1] = aluno;
    }
    if (opcao == "4")
    {
        Console.WriteLine("Digite o nome do aluno que vai ser removido da lista de alunos");
        string alunoRemovido = Console.ReadLine();
        listAlunos.Remove(alunoRemovido);
    }

    Console.Clear();

}while (opcao != "0");



