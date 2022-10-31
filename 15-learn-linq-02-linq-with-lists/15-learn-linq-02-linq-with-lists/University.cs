using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_learn_linq_02_linq_with_lists
{
    internal class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return String.Format("University {0} with id {1}", Name, Id);
        }
    }
}
