using System;
using System.Collections.Generic;
using System.Text;

namespace InhertinceCollegeProgram
{
  
    //StudentIdCard is-a CollegeIdentity
    public class StudentIdCard:InstutionIdentity
    {
        string _branch, _studentSign;
        public void Show() { }
        public void Hide() { }
        public void LibraryAccess() { }
        public StudentIdCard(string idNo,string name, string branch, string principalSign,  string studentsSign) :base(idNo,name,principalSign)

        {    
            this._branch = branch;
            this._studentSign = studentsSign;
        }


    }
    
}

