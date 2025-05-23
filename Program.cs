// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese un número (puede tener coma): ");
string numero = Console.ReadLine();
double num;

if (double.TryParse(numero, out num))
{
    Console.WriteLine("Valor absoluto: " + Math.Abs(num));
    Console.WriteLine("Cuadrado: " + Math.Pow(num, 2));
    if (num >= 0)
    {
        Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(num));
    }
    else
    {
        Console.WriteLine("Raíz cuadrada: No se puede calcular (número negativo).");
    }
    Console.WriteLine("Seno: " + Math.Sin(num));
    Console.WriteLine("Coseno: " + Math.Cos(num));
    Console.WriteLine("Parte entera: " + Math.Truncate(num));
}else
    {
        Console.WriteLine("No ingresó un número valido.");
        return;
    }

    Console.Write("Ingrese el primer número: ");
    string primero = Console.ReadLine();
    Console.Write("Ingrese el segundo número: ");
    string segundo = Console.ReadLine();
    double num1, num2;

    bool ok1 = double.TryParse(primero, out num1);
    bool ok2 = double.TryParse(segundo, out num2);

    if (ok1 && ok2)
    {
        Console.WriteLine("Máximo: " + Math.Max(num1, num2));
        Console.WriteLine("Mínimo: " + Math.Min(num1, num2));
    }
    else
    {
        Console.WriteLine("Uno de los valores ingresados no es valido.");
    }