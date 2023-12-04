using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendGiancarla.Models
{
    public class Hangar
    {
        [Key]
        public int idHangares { get; set; }
        public string capacidad { get; set; }
        public string localizacion { get; set; }
    }
}
