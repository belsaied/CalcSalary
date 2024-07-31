using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Nu_2
{
    public class PT_Emp:Emp
    {
        public int Hours { get; set; }
        public float RateHour { get; set; }

        public override float CalcSalary()
        {
            return Hours * RateHour;
        }
    }

    #region Abstract PT_Emp
    class PT_Emp_2 : Emp_V02
    {
        public int Hours { get; set; }
        public float RateHour { get; set; }

        public override float CalcSalary() => Hours * RateHour;
    }
    #endregion
}
