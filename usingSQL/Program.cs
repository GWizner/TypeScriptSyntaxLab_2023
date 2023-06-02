using Microsoft.EntityFrameworkCore;
namespace DataExample
{
    public class Program
    {

        public static void Main(string[] args)
        {
            using (var demoContext = new ExampleDataContext())
            {
                 
            }

            using (var demoContext = new ExampleDataContext())
            {
                var noEmployees = demoContext.Employee.Count();
                Console.WriteLine($"{noEmployees}");
            }
        }
    }

    public class ExampleDataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ExampleDataContext()
        {

        }


        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:grandcircus-2022april.database.windows.net,1433;Initial Catalog=database2;Persist Security Info=False;User ID=Ahbc2022April2@davidluxfordoutlook.onmicrosoft.com;Password=ElectricKoala-Bear96;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Authentication=\"Active Directory Password\"");
            }
        }
    }
    public class Employee
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ID { get; set; }
        public string SSN { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
}