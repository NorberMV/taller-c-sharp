namespace exercise_2;

class Program
{
    static void Main(string[] args)
    {
        int number_1 = 0;
        int number_2 = 0;
        string operation;
        int? operation_result;
        Console.Clear();
        //Presentación del programa
        Console.WriteLine("Este programa recibe dos numeros enteros, permite seleccionar la operación aritmetica deseada " +
        "por el usuario y retorna el resultado de dicha operación. Ejemplo:\n\n" +
        ">> Ingrese el primer numero: 35\n" +
        ">> Ingrese el segundo numero: 35\n" +
        ">> Ingrese la operación aritmetica deseada (+, -, *,/): -\n" +
        ">> El resultado de la operación '-' de los números enteros 35 y 35 es: 0\n\n");

        Console.Write("Ingrese primer numero: ");
        number_1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        number_2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la operación aritmetica deseada (+, -, *,/): ");
        operation = Console.ReadLine();
        // Definicion de condiciones
        if (operation == "+"){
            operation_result = number_1 + number_2;
        }
        else if (operation == "-"){
            operation_result = number_1 - number_2;
        }
        else if (operation == "*"){
            operation_result = number_1 * number_2;
        }
        else if(operation == "/"){
            operation_result = number_1 / number_2;
        }
        // Si la operación no es conocida setear el 
        // resultado como null
        else {
            operation_result = null;
        }
        if (operation_result != null) {
            Console.WriteLine("El resultado de la operación '{0}' de los números enteros {1:D} y {2:D} es: {3:D}", operation, number_1, number_2, operation_result);
        }
        else {
            Console.WriteLine("Operador invalido '{0}'. Favor ingresar una operación aritmetica valida(+, -, *,/) e intente de nuevo.", operation);
        }
        Console.WriteLine("\n\nPresione cualquier tecla para salir ... ;)");
        Console.ReadKey();
    }
}
