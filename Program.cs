// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.
 
// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.


using Alunos;

Alunos1 A1 = new Alunos1();

Console.WriteLine($"Digite seu nome:");
A1.nome = Console.ReadLine();

Console.WriteLine($"Digite o curso que está fazendo:");
A1.curso = Console.ReadLine();

Console.WriteLine($"Digite sua idade:");
A1.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o seu RG:");
A1.RG = Console.ReadLine();

Console.WriteLine(@$"
            -É bolsista?-
");
string resposta = Console.ReadLine().ToLower();

if(resposta == "sim" || resposta == "s")
{
    A1.bolsista = true;
}
else if( resposta == "não"|| resposta == "n"|| resposta == "nao")
{
    A1.bolsista = false;
}
else
{
    Console.WriteLine($"Resposta inválida");
}

Console.WriteLine($"Digite sua média FInal");
A1.mediaFinal = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a sua Mensalidade:");
A1.valorMensalidade = float.Parse(Console.ReadLine());


if(A1.bolsista == true && A1.mediaFinal >= 8)
{
    float porcentagem = 50;

    Console.WriteLine($"Com a média maior ou igual a 8 e sendo bolsista, você ganha 50% de desconto ");

    Console.WriteLine($"Então com`{A1.VerMediaFinal()} você tem {A1.VerMensalidade(porcentagem, A1.valorMensalidade, A1.valorMensalidade )} de mensalidade");
}

else if(A1.bolsista == true && A1.mediaFinal > 6 && A1.mediaFinal < 8)
{
    float porcentagem = 30;

    Console.WriteLine($"Com a média maior que 6 e menor que 8 , sendo bolsista, você ganha 30% de desconto ");

    Console.WriteLine($"Então com`{A1.VerMediaFinal()} você tem {A1.VerMensalidade(porcentagem, A1.valorMensalidade, A1.valorMensalidade )} de mensalidade");
}

else
{
    Console.WriteLine($"Se a média foi menor que 6, então pagara a mensalidade de forma integral: {A1.valorMensalidade}");
    
}

string opcao;
do
{
    Console.WriteLine($"---Menu---");
Console.WriteLine(@$"
[1] - Média do Aluno
[2] - Valor de Mensalidade
[0] - Sair
");

opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
    Console.WriteLine($"A média do aluno {A1.nome} é : {A1.VerMediaFinal()}");
        break;
    case "2":
    Console.WriteLine($"O valor da mensalidade é {A1.VerMensalidade}");
        break;
    case "0":
        Console.WriteLine($"Tchau!");
        
        break;
    default:
        Console.WriteLine($"Opção inválida!");
        
        break;
}
} while (opcao != "0");









