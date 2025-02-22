using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== Menu de Opciones ===");
            Console.WriteLine("1. Calculadora Basica");
            Console.WriteLine("2. Validacion de Contraseña");
            Console.WriteLine("3. Verificar Numero Primo");
            Console.WriteLine("4. Suma de Numeros Pares");
            Console.WriteLine("5. Conversion de Temperatura");
            Console.WriteLine("6. Contador de Vocales");
            Console.WriteLine("7. Calculo de Factorial");
            Console.WriteLine("8. Juego de Adivinanza");
            Console.WriteLine("9. Intercambio de Valores");
            Console.WriteLine("10. Tabla de Multiplicar");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: CalculadoraBasica(); break;
                case 2: ValidacionContrasena(); break;
                case 3: VerificarPrimo(); break;
                case 4: SumaNumerosPares(); break;
                case 5: ConversionTemperatura(); break;
                case 6: ContadorVocales(); break;
                case 7: CalculoFactorial(); break;
                case 8: JuegoAdivinanza(); break;
                case 9: IntercambioValores(); break;
                case 10: TablaMultiplicar(); break;
                case 0: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opcion no valida."); break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 0);
    }

    static void CalculadoraBasica()
    {
        Console.Write("Ingrese el primer numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la operacion (+, -, *, /): ");
        char operacion = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (operacion)
        {
            case '+': Console.WriteLine($"Resultado: {num1 + num2}"); break;
            case '-': Console.WriteLine($"Resultado: {num1 - num2}"); break;
            case '*': Console.WriteLine($"Resultado: {num1 * num2}"); break;
            case '/':
                if (num2 != 0) Console.WriteLine($"Resultado: {num1 / num2}");
                else Console.WriteLine("Error: Division por 0.");
                break;
            default: Console.WriteLine("Operacion no valida."); break;
        }
    }

    static void ValidacionContrasena()
    {
        string password = "1234";
        string intento;
        do
        {
            Console.Write("Ingrese la contraseña: ");
            intento = Console.ReadLine();
            if (intento != password) Console.WriteLine("Contrasena incorrecta.");
        } while (intento != password);
        Console.WriteLine("Acceso concedido.");
    }

    static void VerificarPrimo()
    {
        Console.Write("Ingrese un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool esPrimo = num > 1;

        for (int i = 2; i < num; i++)
            if (num % i == 0) esPrimo = false;

        Console.WriteLine(esPrimo ? "Es primo" : "No es primo");
    }

    static void SumaNumerosPares()
    {
        int suma = 0, num;
        do
        {
            Console.Write("Ingrese un numero (0 para salir): ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) suma += num;
        } while (num != 0);
        Console.WriteLine($"Suma de pares: {suma}");
    }

    static void ConversionTemperatura()
    {
        Console.Write("Ingrese temperatura: ");
        double temp = Convert.ToDouble(Console.ReadLine());
        Console.Write("Convertir a (C)elsius o (F)ahrenheit: ");
        char tipo = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (tipo == 'C') Console.WriteLine($"Celsius: {(temp - 32) * 5 / 9}");
        else if (tipo == 'F') Console.WriteLine($"Fahrenheit: {temp * 9 / 5 + 32}");
        else Console.WriteLine("Opcion no valida.");
    }

    static void ContadorVocales()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine().ToLower();
        int contador = 0;
        foreach (char letra in frase)
            if ("aeiou".Contains(letra)) contador++;
        Console.WriteLine($"Cantidad de vocales: {contador}");
    }

    static void CalculoFactorial()
    {
        Console.Write("Ingrese un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;
        for (int i = 1; i <= num; i++) factorial *= i;
        Console.WriteLine($"Factorial: {factorial}");
    }

    static void JuegoAdivinanza()
    {
        Random rand = new Random();
        int secreto = rand.Next(1, 101), intento;
        do
        {
            Console.Write("Adivine el numero (1-100): ");
            intento = Convert.ToInt32(Console.ReadLine());
            if (intento < secreto) Console.WriteLine("Demasiado bajo.");
            else if (intento > secreto) Console.WriteLine("Demasiado alto.");
        } while (intento != secreto);
        Console.WriteLine("¡Correcto!");
    }

    static void IntercambioValores()
    {
        Console.Write("Ingrese el primer numero: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int b = Convert.ToInt32(Console.ReadLine());
        (a, b) = (b, a);
        Console.WriteLine($"Numeros intercambiados: A={a}, B={b}");
    }

    static void TablaMultiplicar()
    {
        Console.Write("Ingrese un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{num} x {i} = {num * i}");
    }
}
