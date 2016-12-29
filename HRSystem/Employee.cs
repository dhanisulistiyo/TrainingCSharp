using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    public class Employee
    {
        public string name { get; set; }
        public string id { get; set; }
        public int yearJoin { get; set; }
        public int totalAbsen { get; set; }

        public Employee(string name, string id, int yearJoin)
        {
            this.name = name;
            this.id = id;
            this.yearJoin = yearJoin;
        }

        public virtual long getSalary()
        {
            long standard = 2700000;
            return standard;
        }

        public int getTotalAbsence()
        {
            return totalAbsen;
        }

        public void setTotalAbsence(int totalAbsen)
        {
            this.totalAbsen = totalAbsen;
        }

        public long getDeductedSalary()
        {
            if (getTotalAbsence() == 0)
            {
                return 0;
            }
            long salaryPerDay = getSalary() / 20;
            return salaryPerDay * getTotalAbsence();
        }

        public long getTotalSalary()
        {
            long totalSalary = getSalary() - getDeductedSalary();
            return totalSalary;
        }

        public int totalTahunKerja()
        {
            string year = DateTime.Now.Year.ToString();
            int x = Convert.ToInt32(year) - yearJoin;
            return x ;
        }
        public long salaryOnYears()
        {
            long y = (getSalary() * 12);
            return y;
        }

        public long getAnnualBonus()
        {
            int x = totalTahunKerja();
            long bonusSalarry = 0;

            if (x <= 1)
                bonusSalarry = (salaryOnYears() * 5 )/ 100;
            else if (x > 1 && x<=2)
                bonusSalarry = (salaryOnYears() * 10) / 100;
            else if (x > 2 && x<=5 )
                bonusSalarry = (salaryOnYears() * 15) / 100;
            else if (x > 5)
                bonusSalarry = (salaryOnYears() * 20) / 100;

            return bonusSalarry;
        }






    }
}
