using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        [Display(Name = "Published")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime PublishDate { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
