using System;
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

        [MaxLength(20)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        public string Adress { get; set; }


        //campos de solo lectura
        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWhithDocument => $"{FirstName} {LastName} - {Document}";


    }

}
