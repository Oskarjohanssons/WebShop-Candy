using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace WebShop_Candy.Models
{
    public class Order
    {
        [Key]
        [BindNever]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Please enter your First Name")]
        [Display(Name ="First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Last Name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your Adress")]
        [Display(Name = "Street Adress")]
        [StringLength(100)]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Please enter your City")]
        [Display(Name = "City")]
        [StringLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter your State")]
        [Display(Name = "State")]
        [StringLength(100,MinimumLength =2)]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter your Zip Code")]
        [Display(Name = "Zip Code")]
        [StringLength(5,MinimumLength =5)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}
