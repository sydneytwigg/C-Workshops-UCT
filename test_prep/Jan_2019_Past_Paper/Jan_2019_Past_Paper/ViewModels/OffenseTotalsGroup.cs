using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Jan_2019_Past_Paper.Models;

namespace Jan_2019_Past_Paper.ViewModels
{
    public class OffenseTotalsGroup
    {
        public Offense Offense { get; set; }
        public Decimal sumFines { get; set; }
    }
}