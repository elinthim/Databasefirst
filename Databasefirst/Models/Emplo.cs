using System;
using System.Collections.Generic;

namespace Databasefirst.Models
{
    public partial class Emplo
    {
        public int EmploId { get; set; }
        public string Fname { get; set; } = null!;
        public string Lname { get; set; } = null!;
    }
}
