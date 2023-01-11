using System;
using System.Collections.Generic;

namespace Databasefirst.Models
{
    public partial class Gender
    {
        public string GenderName { get; set; } = null!;
        public int? FkEmploId { get; set; }

        public virtual Emplo? FkEmplo { get; set; }
    }
}
