namespace exercise_9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());
        bool es_primo = EsPrimo(numero);
        if (es_primo){
            PrintResult(numero, es_primo);
        }
        else{
            PrintResult(numero, es_primo);
        }
    }

    // Esta función verifica si un número es primo.
    // Devuelve true si el número es primo, y false si no lo es.
    static bool EsPrimo(int num){
        if (num <= 1){
            return false;
        }
        // Iteramos desde 2 hasta la raíz cuadrada del número
        // para verificar si existe algún divisor.
        for (int i = 2; i * i <= num; i++){
            if (num % i == 0){
                return false;
            }
        }
        return true;
    }
    // Cree esta función solo para imprimir el resultado y tratar de
    // hacerla reusable.
    static void PrintResult(int numero, bool es_primo){
        if (es_primo) {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else {
            Console.WriteLine($"{numero} no es un número primo.");
        }
    }
}
