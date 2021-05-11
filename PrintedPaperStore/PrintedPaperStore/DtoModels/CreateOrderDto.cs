using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrintedPaperStore.DtoModels
{
    public class CreateOrderDto
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string FullName { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 4)]
        public string Address { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public List<int> BookIds { get; set; }
    }
}
