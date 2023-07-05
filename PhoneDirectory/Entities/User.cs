using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Entities
{
    public class User : BaseIdWithDates
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual List<Person> Person { get; set; }
    }
}
