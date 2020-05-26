using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT1___Control_Workspace
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ProfType { get; set; }

        public Customer(string name, string surname, string eMail, string profType)
        {
            Name = name;
            Surname = surname;
            Email = eMail;
            ProfType = profType;   
        }

        public override string ToString()
        {
            return $"{Name} {Surname} - {Email} - {ProfType}";
        }

    }
}
