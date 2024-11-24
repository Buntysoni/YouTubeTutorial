using Microsoft.AspNetCore.Mvc;
using UNLEIN.Utilities;

namespace YouTubeTutorial.Controllers
{
    public class TrickController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Employees = EmployeeList().ToList().ToHtml();

            //advance trick of string
            string abc = "abcdefghijklmnopqwxyz";
            string aaa = abc.Between('f', 'm').Get();
            string ccc = abc.Between('f', 'm').Remove();


            string block = "Lorem Ipsum is simply dummy text texting texted text textarea of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            string textblock = block.Replace("text", "bunty");
            string textblocknew = block.SafeReplace("text", "bunty");
            return View();
        }
        
        public IActionResult JsonIndex()
        {
            var data = EmployeeList().ToList().ToJson();
            return Ok(data);
        }

        private List<Employee> EmployeeList()
        {
            List<Employee> lstemployees = new List<Employee>
            {
                new Employee(1, "John", "Doe", "john.doe@example.com", "+1234567890", "USA"),
                new Employee(2, "Jane", "Smith", "jane.smith@example.com", "+1234567891", "Canada"),
                new Employee(3, "Alice", "Johnson", "alice.johnson@example.com", "+1234567892", "UK"),
                new Employee(4, "Bob", "Brown", "bob.brown@example.com", "+1234567893", "Australia"),
                new Employee(5, "Charlie", "Davis", "charlie.davis@example.com", "+1234567894", "Germany"),
                new Employee(6, "David", "Martinez", "david.martinez@example.com", "+1234567895", "Mexico"),
                new Employee(7, "Eve", "Garcia", "eve.garcia@example.com", "+1234567896", "France"),
                new Employee(8, "Frank", "Wilson", "frank.wilson@example.com", "+1234567897", "Italy"),
                new Employee(9, "Grace", "Moore", "grace.moore@example.com", "+1234567898", "Spain"),
                new Employee(10, "Hannah", "Taylor", "hannah.taylor@example.com", "+1234567899", "Netherlands"),
                new Employee(11, "Isabelle", "Anderson", "isabelle.anderson@example.com", "+1234567900", "Belgium"),
                new Employee(12, "Jack", "Thomas", "jack.thomas@example.com", "+1234567901", "Sweden"),
                new Employee(13, "Kelly", "Jackson", "kelly.jackson@example.com", "+1234567902", "USA"),
                new Employee(14, "Liam", "White", "liam.white@example.com", "+1234567903", "Australia"),
                new Employee(15, "Megan", "Harris", "megan.harris@example.com", "+1234567904", "Canada"),
                new Employee(16, "Noah", "Clark", "noah.clark@example.com", "+1234567905", "Mexico"),
                new Employee(17, "Olivia", "Lewis", "olivia.lewis@example.com", "+1234567906", "Germany"),
                new Employee(18, "Paul", "Young", "paul.young@example.com", "+1234567907", "France"),
                new Employee(19, "Quinn", "Walker", "quinn.walker@example.com", "+1234567908", "Italy"),
                new Employee(20, "Rachel", "Hall", "rachel.hall@example.com", "+1234567909", "Spain"),
                new Employee(21, "Steve", "Allen", "steve.allen@example.com", "+1234567910", "USA"),
                new Employee(22, "Tina", "Scott", "tina.scott@example.com", "+1234567911", "Canada"),
                new Employee(23, "Ursula", "Adams", "ursula.adams@example.com", "+1234567912", "Germany"),
                new Employee(24, "Victor", "King", "victor.king@example.com", "+1234567913", "UK"),
                new Employee(25, "Wendy", "Baker", "wendy.baker@example.com", "+1234567914", "France"),
                new Employee(26, "Xander", "Gonzalez", "xander.gonzalez@example.com", "+1234567915", "Australia"),
                new Employee(27, "Yara", "Martinez", "yara.martinez@example.com", "+1234567916", "Mexico"),
                new Employee(28, "Zach", "Perez", "zach.perez@example.com", "+1234567917", "Spain"),
                new Employee(29, "Alice", "Taylor", "alice.taylor@example.com", "+1234567918", "Canada"),
                new Employee(30, "Bob", "Jones", "bob.jones@example.com", "+1234567919", "USA"),
                new Employee(31, "Catherine", "Davis", "catherine.davis@example.com", "+1234567920", "Italy"),
                new Employee(32, "Daniel", "Rodriguez", "daniel.rodriguez@example.com", "+1234567921", "Germany"),
                new Employee(33, "Ella", "Wright", "ella.wright@example.com", "+1234567922", "France"),
                new Employee(34, "Frank", "Brown", "frank.brown@example.com", "+1234567923", "Mexico"),
                new Employee(35, "Grace", "Miller", "grace.miller@example.com", "+1234567924", "Spain"),
                new Employee(36, "Henry", "Wilson", "henry.wilson@example.com", "+1234567925", "Australia"),
                new Employee(37, "Ivy", "Moore", "ivy.moore@example.com", "+1234567926", "UK"),
                new Employee(38, "Jack", "Jackson", "jack.jackson@example.com", "+1234567927", "USA"),
                new Employee(39, "Katie", "Hernandez", "katie.hernandez@example.com", "+1234567928", "Canada"),
                new Employee(40, "Leo", "Gonzalez", "leo.gonzalez@example.com", "+1234567929", "Mexico"),
                new Employee(41, "Mona", "Lopez", "mona.lopez@example.com", "+1234567930", "Germany"),
                new Employee(42, "Nina", "Martinez", "nina.martinez@example.com", "+1234567931", "France"),
                new Employee(43, "Oscar", "Perez", "oscar.perez@example.com", "+1234567932", "Spain"),
                new Employee(44, "Paul", "Young", "paul.young@example.com", "+1234567933", "Australia"),
                new Employee(45, "Quincy", "Evans", "quincy.evans@example.com", "+1234567934", "USA"),
                new Employee(46, "Rachel", "Nelson", "rachel.nelson@example.com", "+1234567935", "Canada"),
                new Employee(47, "Sam", "White", "sam.white@example.com", "+1234567936", "UK"),
                new Employee(48, "Tina", "Allen", "tina.allen@example.com", "+1234567937", "Germany"),
                new Employee(49, "Ursula", "Walker", "ursula.walker@example.com", "+1234567938", "Mexico"),
                new Employee(50, "Vince", "Clark", "vince.clark@example.com", "+1234567939", "Australia"),
                new Employee(51, "Will", "Thomas", "will.thomas@example.com", "+1234567940", "Canada"),
                new Employee(52, "Xander", "Evans", "xander.evans@example.com", "+1234567941", "France"),
                new Employee(53, "Yasmine", "Roberts", "yasmine.roberts@example.com", "+1234567942", "Germany"),
                new Employee(54, "Zara", "Baker", "zara.baker@example.com", "+1234567943", "Spain"),
                new Employee(55, "Adam", "Brown", "adam.brown@example.com", "+1234567944", "Italy"),
                new Employee(56, "Ben", "Davis", "ben.davis@example.com", "+1234567945", "USA"),
                new Employee(57, "Chloe", "Harris", "chloe.harris@example.com", "+1234567946", "Canada"),
                new Employee(58, "Daniel", "Jackson", "daniel.jackson@example.com", "+1234567947", "Australia"),
                new Employee(59, "Eva", "Lee", "eva.lee@example.com", "+1234567948", "France"),
                new Employee(60, "Fred", "Miller", "fred.miller@example.com", "+1234567949", "Germany"),
                new Employee(61, "George", "Martinez", "george.martinez@example.com", "+1234567950", "Mexico"),
                new Employee(62, "Holly", "Moore", "holly.moore@example.com", "+1234567951", "Italy"),
                new Employee(63, "Iris", "Wright", "iris.wright@example.com", "+1234567952", "UK"),
                new Employee(64, "Jack", "Taylor", "jack.taylor@example.com", "+1234567953", "Canada"),
                new Employee(65, "Kim", "Clark", "kim.clark@example.com", "+1234567954", "Germany"),
                new Employee(66, "Laura", "Wilson", "laura.wilson@example.com", "+1234567955", "Mexico"),
                new Employee(67, "Mike", "Walker", "mike.walker@example.com", "+1234567956", "Australia"),
                new Employee(68, "Nina", "Hernandez", "nina.hernandez@example.com", "+1234567957", "France"),
                new Employee(69, "Oscar", "Gonzalez", "oscar.gonzalez@example.com", "+1234567958", "Spain"),
                new Employee(70, "Paul", "Evans", "paul.evans@example.com", "+1234567959", "Canada"),
                new Employee(71, "Quinn", "Roberts", "quinn.roberts@example.com", "+1234567960", "Germany"),
                new Employee(72, "Rachel", "Lopez", "rachel.lopez@example.com", "+1234567961", "USA"),
                new Employee(73, "Sam", "Taylor", "sam.taylor@example.com", "+1234567962", "Mexico"),
                new Employee(74, "Tina", "Young", "tina.young@example.com", "+1234567963", "Australia"),
                new Employee(75, "Ursula", "Nelson", "ursula.nelson@example.com", "+1234567964", "Canada"),
                new Employee(76, "Vera", "Thomas", "vera.thomas@example.com", "+1234567965", "Germany"),
                new Employee(77, "Will", "Jackson", "will.jackson@example.com", "+1234567966", "Mexico"),
                new Employee(78, "Xander", "Brown", "xander.brown@example.com", "+1234567967", "France"),
                new Employee(79, "Yasmine", "Miller", "yasmine.miller@example.com", "+1234567968", "UK"),
                new Employee(80, "Zara", "Davis", "zara.davis@example.com", "+1234567969", "USA"),
                new Employee(81, "Adam", "Gonzalez", "adam.gonzalez@example.com", "+1234567970", "Canada"),
                new Employee(82, "Bea", "Hernandez", "bea.hernandez@example.com", "+1234567971", "Australia"),
                new Employee(83, "Carl", "Moore", "carl.moore@example.com", "+1234567972", "Germany"),
                new Employee(84, "Dora", "Lee", "dora.lee@example.com", "+1234567973", "Mexico"),
                new Employee(85, "Ella", "Adams", "ella.adams@example.com", "+1234567974", "France"),
                new Employee(86, "Fiona", "Evans", "fiona.evans@example.com", "+1234567975", "Spain"),
                new Employee(87, "Gabe", "Roberts", "gabe.roberts@example.com", "+1234567976", "UK"),
                new Employee(88, "Holly", "Gonzalez", "holly.gonzalez@example.com", "+1234567977", "Australia"),
                new Employee(89, "Iris", "Parker", "iris.parker@example.com", "+1234567978", "Mexico"),
                new Employee(90, "Jack", "Martinez", "jack.martinez@example.com", "+1234567979", "France"),
                new Employee(91, "Kris", "Moore", "kris.moore@example.com", "+1234567980", "USA"),
                new Employee(92, "Liam", "Johnson", "liam.johnson@example.com", "+1234567981", "Germany"),
                new Employee(93, "Maggie", "Taylor", "maggie.taylor@example.com", "+1234567982", "Mexico"),
                new Employee(94, "Nathan", "Lee", "nathan.lee@example.com", "+1234567983", "Canada"),
                new Employee(95, "Olivia", "Brown", "olivia.brown@example.com", "+1234567984", "USA"),
                new Employee(96, "Peter", "Gonzalez", "peter.gonzalez@example.com", "+1234567985", "UK"),
                new Employee(97, "Quinn", "Walker", "quinn.walker@example.com", "+1234567986", "Germany"),
                new Employee(98, "Rose", "Jackson", "rose.jackson@example.com", "+1234567987", "Spain"),
                new Employee(99, "Steve", "Roberts", "steve.roberts@example.com", "+1234567988", "France"),
                new Employee(100, "Tina", "Lopez", "tina.lopez@example.com", "+1234567989", "Australia")
            };
            return lstemployees;
        }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }

        public Employee(int employeeID, string firstName, string lastName, string email, string phoneNumber, string country)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Country = country;
        }
    }
}
