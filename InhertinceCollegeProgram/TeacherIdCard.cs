using System;
using System.Collections.Generic;
using System.Text;

namespace InhertinceCollegeProgram
{
    public class TeacherIdCard : InstutionIdentity
    {
        string _branch, _teachersSign;
        public void show() { }
        public void Hide() { }
        public void LibraryAccess() { }

        public TeacherIdCard(string branch, string teacherSign, string name, string idNo, string principalSign) : base(idNo, name, principalSign)
        {
            this._branch = branch;
            this._teachersSign = teacherSign;
        }
    }

}

