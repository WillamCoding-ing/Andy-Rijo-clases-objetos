using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    class Producto
    {
        //propiedades privadas
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _cantidad;

        public int Codigo { get { return _codigo; } set { _codigo = value; } }
        public string Nombre
        {
            get
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
            }
        }


        public double Precio
        {
            get
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
                if (value <= 0)
                {
                    Console.WriteLine("La cantidad no puede ser negativa o cero!!");
                }
                else
                {
                    _cantidad = value;
                }
            }
        }

        public double ValorTotal
        {
            get
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
