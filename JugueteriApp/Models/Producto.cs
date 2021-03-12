using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JugueteriApp.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        
        [Required,MaxLength(50)]
        public string Nombre { get; set; }
        
        [MaxLength(100)]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        
        [Range(0, 100, ErrorMessage ="El valor debe ser mayor a 0 y menor que 100")]
        [DisplayName("Restriccion Edad")]
        public int RestriccionEdad { get; set; }
        
        [Required, MaxLength(50)]
        [DisplayName("Compañia")]
        public string Compania { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        [Required, Range(1,1000, ErrorMessage ="El valor debe ser mayor que 0 y menor que 1000")]
        public decimal Precio { get; set; }

        public Producto()
        {

        }
    }
}
