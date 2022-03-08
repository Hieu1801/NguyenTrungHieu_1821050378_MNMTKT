using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models{
    [Table("Students")]
    public class Student{
        [Key]
        public string? StudentID {get; set; }
        [Required]
        public string? StudentName {get; set; }
        [MaxLength(30)]

        public string? Address {get; set;}
    }
}