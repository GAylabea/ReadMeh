using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadMeh.Models
    {
        public class Book
        {
            [Key]
            public int ID { get; set; } 
            public string Title { get; set; }
            public string Author { get; set; }
            public int Rating { get; set; }
            public string unReview { get; set; }
            public string userId { get; set; }

        }
    }

