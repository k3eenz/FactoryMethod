using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMeth.Entities
{
    public class Course : Entity
    {
        public int TeacherId { get; set; }
        public List<int> StudentIds { get; set; } = new List<int>();
        public Course(int id, string name, int teacherId, List<int> studentIds) : base(id, name)
        {
            TeacherId = teacherId;
            StudentIds = studentIds;
        }
    }
}
