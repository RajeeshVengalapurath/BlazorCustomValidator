using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCustomValidator.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
