using System;
using System.Collections.Generic;

namespace CSE_201_Prototype.Models
{
    public class Software
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string UrlAddress { get; set; }
        public string SoftwareName { get; set; }
        public int CitedArticles { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}