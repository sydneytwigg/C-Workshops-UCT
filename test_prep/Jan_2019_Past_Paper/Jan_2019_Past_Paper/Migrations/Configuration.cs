namespace Jan_2019_Past_Paper.Migrations
{
    using Jan_2019_Past_Paper.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Jan_2019_Past_Paper.DAL.TrafficContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Jan_2019_Past_Paper.DAL.TrafficContext context)
        {
            var fines = new List<Fine>
            {
                new Fine {
                    LicensePlate = "CY4345",
                    VehicleType = VehicleType.Car,
                    Offense = Offense.Speeding,
                    OffenseDetail = "85km/h in a 60 zone.",
                    OffenseDate = DateTime.Parse("2017-08-10"),
                    OffenseTime = DateTime.Parse("05:50"),
                    Amount = 50.50m,
                    Outstanding = true
                },
                new Fine {
                    LicensePlate = "CA323566",
                    VehicleType = VehicleType.Bus,
                    Offense = Offense.Parking,
                    OffenseDetail = "Parked on red line.",
                    OffenseDate = DateTime.Parse("2018-01-20"),
                    OffenseTime = DateTime.Parse("16:20"),
                    Amount = 350.00m,
                    Outstanding = true
                },
                new Fine {
                    LicensePlate = "CY198450",
                    VehicleType = VehicleType.Car,
                    Offense = Offense.Speeding,
                    OffenseDetail = "140km/h in a 100 zone.",
                    OffenseDate = DateTime.Parse("2014-03-12"),
                    OffenseTime = DateTime.Parse("09:15"),
                    Amount = 500.00m,
                    Outstanding = true
                },
                new Fine {
                    LicensePlate = "CA321",
                    VehicleType = VehicleType.Motorcycle,
                    Offense = Offense.Speeding,
                    OffenseDetail = "65km/h in a 40 zone.",
                    OffenseDate = DateTime.Parse("2018-10-19"),
                    OffenseTime = DateTime.Parse("15:00"),
                    Amount = 250.00m,
                    Outstanding = true
                },
                new Fine {
                    LicensePlate = "CA974039",
                    VehicleType = VehicleType.Car,
                    Offense = Offense.DUI,
                    OffenseDetail = "DUI of alcohol.",
                    OffenseDate = DateTime.Parse("2016-11-11"),
                    OffenseTime = DateTime.Parse("10:10"),
                    Amount = 650.75m,
                    Outstanding = false
                },
                new Fine {
                    LicensePlate = "CY936503",
                    VehicleType = VehicleType.Car,
                    Offense = Offense.Parking,
                    OffenseDetail = "Illegally parked on corner.",
                    OffenseDate = DateTime.Parse("2015-06-21"),
                    OffenseTime = DateTime.Parse("11:41"),
                    Amount = 250.00m,
                    Outstanding = true
                },
                new Fine {
                    LicensePlate = "CA99840",
                    VehicleType = VehicleType.Truck,
                    Offense = Offense.Speeding,
                    OffenseDetail = "100km/h in a 60 zone.",
                    OffenseDate = DateTime.Parse("2016-06-21"),
                    OffenseTime = DateTime.Parse("09:55"),
                    Amount = 1500.00m,
                    Outstanding = true
                },
                new Fine {
                    LicensePlate = "CA194763",
                    VehicleType = VehicleType.Taxi,
                    Offense = Offense.Parking,
                    OffenseDetail = "Illegal stop.",
                    OffenseDate = DateTime.Parse("2012-01-01"),
                    OffenseTime = DateTime.Parse("07:00"),
                    Amount = 100.00m,
                    Outstanding = false
                },
                new Fine {
                    LicensePlate = "CA883647",
                    VehicleType = VehicleType.Taxi,
                    Offense = Offense.ExpiredLicense,
                    OffenseDetail = "Expired 2015/01/01.",
                    OffenseDate = DateTime.Parse("2018-05-11"),
                    OffenseTime = DateTime.Parse("12:45"),
                    Amount = 250.00m,
                    Outstanding = false
                },
                new Fine {
                    LicensePlate = "CA132874",
                    VehicleType = VehicleType.Car,
                    Offense = Offense.Speeding,
                    OffenseDetail = "75km/h in a 60 zone.",
                    OffenseDate = DateTime.Parse("2015-10-10"),
                    OffenseTime = DateTime.Parse("09:35"),
                    Amount = 250.00m,
                    Outstanding = true
                }
            };

            fines.ForEach(f => context.Fine.AddOrUpdate(i => i.LicensePlate, f));
            context.SaveChanges();
        }
    }
}
