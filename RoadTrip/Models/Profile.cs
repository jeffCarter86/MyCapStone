﻿using Microsoft.AspNetCore.Identity;

using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;

using System.Threading.Tasks;



namespace RoadTrip.Models

{

    public class Profile

    {



        public int Id { get; set; }



        [Display(Name = "Name")]

        public string Name { get; set; }



        [Display(Name = "Zip Code")]

        //[RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]

        [Required(ErrorMessage = "Zip Code is Required")]

        public string ZipCode { get; set; }



        [ForeignKey("IdentityUser")]

        public string IdentityUserId { get; set; }

        public IdentityUser IdentityUser { get; set; }
    }
}
