using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial2JavierSinani.Models
{
    public class Country
    {

        [Key]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Ingresar nombres entre 3 a 100 caracteres")]
        public string Name { get; set; }
        [Required]
        public string Capital { get; set; }
        public int Population { get; set; }
        public List<string> Timezones { get; set; }
        public Currency Currencies { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
    }
}