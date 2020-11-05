using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCookingMaster.BL.Models.Common
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
