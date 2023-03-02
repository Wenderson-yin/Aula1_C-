// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Escreva um numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva o segundo numero");
int num2 = int.Parse(Console.ReadLine());

//Parse converte String em numero inteiro
//Console.Readline é uma String.

    int soma = num1 + num2;

Console.WriteLine("A soma dos numeros eh: ");
Console.WriteLine(soma);

if(soma == 10)
{
    Console.WriteLine("A soma dos numero eh 10");
}else if(soma == 20)
{
    Console.WriteLine("A soma dos numeros eh 20");
}
else
{
    Console.WriteLine("A soma dos numeros não eh 10 nem 20");
}
//condições if, else if, else
for(int i = 0; i <=10; i++)
{
    Console.WriteLine(i);
}
*/
//1 R:
/*
int soma = 0; 
for(int i = 0; i <= 100; i++)
{
    soma += i;
}
Console.WriteLine("A soma é: " +soma);
*/
//2 r:
/*
int soma = 0;
for(int i =0; i <= 100; i+=2)
{
    soma += i;
}
Console.WriteLine("A soma dos impares: " + soma);
*/
//3 R:
Console.WriteLine("Escreve um numero");
int numero = int.Parse(Console.ReadLine());
for(int contador  = 0; contador >= 10; ++contador);
{
    int contador = 0;
    int formula = contador * contador;
    Console.WriteLine(contador + " X " + contador + " = " + formula);
}

