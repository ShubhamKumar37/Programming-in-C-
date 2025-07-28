﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.Samples.Models
{
    [Table("Inventory", Schema ="dbo")]
    [Index(nameof(MakeId), Name = "IX_Inventory_MakeId")]
    public class Car : BaseEntity
    {
        public DateTime? DateBuilt { get; set; }

        private bool? _isDrivable;
        public bool IsDrivable { get => _isDrivable ?? true; set => _isDrivable = value; }

        private string _color;
        //[Required, StringLength(50)]

        public string Color { get => _color; set => _color = value; }

        //[Required, StringLength(50)]
        public string PetName { get; set; }

        public int MakeId { get; set; }

        //[ForeignKey(nameof(MakeId))]
        public Make MakeNavigation { get; set; }
        public Radio RadioNavigation { get; set; }
        
        //[InverseProperty(nameof(Driver.Cars))]  
        public IEnumerable<Driver> Drivers { get; set; }
    }
}
