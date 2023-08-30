namespace exercise_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero)){
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
        }
    }
}

