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
