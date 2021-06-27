using System;

namespace InhertinceCollegeProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            StudentIdCard studentdata = new StudentIdCard("pcmb01", "ravi", "pcmb", "principalsign", "ravisign");
            TeacherIdCard teacherdata = new TeacherIdCard("science", "gopalsign", "Gopal", "Science01", "principalsign");
            StaffIdCard staffdata = new StaffIdCard("staff01", "sharath", "principalsign", "helper", "sharathsign","computerscience");
            GuestIdCard guestdata = new GuestIdCard("ravi", "father", "santhoshsign", "guest01", "santhosh", "principalsign");
           
            

        }
    
    }
}

