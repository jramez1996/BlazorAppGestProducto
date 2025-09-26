# Gesti�n de Productos - Blazor .NET 6.0+
## Descripci�n
Este proyecto es una aplicaci�n m�nima construida con Blazor en .NET 6.0+. Permite gestionar productos, mostrando una lista de productos y permitiendo la inserci�n de nuevos productos.

## Requisitos
- .NET 6.0 o superior
- MongoDB para persistencia de datos
- Un servidor SQL para ejecutar el script de consulta de productos

## Instrucciones para ejecutar la aplicaci�n

### Paso 1: Clonar el repositorio
Clona este repositorio en tu m�quina local.

```bash
git clone https://github.com/jramez1996/BlazorAppGestProducto.git
cd BlazorAppGestProducto
## Persistencia de datos
Este proyecto utiliza **MongoDB** como base de datos NoSQL para almacenar la información de los productos.

### Script SQL
Aunque estamos utilizando MongoDB para la persistencia de datos, como parte de la tarea se solicitó un ejemplo de consulta SQL. A continuación, se incluye un archivo SQL (`productos_query.sql`) que muestra cómo se haría una consulta para obtener todos los productos con un precio mayor a 1000 en una base de datos relacional:

### Resumen:
- **MongoDB**: Utilizas MongoDB para almacenar los productos.
- **SQL**: Incluyes un archivo `productos_query.sql` como ejemplo (aunque no interactúe con MongoDB), porque el ejercicio lo requiere.
- **README.md**: Explicas por qué no estás utilizando SQL en el proyecto, pero proporcionas el archivo como parte de los requisitos.

Además, escribe un script SQL (archivo .sql) con una consulta de ejemplo que obtenga todos los productos con Precio > 1000.
-Sql aqui esta -Sql/query.sql
-Mongo aqui esta -Mongo/query.js
