using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Nu_2
{
    public class FT_Emp:Emp
    {
        public float Bonus { get; set; }
        public float Deduction { get; set; }

        public override float CalcSalary()
        {
            return Salary + Bonus - Deduction;
        }
    }

    #region Abstract FT_Emp
    class FT_Emp_2 : Emp_V02
    {
        public float Bonus { get; set; }
        public float Deduction { get; set; }

        public override float CalcSalary() => Salary + Bonus - Deduction;
    }
    #endregion
}
