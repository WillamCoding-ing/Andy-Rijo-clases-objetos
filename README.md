# TecnoPunto
# Registro de Productos en C#

> Programa diseñado para registrar productos aplicando los conceptos de **clases, objetos y propiedades** en C#. Permite registrar hasta **3 productos** con su código, nombre, precio y cantidad, mostrando al final el valor total de todo el stock de cada producto.

---

## Datos del Autor
* **Nombre:** Andy Williams Rijo Báez
* **Matrícula:** 2025-0114

---

## Datos de Entrada
* **Código (`int`):** Identificador numérico del producto.
* **Nombre (`string`):** Descripción o nombre del artículo.
* **Precio (`double`):** Precio unitario del producto.
* **Cantidad (`int`):** Unidades disponibles en el stock.

---

## Datos que Procesa
* **Valida el Nombre:** El programa verifica con `string.IsNullOrWhiteSpace` para evitar datos nulos o en blanco.
* **Valida el Precio:** El programa comprueba que el valor ingresado sea mayor que `0`.
* **Valida la Cantidad:** El programa comprueba que el stock no sea un número negativo.
* **Calcula el Valor Total:** El programa multiplica `Precio * Cantidad` mediante una propiedad de solo lectura (`ValorTotal`).

---

## Datos de Salida
El programa imprime en consola un resumen con los siguientes elementos: **Código**, **Nombre**, **Precio**, **Cantidad** y **Total calculado**.

---

## Capturas de Pantalla

### Caso #1: Datos correctamente validados
<img width="510" height="328" alt="Datos válidos" src="https://github.com/user-attachments/assets/8d5d2b81-1f7b-4d37-8ecc-44b48c5f9ad9" />

### Caso #2: Precio negativo
<img width="623" height="356" alt="Precio negativo" src="https://github.com/user-attachments/assets/92979247-15c2-4b16-b562-0dd4caf874b7" />

### Caso #3: Nombre vacío
<img width="482" height="361" alt="Nombre vacío" src="https://github.com/user-attachments/assets/394da204-0298-4223-a172-62025dbbda0d" />

### Caso #4: Cantidad cero
<img width="518" height="368" alt="Cantidad cero" src="https://github.com/user-attachments/assets/9b397319-a7d0-463f-ba7e-9075aea72c8d" />
