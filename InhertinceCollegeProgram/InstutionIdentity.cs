using System;
using System.Collections.Generic;
using System.Text;

namespace InhertinceCollegeProgram
{
    public abstract class InstutionIdentity
    {
        #region
        private string _idNo,_name,_principalSign;
        //telescopic constructor
        public InstutionIdentity(string idNo)
        {
            this._idNo = idNo;
        }
        public InstutionIdentity(string idNo, string name) : this(idNo)
        {
            this._name = name;
        }
        public InstutionIdentity(string idNo, string name, string principalSign) : this(idNo, name)
        {
            this._principalSign = principalSign;
        }
    
    }
#endregion
}
