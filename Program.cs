using System.Security.Cryptography.X509Certificates;

double massa, altura, imc;

Console.WriteLine("-- Calculadora de IMC --");

Console.Write("Digite seu peso em kg...: ");
massa = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura em m..: ");
altura = Convert.ToDouble(Console.ReadLine());

imc = Convert.ToDouble (massa / (altura * altura));

Console.WriteLine($"Seu IMC é {imc}");

if(imc < 17)
{
    Console.WriteLine("Muito abaixo do peso");
}
if(imc == 17 && imc <= 18.49)
{
    Console.WriteLine("Abaixo do peso");
}
if(imc == 18.5 && imc <= 24.99)
{
    Console.WriteLine("Peso normal");
}
if(imc == 25 && imc <= 29.99)
{
    Console.WriteLine("Acima do peso");
}
if(imc == 30 && imc <= 34.99)
{
    Console.WriteLine("Obesidade I");
}
