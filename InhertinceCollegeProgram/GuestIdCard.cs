using System;
using System.Collections.Generic;
using System.Text;

namespace InhertinceCollegeProgram
{
    class GuestIdCard : InstutionIdentity
    {
        string _studentName, _relationship, _guestSign;
        public void show() { }
        public void hide() { }
        public GuestIdCard(string studentname, string relationship, string guestsign, string idNo, string name, string principalSign) : base(idNo, name, principalSign)
        {
            this._studentName = studentname;
            this._relationship = relationship;
            this._guestSign = guestsign;
        }
    }
}
