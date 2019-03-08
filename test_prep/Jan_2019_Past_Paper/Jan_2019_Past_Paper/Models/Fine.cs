using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jan_2019_Past_Paper.Models
{
    //q.1.1
    public enum Offense
    {
        ExpiredLicense,
        Parking,
        Speeding,
        DUI
    }

    //q1.2.
    public enum VehicleType
    {
        Bus, 
        Car,
        Motorcycle,
        Taxi,
        Truck
    }

    public class Fine
    {
        //q.1.3.
        [Required]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]
        [Display(Name = "License Plate")]
        [StringLength(8)]
        public String LicensePlate { get; set; }
        [Required]
        [Display(Name = "Vehicle Type")]
        public VehicleType? VehicleType { get; set; }
        [Required]
        [Display(Name = "Offense")]
        public Offense Offense { get; set; }
        [Display(Name = "Offense Detail")]
        public String OffenseDetail { get; set; }
        [Required]
        [Display(Name = "Offense Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime OffenseDate { get; set; }
        [Required]
        [Display(Name = "Offense Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime OffenseTime { get; set; }
        [Required]
        [Display(Name = "Amount")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "R{0:#.#}")]
        public Decimal Amount { get; set; }
        [Required]
        [Display(Name = "Outstanding")]
        public Boolean Outstanding { get; set; }



    }
}