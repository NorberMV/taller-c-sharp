namespace exercise_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        long factorial = CalcularFactorial(numero);
        
        Console.WriteLine($"El factorial de {numero} es {factorial}");
    }

    static long CalcularFactorial(int n)
    {
        if (n == 0 || n == 1){
            return 1;
        }
        else {
            long resultado = 1;
            for (int i = 2; i <= n; i++){
                resultado *= i;
            }
            return resultado;
        }
    }
}
