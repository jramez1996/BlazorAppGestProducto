using BlazorAppGestProducto.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlazorAppGestProducto.Servicios
{
    public class ProductoService : IProductoService
    {
        private readonly IMongoCollection<Producto> _productos;
        public ProductoService(IMongoDatabase database)
        {
            _productos = database.GetCollection<Producto>("productos");
        }

        public async Task<List<Producto>> GetProductos()
        {
            // Obtiene todos los productos de la base de datos
            return await _productos.Find(producto => true).ToListAsync();
        }

        public async Task AddProducto(Producto producto)
        {
            // Verificar si ya existe un producto con el mismo nombre
            var existingProduct = await _productos.Find(p => p.Nombre.ToLower() == producto.Nombre.ToLower()).FirstOrDefaultAsync();

            if (existingProduct != null)
            {
                return; // Salimos del método sin insertar nada
            }

            // Si no existe, inserta el nuevo producto
            await _productos.InsertOneAsync(producto);
        }


        public async Task UpdateProducto(Producto producto)
        {
            var filter = Builders<Producto>.Filter.Eq(p => p.Nombre, producto.Nombre);
            await _productos.ReplaceOneAsync(filter, producto);
        }

    }
}
