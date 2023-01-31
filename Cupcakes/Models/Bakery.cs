using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cupcakes.Models
{
    public class Bakery
    {
        [Key]
        public int BakeryId { get; set; }

        [StringLength(50,MinimumLength =4, ErrorMessage = "El rango es de 4 a 50 caracteres")]
        public string BakeryName { get; set; }

        [Range(1,40,ErrorMessage ="El rango es de 1 a 40")]
        public int Quantity { get; set; }

        [StringLength(50,MinimumLength =4,ErrorMessage ="El rango es de 4 a 50 caracteres")]
        public string Address { get; set; }

        public virtual List<Cupcake> Cupcakes { get; set; }

    }       
}
