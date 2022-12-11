using System.Diagnostics;
//Nombre: Joel Delgado
namespace Lab02_RecursivoFibonacci;
class Program
{
    static void Main(string[] args)
    {
        int n, k;
        Stopwatch reloj = new Stopwatch();
        Stopwatch reloj2 = new Stopwatch();
        do
        {
            Console.WriteLine("Introduzca el número de términos: ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n <= 1);

        
        Console.WriteLine("\t ****Serie de números de Fibonacci recursivo****");
        
        reloj.Start();
        for(k = 0; k < n; k++){
            Console.Write(FibonacciRecursivo(k) + "  ");
        }
        reloj.Stop();
        Console.WriteLine($"Elapsed time in Fibonacci Recursivo: {reloj.ElapsedMilliseconds}ms");

        reloj2.Start();
        Console.WriteLine("\t ****Serie de números de Fibonacci iterativo****");
        FibonacciIterativo(n);
        reloj2.Stop();
        Console.WriteLine($"Elapsed time in Fibonacci Iterativo: {reloj2.ElapsedMilliseconds}ms");
    }

    public static int FibonacciRecursivo(int n){
        if(n < 2){
            return n;
        }else{
            return FibonacciRecursivo(n - 2) + FibonacciRecursivo(n - 1);
        }
    }

    public static void FibonacciIterativo(int n){
        int i, ant1, ant2;
        ant1 = ant2 = 1;
        Console.Write("0  1  1  ");
        for(i = 1; i < n - 2; i++){
            int actual = ant1 + ant2;
            Console.Write(actual + "  ");
            ant1 = ant2;
            ant2 = actual;
        }
    } 
}
