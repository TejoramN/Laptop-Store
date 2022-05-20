using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Laptop_Store.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }

        public string Description { get; set; }
        [Required]

        public string Brand { get; set; }
        [Required]
        [Display(Name = "List price")]


        public double ListPrice { get; set; }
        [Required]

        public double Price { get; set; }
        [ValidateNever]

        public string ImageUrl { get; set; }
        [Display(Name ="Category")]

        public int CategoryId { get; set; }
        [ValidateNever]

        public Category Category { get; set; }
        [Display(Name="Cover Type")]

        public int CoverTypeId { get; set; }
        [ValidateNever]

        public CoverType CoverType { get; set; }
    }
}
