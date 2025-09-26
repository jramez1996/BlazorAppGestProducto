using BlazorAppGestProducto.Models;

namespace BlazorAppGestProducto.Servicios
{
    public interface IProductoService
    {
        Task<List<Producto>> GetProductos();
        Task AddProducto(Producto producto);
        Task UpdateProducto(Producto producto);
    }
}
