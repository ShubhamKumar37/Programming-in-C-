using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarProject //DO NOT Change the namespace name
{
    public class Car //DO NOT Change the class name
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; } // Id property

        public string Brand { get; set; } // Brand property

        public string Model { get; set; } // Model property

        public double Price { get; set; } // Price property
    }
} 