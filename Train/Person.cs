using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Person {
        private string firstName;
        private string lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public Person(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString() {
            return FirstName + " " + LastName;
        }
    }
}
