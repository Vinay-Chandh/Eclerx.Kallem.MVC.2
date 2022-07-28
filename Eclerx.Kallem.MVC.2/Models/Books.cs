using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Eclerx.Kallem.MVC._2.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "ISBN cannot be empty")]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Book Name cannot be empty")]
        [Display(Name = "Book Name")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Genre Name cannot be empty")]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Author Name cannot be empty")]
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }

        public DateTime PublishedDate { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
    }
}