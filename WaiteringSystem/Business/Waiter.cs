using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiteringSystem.Business;

namespace WaiteringSystem.Business
{
    internal class Waiter : Role
    {
        #region // Data members specific to Waiter
        public double Rate { get; set; }
        public double Tips { get; set; }
        public int NoOfShifts { get; set; }
        #endregion


        #region // Constructor using base keyword
        public Waiter() : base()
        {
            RoleValue = RoleType.Waiter;
            Description = "Waiter";
            Rate = 0;
            Tips = 0;
            NoOfShifts = 0;
        }
        #endregion

        #region // Overridable Payment method that returns rate * noOfShifts + tips
        public override double Payment()
        {
            return (Rate * NoOfShifts) + Tips;
        }
        #endregion
    }
}
