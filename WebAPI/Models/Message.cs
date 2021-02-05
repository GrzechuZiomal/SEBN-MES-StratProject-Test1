using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI
{
    public class Message
    {
        [Key]
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public string Tresc { get; set; }
    }
}
