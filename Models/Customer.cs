
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models{
    [Table("Customers")]
    public class Customer:Person {
        public string? Email {get; set;}
        [MaxLength(30)]

        public bool Gender {get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday {get; set; }
    }
}