using System;
using System.Collections.Generic;

namespace Databasefirst.Models
{
    public partial class staff
    {
        public staff()
        {
            StaffContactLists = new HashSet<StaffContactList>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Position { get; set; } = null!;

        public virtual ICollection<StaffContactList> StaffContactLists { get; set; }
    }
}
