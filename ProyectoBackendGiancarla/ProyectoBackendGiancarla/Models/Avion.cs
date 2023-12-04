using System.ComponentModel.DataAnnotations;
namespace ProyectoBackendGiancarla.Models
{
    public class Avion
    {
        [Key]
        public int idAvion { get; set; }
        public string modelo { get; set; }
        public int peso { get; set; }
        public string capacidad { get; set; }
        public int numeroLicencia { get; set; }
        public int idHangares { get; set; }
    }
}
