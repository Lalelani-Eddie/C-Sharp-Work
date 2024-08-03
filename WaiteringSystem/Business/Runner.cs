using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiteringSystem.Business;

namespace WaiteringSystem.Business
{
    internal class Runner : Role
    {
        internal string EmployeeID;

        #region // Data members specific to Runner
        public double Rate 
        {
            get { return Rate; }
            set { Rate = value; } 
        }
        public double Commission { get; set; }
        public int NoOfShifts { get; set; }
        #endregion


        #region // Constructor using base keyword
        public Runner() : base()
        {
            RoleValue = RoleType.Runner;
            Description = "Runner";
            Rate = 0;
            Commission = 0;
            NoOfShifts = 0;
        }
        #endregion

        #region // Overridable Payment method that returns rate * noOfShifts
        public override double Payment()
        {
            return Rate * NoOfShifts;
        }
        #endregion


        #region // Overridable Payment method that returns rate * noOfShifts + tips
        public override double Payment(double tips)
        {
            return (Rate * NoOfShifts) + tips;
        }
        #endregion
    }
}
