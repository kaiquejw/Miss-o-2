double a = 0.1;
double b = 0.2;
double c = 0.3;

double soma = a + b;

Console.WriteLine("a + b = " + soma);
Console.WriteLine("c     = " + c);

Console.WriteLine(soma == c
    ? "a + b é igual a c"
    : "a + b NÃO é igual a c");

Console.WriteLine($"a + b com precisão: {soma:R}");
Console.WriteLine($"c com precisão:     {c:R}");
