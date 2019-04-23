using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataWithoutEF.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual School School { get; set; }
    }
}
