PROGRAMACIÓN BASICA
C#

Autor: Andy Williams Rijo Báez
Matricula: 2025-0114

Descripción.

Programa diseñado para registrar productos aplicando los conceptos de clases, objetos y propiedades en C#.
Permite registrar hasta 3 productos con su código, nombre, precio, cantidad y muestra al final el valor total de todo el Stock de dicho producto.

Datos de Entrada.
Código(int): Identificador numérico del producto.
Nombre:(string): Descripción o nombre del artículo.
Precio(double): Precio unitario del producto.
Cantidad(int): Unidades disponibles en el stock.

Datos que Procesa.
Valida el Nombre: El programa verifica con "string.IsNullOrWhiteSpace" para que no se pongan datos nulos o en blanco.
Valida el Precio: El programa comprueba que el valor ingresado sea mayor que 0.
Valida la Cantidad: El programa comprueba que el stock no sea un número negativo.
Calcula el Valor Total: El programa multiplica "Precio*Cantidad" mediante una propiedad de solo lecutra.

Datos de Salida.
El programa imprime un resumen de los siguientes elementos: Código, Nombre, Precio, Cantidad, y Total calculado.

Caso 1#: Datos correctamente válidados.
<img width="510" height="328" alt="image" src="https://github.com/user-attachments/assets/8d5d2b81-1f7b-4d37-8ecc-44b48c5f9ad9" />

Caso 2#: Precio negativo.
<img width="623" height="356" alt="image" src="https://github.com/user-attachments/assets/92979247-15c2-4b16-b562-0dd4caf874b7" />

Caso 3#: Nombre vacio.
<img width="482" height="361" alt="image" src="https://github.com/user-attachments/assets/394da204-0298-4223-a172-62025dbbda0d" />

Caso 4#: Cantidad cero.
<img width="518" height="368" alt="image" src="https://github.com/user-attachments/assets/9b397319-a7d0-463f-ba7e-9075aea72c8d" />
