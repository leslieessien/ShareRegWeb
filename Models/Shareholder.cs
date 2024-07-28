using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShareRegWeb.Models
{
    public class Shareholder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Gender")]
        public string Gender { get; set; }

        [Required]
        [DisplayName("Nationality")]
        public string Nationality { get; set; }

        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required]
        [DisplayName("Digital Address")]
        public string DigitalAddress { get; set; }

        [Required]
        [DisplayName("Tax Identification Number")]
        public string Tin { get; set; }

        [Required]
        [DisplayName("Ghana Card Number")]
        public string IdNumber { get; set; }

        [Required]
        [DisplayName("Photo")]
        public IFormFile Photo { get; set; } // For file upload
    }
}
