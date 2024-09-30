using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMeth.Entities
{
    public class Student : Entity
    {
        public List<int> Courses { get; set; } = new List<int>();
        public Student(int id, string name, List<int> courses) : base(id, name)
        {
            Courses = courses;
        }
    }
}
