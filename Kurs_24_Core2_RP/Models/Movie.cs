using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_24_Core2_RP.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "You must ....")]
        [MinLength(3,ErrorMessage = "3>")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Must have")]
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
