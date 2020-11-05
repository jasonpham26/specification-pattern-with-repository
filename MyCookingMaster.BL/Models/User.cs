using MyCookingMaster.BL.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCookingMaster.BL.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}
