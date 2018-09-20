using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitsAndGeese.Models
{
    public class Saddle
    {
        public string Material { get; set; }
        public Size size { get; set; }
        public double Price { get; set; }
        public SaddleType Type { get; set; }
    }

    public enum SaddleType
    {
        War,
        Speed,
        Yoga,
        Karate,
        Luxury,
        Party
    }
}
