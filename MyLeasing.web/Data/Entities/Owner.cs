using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MyLeasing.web.Data.Entities
{
    public class Owner
    {

        public int id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Document { get; set; }

        [MaxLength(50)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(20,ErrorMessage ="The {0} field can not more than {1} characters")]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        public string Adress { get; set; }


        //campos de solo lectura
        [Display(Name ="Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWhithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Property> Properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }

    }

}
