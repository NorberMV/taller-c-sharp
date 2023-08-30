namespace exercise_8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una temperatura en grados Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Aplicar la fórmula de conversión
        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine($"Equivalente en grados Fahrenheit: {fahrenheit} °F");
        
    }
}
