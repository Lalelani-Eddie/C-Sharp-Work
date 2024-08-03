using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiteringSystem.Business;

namespace WaiteringSystem.Business
{
    internal class HeadWaiter : Role
    {
        #region // Constructor using base keyword
        public HeadWaiter() : base()
        {
            RoleValue = RoleType.HeadWaiter;
            Description = "HeadWaiter";
            Salary = 0;
        }
        #endregion

        #region // Overridable Payment method that returns salary
        public override double Payment()
        {
            return Salary;
        }
        #endregion

        #region // Property for salary specific to HeadWaiter
        public double Salary { get; set; }
        #endregion
    }
}
