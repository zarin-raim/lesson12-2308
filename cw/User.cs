using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cw
{
    class User
    {
        public bool? IsDeleted { get; set; } //create nullable type
        public string Login { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? Type { get; set; }
    }
}
