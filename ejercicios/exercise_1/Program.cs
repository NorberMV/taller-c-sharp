namespace exercise_1;

class Program
{
    static void Main(string[] args)
    {
        int number_1;
        int number_2;
        int suma = 0;
        Console.Clear();
        //Presentación del programa
        Console.WriteLine("Este programa recibe dos numeros enteros dados por el usuario y retorna la suma. Ejemplo:\n\n" +
        ">> Ingrese el primer numero: 35\n" +
        ">> Ingrese el segundo numero: 35\n" +
        ">> La suma de los números enteros 35 y 35 fue: 70\n\n");

        Console.Write("Ingrese primer numero: ");
        number_1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        number_2 = int.Parse(Console.ReadLine());
        suma = number_1 + number_2;
        Console.WriteLine("La suma de los números enteros {0:D} y {1:D} fue: {2:D}", number_1, number_2, suma);
        Console.WriteLine("Presione cualquier tecla para salir ... ;)");
        Console.ReadKey();
    }
}
