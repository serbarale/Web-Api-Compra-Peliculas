namespace WebApi_A1m.Model
{
    public class Producto
    {
        public int Id { get; set; }
        public string titulo { get; set; } = null!;    
        public int genero_id { get; set;}
        public int duracion { get; set;}
        public string sinopsis { get; set; } = null!;
        public string fechaLanzamiento { get; set; } = null!;
        public double precio { get; set; }
        public string imagenURL { get; set; } = null!;
    }
}
