using System;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
