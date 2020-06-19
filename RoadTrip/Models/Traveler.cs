using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoadTrip.Models
{
    public class Traveler
    {
        public int Id { get; set; }

        [Display (Name = "Trip Name")]
        public string Name { get; set; }

        [Display(Name = "Starting Point")]
        public string From { get; set; }

        [Display(Name = "Destination")]
        public string To { get; set; }

        [Display(Name = "Travel Distance")]
        public double Distance { get; set; }

        [Display(Name = "Gas Fillups/Breaks")]
        public double Stops { get; set; }

        [Display(Name = "Estimated Total Cost of Gas")]
        public double GasCost { get; set; }

        [Display(Name = "Estimated Total Cost of Snacks")]
        public double SnackCost { get; set; }

        [Display(Name = "Emergency Funds")]
        public double Emergency { get; set; }

        [Display(Name = "Estimated Total Cost of Road Trip")]
        public double TripCost { get; set; }

        [Display(Name = "How much can I Budget Monthly for Trip")]
        public double MonthBudget { get; set; }

        [Display(Name = "How many months to pay for Road Trip")]
        public double BudgetMonth { get; set; }

        



    }
}
