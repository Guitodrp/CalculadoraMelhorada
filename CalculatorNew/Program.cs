CalculatorNew calculatorNew = new("Calculadora!");
calculatorNew.Run();

public sealed class CalculatorNew(string message)
{
    private string _message = message;

    public void Run()
    {
        Console.WriteLine(_message + "\n");

        Dictionary<int, string> operadores = new()
        {
            { 1, "+ Soma" },
            { 2, "- Subtração" },
            { 3, "* Multiplicação" },
            { 4, "/ Divisão" }
        };

        while (true)
        {
            Console.WriteLine("Operadores: ");
            foreach (var op in operadores)
            {
                Console.WriteLine($"{op.Key}: {op.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("Escolha um operador: ");
            int operador = Convert.ToInt32(Console.ReadLine());
            if (!operadores.TryGetValue(operador, out string operadorTexto))
            {
                Console.WriteLine("Operador inválido!");
                continue;
            }
            Console.WriteLine("Digite o primeiro número: ");
            string num1 = Console.ReadLine();

            if (!int.TryParse(num1, out int numero1))
            {
                Console.WriteLine($"{num1} não pode ser convertido para double.");
            }
            Console.WriteLine("Digite o segundo número: ");
            string num2 = Console.ReadLine();

            if (!int.TryParse(num2, out int numero2))
            {
                Console.WriteLine($"{num1} não pode ser convertido para double.");
            }

            Console.WriteLine("Resultado: " + Calcular(operador, numero1, numero2));
            Console.WriteLine();

            //Console.WriteLine("Deseja realizar outra conta? (s/n)");

            Console.Write("Press <Enter> to continue... ");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                break;
            }
        }
    }
    public static double Calcular(int operador, double num1, double num2)
    {
        double resultado = 0;
        switch (operador)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                resultado = num1 / num2;
                break;
        }
        return resultado;
    }

}