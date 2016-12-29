using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    public class Teacher : Employee
    {
        public string ofClass;

        public Teacher(string name, string id, int yearJoin, string ofClass) : base(name, id, yearJoin)
        {
            this.ofClass = ofClass;
        }

        public override long getSalary()
            {
                long qaSalary = base.getSalary() + 1000000;
                return qaSalary;
            }


    

    }
}
