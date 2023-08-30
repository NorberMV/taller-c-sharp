namespace exercise_3

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Presentación del programa
            Console.WriteLine("Este programa recibe un número entero como parametro y retorna su tabla de multiplicar del 1 al 10.\n\n");

            Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
            if (int.TryParse(Console.ReadLine(), out int numero)){
                Console.WriteLine("Tabla de multiplicar del {0}: ", numero);
                for (int i = 1; i <= 10; i++){
                    int resultado = numero * i;
                    // Usando otra forma de string format usando '$'
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                Console.WriteLine("¡Debe ingresar un número válido!");
            }
        }
    }
}

