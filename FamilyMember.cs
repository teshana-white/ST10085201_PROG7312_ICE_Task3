using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_3_Trees
{
    public class FamilyMember
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public bool VitalStatus { get; set; }

        public FamilyMember(string name, DateTime dob, bool vitalStatus)
        {
            Name = name;
            DOB = dob;
            VitalStatus = vitalStatus;
        }
    }
}
