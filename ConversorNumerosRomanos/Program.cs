namespace ConversorNumerosRomanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> numeroRomanos = new Dictionary<char, int>() {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10},
                { 'L', 50},
                { 'C', 100},
                { 'D', 500},
                { 'M', 1000}
        };
            Console.WriteLine("Digite el numero romano que quiere convertir: ");

            string numeroEnRomanos = Console.ReadLine().ToUpper();
            int numeroFinal = 0;

            for (int i = 0; i < numeroEnRomanos.Length; i++)
            {

                if (numeroEnRomanos.Contains("IIII") || numeroEnRomanos.Contains("VV") || numeroEnRomanos.Contains("XXXX") || numeroEnRomanos.Contains("LL")||
                    numeroEnRomanos.Contains("CCCC") || numeroEnRomanos.Contains("DD") || numeroEnRomanos.Contains("MMMM"))
                {
                    Console.WriteLine("Numero romano invalido por exceso de repeticiones.");
                    return;
                }
                int valorActual = numeroRomanos[numeroEnRomanos[i]];
                
                if(i+1<numeroEnRomanos.Length)
                {
                    int valorSiguiente = numeroRomanos[numeroEnRomanos[i+1]];

                    if(valorActual< valorSiguiente )
                    {
                        numeroFinal -= valorActual;
                    }
                    else
                    {
                        numeroFinal += valorActual;
                    }
                }
                else
                {
                    numeroFinal += valorActual;
                }
            }
            Console.WriteLine($"El número romano {numeroEnRomanos} es igual a {numeroFinal}");

        }

    }
}
