using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GitDemoOne.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [Display(Name ="Book Name")]
        [StringLength(50)]
        public string BookName { get; set; }
        [Required]
        [Display(Name ="Author Name")]
        [StringLength(50)]
        public string AuthorName { get; set; }
        [Required]
        [Display(Name ="Book Price")]
        public decimal Price { get; set; }
    }
}
