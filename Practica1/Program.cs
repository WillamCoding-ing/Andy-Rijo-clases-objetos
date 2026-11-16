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

                Console.Write("Ingresa el nombre del producto: ");
                string nm = Console.ReadLine();

                Console.Write("Ingresa el precio del producto:");
                double n3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa la cantidad en stock:");
                int n4 = Convert.ToInt32(Console.ReadLine());

                Producto total5 = new Producto(n1, nm, n3, n4); 
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
                    if (string.IsNullOrWhiteSpace(value)) // valida si el valor es null o un espacio en blanco
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
                    if (_precio <= 0)
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
                    return Precio * Cantidad;
                }

            }

        public Producto(int codigo, string nombre, double precio, int cantidad)
            {
                Codigo = codigo;
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }


            public void MostrarInfo()
            {
                Console.WriteLine("===================");
                Console.WriteLine("DATOS DEL PRODUCTO");
                Console.WriteLine("===================");
                Console.WriteLine($"Codigo: {_codigo}");
                Console.WriteLine($"Nombre: {_nombre}");
                Console.WriteLine($"Precio: {_precio}");
                Console.WriteLine($"Cantidad: {_cantidad}");
                Console.WriteLine($"Total: {ValorTotal}");
            }








        }


    }
}
