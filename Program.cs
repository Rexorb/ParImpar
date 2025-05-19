Console.WriteLine("Olá, entre com um número");
int num = Convert.ToInt16(Console.ReadLine());
int resto = num % 2;
if (resto == 0)
{
    Console.WriteLine("O número digitado é par");
}
else
{
    Console.WriteLine("O número digitado é ímpar");
}
