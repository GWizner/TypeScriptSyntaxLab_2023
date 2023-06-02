using Microsoft.AspNetCore.Mvc;

namespace MVC7_18_22.Controllers
{
    public class ApiController : Controller
    {
        private readonly RecordStoreContext recordStoreContext;
        public ApiController(RecordStoreContext newRecordStoreContext)
        {
            recordStoreContext = newRecordStoreContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public Employee GetEmployees()
        {
            var newEmployee = new Employee();
            newEmployee.FirstName = "Dominion";
            newEmployee.LastName = "Wizner";
            newEmployee.ID = 15;
            return newEmployee;
        }

        public int GetNoEmployees()
        {
            return recordStoreContext.Employee.Count();
        }
        public Employee[] GetAllEmployees()
        {
            return recordStoreContext.Employee.ToArray();
        }

        public string ExampleString()
        {
            return "This right here!!";
        }

        [HttpPost]
        public void ChangeLastName(int targetId, string newLastName)
        {
            Employee targetEmployee = null;
            foreach (var currEmployeeRecord in recordStoreContext.Employee)
            {
                if (currEmployeeRecord.ID == targetId)
                {
                    targetEmployee = currEmployeeRecord;
                    break;
                }
            }
            if (targetEmployee != null)
            {
                targetEmployee.LastName = newLastName;
                recordStoreContext.SaveChanges();
            }
            else
            {
                throw new Exception($"Could not find an employee with ID {targetId}");
            }
        }
    }

}
