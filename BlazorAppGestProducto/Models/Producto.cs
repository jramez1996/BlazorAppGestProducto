using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppGestProducto.Models
{
    public class Producto
    {
        [BsonId]  // indica que es la PK
        [BsonRepresentation(BsonType.ObjectId)] // Mongo lo guarda como ObjectId pero lo usamos como string
        public string? Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
        public decimal Precio { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
        public int Stock { get; set; }

        
    }
}
