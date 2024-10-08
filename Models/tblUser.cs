
namespace LibraryMSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tblUser
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "The Name field must be between 4 and 30 character")]
        [RegularExpression("(-?([A-Z].\\s)?([A-Z][a-z]+)\\s?)+([A-Z]'([A-Z][a-z]+))?", ErrorMessage = "The Name field is invalid")]
        [DisplayName("Name")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Gender")]
        public string UserGender { get; set; }
        [Required]
        [DisplayName("Department")]
        public string UserDep { get; set; }
        [Required]
        [DisplayName("Admission Number")]
        public Nullable<int> UserAdmNo { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        public string UserEmail { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "The Password field must be atleast 8 character long")]
        [DisplayName("Password")]
        public string UserPass { get; set; }
    }
}
