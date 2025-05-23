// See https://aka.ms/new-console-template for more information
    Console.Write("Ingrese una cadena de texto: ");
    string cadena1 = Console.ReadLine();

    Console.WriteLine("La longitud de la cadena es: " + cadena1.Length);


    Console.Write("Ingrese otra cadena para concatenar: ");
    string cadena2 = Console.ReadLine();

    string cadenaConcatenada = cadena1 + " " + cadena2;
    Console.WriteLine("Las cadenas concatenadas son: " + cadenaConcatenada);

    Console.Write("Ingrese desde qué posición desea extraer la subcadena (empezando desde 0): ");
    string inputPos = Console.ReadLine();
    int posicion;

    if (int.TryParse(inputPos, out posicion) && posicion >= 0 && posicion < cadena1.Length)
    {
        string subcadena = cadena1.Substring(posicion);
        Console.WriteLine("La subcadena desde la posición " + posicion + " es: " + subcadena);
    }else
    {
        Console.WriteLine("Posición no válida.");
    }
    
    Console.WriteLine("\n== Calculadora Básica ==");

        Console.Write("Ingrese el primer número: ");
        string num1Str = Console.ReadLine();

        Console.Write("Ingrese el segundo número: ");
        string num2Str = Console.ReadLine();

        int num1, num2;

        if (int.TryParse(num1Str, out num1) && int.TryParse(num2Str, out num2))
        {
            int suma = num1 + num2;
            int resta = num1 - num2;
            int producto = num1 * num2;

            Console.WriteLine($"La suma de {num1} y {num2} es igual a: {suma}");
            Console.WriteLine($"La resta de {num1} y {num2} es igual a: {resta}");
            Console.WriteLine($"La multiplicación de {num1} y {num2} es igual a: {producto}");

            if (num2 != 0)
            {
                int division = num1 / num2;
                Console.WriteLine($"La división de {num1} y {num2} es igual a: {division}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
        }
        else
        {
            Console.WriteLine("Uno o ambos números ingresados no son válidos.");
        }

    Console.Write("Ingrese una cadena para recorrer: ");
    string cadena = Console.ReadLine();
    Console.WriteLine("Caracteres uno por uno:");
    foreach (char caracter in cadena)
    {
        Console.WriteLine(caracter);
    }

    Console.Write("Ingrese una palabra para buscar en la cadena: ");
    string palabraBuscada = Console.ReadLine();
    if (cadena.Contains(palabraBuscada))
    {
        Console.WriteLine("La palabra sí se encuentra en la cadena.");
        }
        else
        {
            Console.WriteLine("La palabra no se encuentra en la cadena.");
        }

    Console.WriteLine("Cadena en mayúsculas: " + cadena.ToUpper());
    Console.WriteLine("Cadena en minúsculas: " + cadena.ToLower());

    Console.Write("Ingrese una lista separada por comas (por ejemplo: uno,dos,tres): ");
    string lista = Console.ReadLine();
    string[] partes = lista.Split(',');
    Console.WriteLine("Elementos separados:");
    foreach (string parte in partes)
    {
        Console.WriteLine(parte);
    }

    Console.Write("Ingrese una operación simple (ejemplo: 582+2): ");
        string operacion = Console.ReadLine();

        char[] operadores = { '+', '-', '*', '/' };
        int indice = operacion.IndexOfAny(operadores);

        if (indice > 0)
        {
            string izquierda = operacion.Substring(0, indice);
            string derecha = operacion.Substring(indice + 1);
            char operador = operacion[indice];

            if (int.TryParse(izquierda, out int numero1) && int.TryParse(derecha, out int numero2))
            {
                int resultado = 0;
                bool valido = true;

                switch (operador)
                {
                    case '+':
                        resultado = numero1 + numero2;
                        break;
                    case '-':
                        resultado = numero1 - numero2;
                        break;
                    case '*':
                        resultado = numero1 * numero2;
                        break;
                    case '/':
                        if (numero2 != 0)
                            resultado = numero1 / numero2;
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero.");
                            valido = false;
                        }
                        break;
                    default:
                        valido = false;
                        break;
                }

                if (valido)
                    Console.WriteLine($"El resultado de {numero1} {operador} {numero2} es: {resultado}");
            }
            else
            {
                Console.WriteLine("La operación contiene números inválidos.");
            }
        }
        else
        {
            Console.WriteLine("No se reconoció ningún operador válido (+, -, *, /).");
        }

Console.WriteLine("\nPrograma finalizado.");