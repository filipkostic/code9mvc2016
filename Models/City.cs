﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code9MVC.Models
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        public string PostalCode { get; set; }

        [Required]
        public int CountryID { get; set; }

        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }
    }
}