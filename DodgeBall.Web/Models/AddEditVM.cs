using DodgeBall.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DodgeBall.Web.Models
{
    public class AddEditVM
    {
        public Team Team { get; set; }
        public String Title { get; set; }
        public String ButtonMessage { get; set; }
    }
}