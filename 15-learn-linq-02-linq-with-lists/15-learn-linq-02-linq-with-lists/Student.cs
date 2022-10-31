using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_learn_linq_02_linq_with_lists
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key
        public int UniversityId { get; set; }

        public override string ToString()
        {
            return String.Format("Student {0} with Id {1}, Gender {2} " +
                "and Age {3} from Uninversity with the Id {4}", Name, Id, Gender, Age, UniversityId);
        }
    }
}
