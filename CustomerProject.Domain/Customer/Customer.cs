using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject.Domain.Customer
{
    public class Customer
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be less than 50 character and at least character required.")]
        public string Name { get; set; }
        [Range(0, 110, ErrorMessage = "Age must be between 0 to 110 years.")]
        public int Age { get; set; }

        //[RegularExpression(@"/^(?:[0-9]+[a-z]|[a-z]+[0-9])[a-z0-9]*$/i", ErrorMessage = "Postcode must contains letters and numbers.")]
        [Required]
        public string PostCode { get; set; }
        [Range(0, 2.50, ErrorMessage = "Height must be between 0 to 2.50 meters.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Height must only contains two decimal places")]
        public double Height { get; set; }

    }
}
