// See https://aka.ms/new-console-template for more information
bool seguir = true;

while (seguir)
{
    Console.WriteLine("Seleccione una opción (1-4):");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");

    string opcion = Console.ReadLine();
    int num1, num2;

    Console.Write("Ingrese el primer número: ");
    bool numero1 = int.TryParse(Console.ReadLine(), out num1);
    Console.Write("Ingrese el segundo número: ");
    bool numero2 = int.TryParse(Console.ReadLine(), out num2);
    if (!numero1 || !numero2)
    {
        Console.WriteLine("Uno de los valores ingresados no es un número válido.");
    }
    else
    {
        switch (opcion)
        {
            case "1":
                Console.WriteLine("Resultado: " + (num1 + num2));
                break;
            case "2":
                Console.WriteLine("Resultado: " + (num1 - num2));
                break;
            case "3":
                Console.WriteLine("Resultado: " + (num1 * num2));
                break;
            case "4":
                if (num2 != 0)
                {
                    Console.WriteLine("Resultado: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
    Console.Write("¿Desea realizar otro cálculo? (s/n): ");
    string respuesta = Console.ReadLine().ToLower();
    if (respuesta != "s")
    {
        seguir = false;
    }
}

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
    double numUno, numDos;

    bool ok1 = double.TryParse(primero, out numUno);
    bool ok2 = double.TryParse(segundo, out numDos);

    if (ok1 && ok2)
    {
        Console.WriteLine("Máximo: " + Math.Max(numUno, numDos));
        Console.WriteLine("Mínimo: " + Math.Min(numUno, numDos));
    }
    else
    {
        Console.WriteLine("Uno de los valores ingresados no es valido.");
    }
