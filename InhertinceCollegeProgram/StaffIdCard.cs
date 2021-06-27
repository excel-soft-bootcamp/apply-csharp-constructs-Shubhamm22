using System;
using System.Collections.Generic;
using System.Text;

namespace InhertinceCollegeProgram
{
    public class StaffIdCard:InstutionIdentity
    {
        string _designation,_department, _staffSign;
        public void Show() { }
        public void Hide() { }
        public StaffIdCard(string idNo,string name,string principalSign,string designation,string staffSign,string department):base(idNo,name,principalSign)
        {
            this._designation = designation;
            this._staffSign = staffSign;
            this._department = department;
        }
        
    }
}
