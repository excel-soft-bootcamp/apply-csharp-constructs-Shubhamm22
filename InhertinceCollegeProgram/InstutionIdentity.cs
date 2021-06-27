using System;
using System.Collections.Generic;
using System.Text;

namespace InhertinceCollegeProgram
{
    public abstract class InstutionIdentity
    {
        #region
        private string _idNo,_name,_principalSign;
      
        
        public InstutionIdentity(string idNo, string name, string principalSign) 
        {
            this._idNo = idNo;
            this._name = name;
            this._principalSign = principalSign;
        }
    
    }
#endregion
}
