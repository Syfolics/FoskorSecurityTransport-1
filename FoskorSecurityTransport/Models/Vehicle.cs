//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoskorSecurityTransport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Vehicle
    {
        [Required]
        [Display(Name = "Vehicle Id")]
        public int VehicleID { get; set; }
        [Required]
        [Display(Name = "Reistration number")]
        public string RegistrationNo { get; set; }

        [Required]
        [Display(Name = "Make")]
        public string Make { get; set; }
        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
