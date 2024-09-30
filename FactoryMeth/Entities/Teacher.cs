using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMeth.Entities
{
    public class Teacher : Entity
    {
        public int Experience { get; set; }
        public List<int> Courses { get; set; } = new List<int>();
        public Teacher(int id, string name, int experience, List<int> courses) : base(id, name)
        {
            Experience = experience;
            Courses = courses;
        }
    }
}
