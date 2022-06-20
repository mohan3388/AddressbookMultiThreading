using AddressBook;

namespace ContactDetailsTest
{
    [TestClass]
    public class ContactTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Contact> AddresDetails = new List<Contact>();
            AddresDetails.Add(new Contact(Firstname:"Rajesh", Lastname: "Verma", Address: "Bemetara", City:"Durg" ,State:"Chhattisgarh",Zip:490020,Phone:"7898625487",Email:"sahu@12gmail.com"));
            AddresDetails.Add(new Contact(Firstname: "Mukesh", Lastname: "Tiwari", Address: "Utai", City: "Durg", State: "Chhattisgarh", Zip: 490020, Phone: "7898625487", Email: "sahu@12gmail.com"));
            AddresDetails.Add(new Contact(Firstname: "Govind", Lastname: "Bhatt", Address: "Rajendra nagar", City: "Durg", State: "Chhattisgarh", Zip: 490020, Phone: "7898625487", Email: "sahu@12gmail.com"));
            AddresDetails.Add(new Contact(Firstname: "Vidya", Lastname: "yadav", Address: "", City: "Durg", State: "Chhattisgarh", Zip: 490020, Phone: "7898625487", Email: "sahu@12gmail.com"));
            AddOperation emppayroll = new AddOperation();
            DateTime StartDateTime = DateTime.Now;
            emppayroll.AddEmployee(AddresDetails);
            DateTime StopDateTimes = DateTime.Now;

            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));


            //DateTime StartDateTimeThread = DateTime.Now;
            //emppayroll.AddEmployeeThread(employeeDetails);
            //DateTime StopDateTimeThread = DateTime.Now;

            //Console.WriteLine("Duration with threads: " + (StopDateTimeThread - StartDateTimeThread));
        }
    }
}