// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingese un numero");

string numeroIngresado = Console.ReadLine();
int numero;

bool esNumero = int.TryParse(numeroIngresado, out numero);

if (esNumero)
{
    if (numero > 0)
    {
        int invertido = 0;
        while (numero > 0)
        {
            int digito = numero % 10;
            invertido = invertido * 10 + digito;
            numero = numero / 10;
        }
        Console.WriteLine("Número invertido: " + invertido);
    }
    else
    {
        Console.WriteLine("El número debe ser mayor que 0.");
    }
}
else
{
    Console.WriteLine("Eso no es un número válido.");
}