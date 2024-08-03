using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem
{
    public class Person
    {
        #region  // Fields for Person class
        private string id;
        private string name;
        private string phone;
        #endregion

        // Abstract class characteristics:
        // 1. Cannot be instantiated directly.
        // 2. Can contain abstract methods that must be implemented in derived classes.
        // 3. Allows shared functionality and forces derived classes to implement specific methods.

        #region // Properties for encapsulation
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        #endregion


        #region // Default constructor
        public Person()
        {
            id = string.Empty;
            name = string.Empty;
            phone = string.Empty;
        }
        #endregion

        #region
        // Parameterized constructor
        public Person(string id, string name, string phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }
        #endregion

        #region
        // Overridable ToString method to display person details
        public override string ToString()
        {
            return $"Name: {name}, Phone: {phone}";
        }
        #endregion
    }
}
