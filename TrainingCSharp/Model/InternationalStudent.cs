using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCSharp.Model
{
    public class InternationalStudent :Student
    {
        public string passportId;

        public InternationalStudent(string nama, string id, string negara, string passportId) : base( nama, id, negara)
        {
            this.passportId = passportId;
        }

        public InternationalStudent(string nama, string passportId)
        {
            this.passportId = passportId;
            this.name = nama;
        }





    }
}
