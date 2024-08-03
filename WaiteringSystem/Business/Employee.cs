using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiteringSystem;

namespace WaiteringSystem.Business
{
    internal class Employee : Person
    {
        #region // Data members for Employee
        private string employeeID;
        private Role role;
        #endregion

        #region // Properties for encapsulation
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public Role Role
        {
            get { return role; }
            set { role = value; }
        }
        #endregion

        #region // Parameterized constructor with role assignment
        public Employee(string id, string name, string phone, string employeeID, Role.RoleType roleValue) : base(id, name, phone)
        {
            this.employeeID = employeeID;

            // Assign role based on roleValue
            switch (roleValue)
            {
                case Role.RoleType.NoRole:
                    role = new Role();
                    break;
                case Role.RoleType.HeadWaiter:
                    role = new HeadWaiter();
                    break;
                case Role.RoleType.Waiter:
                    role = new Waiter();
                    break;
                case Role.RoleType.Runner:
                    role = new Runner();
                    break;
            }
        }
        #endregion

        #region // Override ToString to include Employee details
        public override string ToString()
        {
            return $"{base.ToString()}, EmployeeID: {employeeID}, Role: {role.Description}";
        }
        #endregion 
    }
}
