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
        class Producto
        {
            //propiedades privadas
            private int _codigo;
            private string _nombre;
            private double _precio;
            private int _cantidad;

            public int Codigo { get { return _codigo; } set { _codigo = value; } }
            public string Nombre
            { get
                {
                    return _nombre;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value)) // valida si datos de tipo string son null o un espacio en blanco referente al valor de la propiedad
                    {
                        Console.WriteLine("No puede estar vacio la propiedad Nombre!!!");
                    }
                    else
                    {
                        _nombre = value;
                    }
            }  }  
            
            
        public double Precio
            { get
                {
                    return _precio;
                }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("El precio no puede ser igual o menor que cero...");
                    }
                    else
                    {
                        _precio = value;
                    }
                }             
             }
        public int Cantidad
            {
                get
                {
                    return _cantidad;
                }
                set
                {
                if (value < 0)
                    {
                        Console.WriteLine("La cantidad no puede ser negativa!!");
                    }
                    else
                    {
                        _cantidad = value;
                    }
                }
            }

        public double ValorTotal
            { get
                {
                    return Precio * Cantidad; // Devolvera el valor de solo lectura Precio*Cantidad
                }

            }

        public Producto(int codigo, string nombre, double precio, int cantidad) // Este es el constructor que inicializara las propiedades
            {
                Codigo = codigo;
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }


            public void MostrarInfo() // Este metodo imprimira los datos del producto 
            {
                Console.WriteLine("===================");
                Console.WriteLine("DATOS DEL PRODUCTO");
                Console.WriteLine("===================");
                Console.WriteLine($"Codigo: {_codigo}");
                Console.WriteLine($"Nombre: {_nombre}");
                Console.WriteLine($"Precio: {_precio}");
                Console.WriteLine($"Cantidad: {_cantidad}");
                Console.WriteLine($"Total: ${ValorTotal}");
            }








        }


    }
}
