using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryMSMVC.Models
{
    public partial class tblBook
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "The Title field must be between 4 and 30 character")]
        [RegularExpression("^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*)$", ErrorMessage = "The Title field is invalid")]
        [DisplayName("Title")]
        public string BookTitle { get; set; }

        [Required]
        [DisplayName("Category")]
        public string BookCategory { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "The Author field must be between 4 and 30 character")]
        [RegularExpression("^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*)$", ErrorMessage = "The Author field is invalid")]
        [DisplayName("Author")]
        public string BookAuthor { get; set; }

        [Required]
        [DisplayName("Copies")]
        [Range(1,2)]
        public Nullable<int> BookCopies { get; set; }

        [DisplayName("Publication")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "The Publication field must be between 4 and 30 character")]
        [RegularExpression("^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*)$", ErrorMessage = "The Publication field is invalid")]
        public string BookPub { get; set; }

        [DisplayName("Pub Name")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "The Pub Name field must be between 4 and 30 character")]
        [RegularExpression("^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*)$", ErrorMessage = "The Pub Name field is invalid")]
        public string BookPubName { get; set; }

        [Required]
        [DisplayName("ISBN")]
        public string BookISBN { get; set; }

        [Range(1700, 2024)]
        [DisplayName("Copyright")]
        public Nullable<int> Copyright { get; set; }

        [Required]
        [DisplayName("Date Added")]
        public string DateAdded { get; set; }

        [Required]
        [DisplayName("Status")]
        public string Status { get; set; }
    }
}
