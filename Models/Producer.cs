﻿using System.ComponentModel.DataAnnotations;

namespace Travflix.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

        //[DataType(DataType.ImageUrl)]
        public string ProducerPhoto { get; set; }
        public string ProducerName { get; set; }
    }
}
