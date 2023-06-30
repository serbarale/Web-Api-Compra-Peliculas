using WebApi_D1M.Models;

namespace WebApi_D1M.Services
{
    public interface IProducto
    {
        IEnumerable<Producto> GetAllProducts();
        Producto ProductoById (int id);
        void add(Producto producto);
        void update(Producto p);
        void delete(int id);
    }
}
