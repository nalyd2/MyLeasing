using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.web.Data.Entities
{
    public class Lessee
    {
        
            public int Id { get; set; }

        public User User { get; set; }

        public ICollection<Contract> Contracts { get; set; }


    }

}

