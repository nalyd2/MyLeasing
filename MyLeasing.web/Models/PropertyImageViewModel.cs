using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using MyLeasing.web.Data.Entities;

namespace MyLeasing.web.Models
{
     public class PropertyImageViewModel : PropertyImage
        {
            [Display(Name = "Image")]
            public IFormFile ImageFile { get; set; }
        }

    
}
