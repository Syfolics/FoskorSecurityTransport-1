using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoskorSecurityTransport.ViewModel
{
    public class VehicleViewModel
    {

        public List<SelectListItem> Vehicles { get; set; }
        public int VehicleId { get; set; }
        public string Name { get; set; }
        public string make { get; set; }
        public string Model { get; set; }
        public string status { get; set; }
    }
}