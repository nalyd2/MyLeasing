using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.web.Data.Entities
{
    public class PropertyType
    {
      
         public int id { get; set; }

        [Display(Name ="Property Type")]
        [MaxLength(50,ErrorMessage ="The {0} field not have more than {1} characters.")]
        [Required(ErrorMessage ="The Field {0} is mandatory.")]
        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; }


    }
    
}
