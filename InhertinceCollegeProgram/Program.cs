using System;

namespace InhertinceCollegeProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            StudentsIdCard studentdata = new StudentsIdCard("pcmb01", "ravi", "pcmb", "principalsign", "ravisign");
            TeachersIdCard teachersdata = new TeachersIdCard("science", "gopalsign", "Gopal", "Science01", "principalsign");
            StaffIdCard staffdata = new StaffIdCard("staff01", "sharath", "principalsign", "helper", "sharathsign");
            GuestIdCard guestdata = new GuestIdCard("ravi", "father", "santhoshsign", "guest01", "santhosh", "principalsign");

        }
    
    }
}

