using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasing.web.Data.Entities;
using Newtonsoft.Json;

namespace MyLeasing.web.Models
{
    public class ContractVIewModel :Contract
    {
        public int OwnerID { get; set; }
        public int PropertyId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [Display(Name ="Lesse")]
        [Range(1, int.MaxValue,ErrorMessage ="You must select a lessee.")]
        public int LesseeId { get; set; }

        public IEnumerable<SelectListItem> Lesses { get; set; }
    }
}
