namespace WebApi_D1M.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public int genero_id { get; set;}
        public int duracion { get; set; }
        public string sinopsis { get; set; }
        public string fechaLanzamiento { get; set;}
        public double precio { get; set; }
        public string imagenURL { get; set; }
    }
}
