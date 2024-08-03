using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.Business
{
    internal class Role
    {
        #region // Enumeration for RoleType
        public enum RoleType
        {
            NoRole = 0,
            HeadWaiter = 1,
            Waiter = 2,
            Runner = 3
        }
        #endregion


        #region // Data members for Role
        protected RoleType roleval;
        protected string description;
        #endregion


        #region
        // Properties for encapsulation
        public RoleType RoleValue
        {
            get { return roleval; }
            set { roleval = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region // Default constructor
        public Role()
        {
            roleval = RoleType.NoRole;
            description = "No Role";
        }
        #endregion

        #region // Overridable Payment methods
        public virtual double Payment()
        {
            return 0;
        }

        public virtual double Payment(double tipsOrShifts)
        {
            return 0;
        }
        #endregion
    }
}
