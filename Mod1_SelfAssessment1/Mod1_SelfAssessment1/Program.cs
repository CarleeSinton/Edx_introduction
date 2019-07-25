using System;

namespace Mod1_SelfAssessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Information Data
            string sFirstName = "";
            string sLastName = "";
            DateTime sBirthDate;
            string sAddress1 = "";
            string sAddress2 = "";
            string sCity = "";
            string sState = "";
            string sZip = "";
            string sCountry = "";

            //teacher information
            string tFirstName = "";
            string tLastName = "";
            DateTime tBirthDate;
            string tAddress1 = "";
            string tAddress2 = "";
            string tCity = "";
            string tState = "";
            string tZip = "";
            string tCountry = "";

            //UProgram Informaiton
            string programName = "";
            string departmentHead = "";
            string degrees = "";

            //Degree Information
            string degreeName = "";
            int creditsReq = 0;

            //Course Information
            string courseName = "";
            int credits = 0;
            int weeks = 0;
            string teacher = "";

            //ASSIGNING VALUE
            //Student Information Data
            sFirstName = "C";
            sLastName = "S";
            sBirthDate = new DateTime(1932, 6, 1);
            sAddress1 = "100 main street";
            sAddress2 = "";
            sCity = "Vancouver";
            sState = "Washington";
            sZip = "12345";
            sCountry = "USA";

            //teacher information
            tFirstName = "S";
            tLastName = "S";
            tBirthDate = new DateTime(1839, 8, 8);
            tAddress1 = "1234 second street";
            tAddress2 = "";
            tCity = "Vancouver";
            tState = "B.C.";
            tZip = "53212";
            tCountry = "Canada";

            //UProgram Informaiton
            programName = "Learn to Code";
            departmentHead = "JJ";
            degrees = "blah blah blah";

            //Degree Information
            degreeName = "Coding";
            creditsReq = 45;

            //Course Information
            courseName = "Step 1";
            credits++;
            weeks = 7;
            teacher = "SS";

            Console.WriteLine("Student Information: ");
            Console.WriteLine(sFirstName + " " + sLastName);
            Console.WriteLine($"Born on {sBirthDate}");
            Console.WriteLine(sAddress1 + " " + sAddress2 + " " + sCity + " " + sState + " " + sCountry + " " + sZip);

            Console.WriteLine("Teacher Information: ");
            Console.WriteLine(tFirstName + " " + tLastName);
            Console.WriteLine($"Born on {tBirthDate}");
            Console.WriteLine(tAddress1 + " " + tAddress2 + " " + tCity + " " + tState + " " + tCountry + " " + tZip);
        }
    }
}