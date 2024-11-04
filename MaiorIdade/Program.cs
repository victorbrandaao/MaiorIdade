/// Este programa lê os nomes e idades de 3 alunos e exibe o nome do aluno mais velho.
class Program
{
    static void Main(string[] args)
    {
        // Nomes dos alunos
        String aluno1 = "João";
        String aluno2 = "Maria";
        String aluno3 = "José";

        // Idades dos alunos
        int idade1 = 20;
        int idade2 = 21;
        int idade3 = 22;

        // Inicializa a maior idade e o nome do aluno mais velho
        int maiorIdade = idade1;
        String alunoMaisVelho = aluno1;

        // Verifica se o segundo aluno é mais velho
        if (idade2 > maiorIdade) {
            maiorIdade = idade2;
            alunoMaisVelho = aluno2;
        }

        // Verifica se o terceiro aluno é mais velho
        if (idade3 > maiorIdade) {
            maiorIdade = idade3;
            alunoMaisVelho = aluno3;
        }

        // Exibe o nome e a idade do aluno mais velho
        Console.WriteLine($"O aluno mais velho é {alunoMaisVelho} com {maiorIdade} anos.");
    }
}