// Crie um programa que leia o nome e a idade de 3 alunos e mostre o nome do aluno mais velho.

String aluno1 = "João";
String aluno2 = "Maria";
String aluno3 = "José";
int idade1 = 20;
int idade2 = 21;
int idade3 = 22;

int maiorIdade = idade1;
String alunoMaisVelho = aluno1;

if (idade2 > maiorIdade) {
    maiorIdade = idade2;
    alunoMaisVelho = aluno2;
}

if (idade3 > maiorIdade) {
    maiorIdade = idade3;
    alunoMaisVelho = aluno3;
}

Console.WriteLine($"O aluno mais velho é {alunoMaisVelho} com {maiorIdade} anos.");