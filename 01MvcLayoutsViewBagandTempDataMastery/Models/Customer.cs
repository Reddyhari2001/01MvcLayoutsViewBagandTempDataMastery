using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01MvcLayoutsViewBagandTempDataMastery.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Mobile { get; set; }
        public DateTime OrderDate { get; set; }
    }
}