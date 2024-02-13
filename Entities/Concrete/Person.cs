using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    internal class Person
    {

        public string Firstname  { get; set; } 
        public string Lastname { get; set; }    
        public long NationalIndentity { get; set; }
        public int DateOfBirthYear { get; set; }
       
    }
}
