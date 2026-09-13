using System.Globalization;

float LerNota(string mensagem)
{
    Console.Write(mensagem);
    string entrada = Console.ReadLine();
    entrada = entrada.Replace(",", "."); // normaliza vírgula para ponto
    return float.Parse(entrada, CultureInfo.InvariantCulture);
}

float nota1 = LerNota("Digite a 1ª. Nota: ");
float nota2 = LerNota("Digite a 2ª. Nota: ");
float nota3 = LerNota("Digite a 3ª. Nota: ");

float media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("Média: " + media.ToString("F2", CultureInfo.InvariantCulture));

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}

