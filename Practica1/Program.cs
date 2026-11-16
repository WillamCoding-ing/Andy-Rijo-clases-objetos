using System.Runtime.InteropServices;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("    TecnoPunto   ");
            Console.WriteLine("==================");

            for (int i = 1; i <= 3; i++) // Este bucle creara 3 objetos
            {
                Console.Write("Ingresa el codigo del producto:");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el nombre del producto:");
                string nm = Console.ReadLine();

                Console.Write("Ingresa el precio del producto:");
                double n3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa la cantidad en stock:");
                int n4 = Convert.ToInt32(Console.ReadLine());

                Producto total5 = new Producto(n1, nm, n3, n4); // Este es el objeto creado al cual se le atribuiran los parametros mediante variables creadas para almacenar los datos que se introdujeron con el teclado
                total5.MostrarInfo(); 
            }
            
        }


    }
}
