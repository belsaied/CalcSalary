using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Nu_2
{
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public virtual float CalcSalary()
        {
            return Salary;
        }



        #region Parametrize ctor
        //public Emp(int _id, string _name, float _salary)
        //{
        //    Id = _id;
        //    Name = _name;
        //    Salary = _salary;
        //}
        #endregion
    }

    #region Abstract class
    abstract class Emp_V02
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public abstract float CalcSalary();
    }
    #endregion
}
