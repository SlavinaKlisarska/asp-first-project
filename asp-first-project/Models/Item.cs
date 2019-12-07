using System;
using System.ComponentModel.DataAnnotations;

namespace asp_first_project.Models
{
    public class Item
    {
        public int id { get; set; }
      [Required, StringLength(20, ErrorMessage = "Max length is 20.")]
        public string name { get; set; }
        [DataType(DataType.Date)]
        public DateTime due { get; set; }
    }
}