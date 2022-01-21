using System;
using System.ComponentModel.DataAnnotations;

namespace DateMeRyanPinkney.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int Application_id { get; set; }

        // Declare the variables of the form
        public string sFirstName { get; set; }

        public string sLastName { get; set; }

        public byte iAge { get; set; }

        public string iPhoneNumber { get; set; }

        public string sMajor { get; set; }

        public bool bIsStocker { get; set; }

    }
}
