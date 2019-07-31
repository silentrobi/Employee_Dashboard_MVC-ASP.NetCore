using EmployeeDashboard.Models;
using EmployeeDashboard.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDashboard.Controllers
{
    //Handle HTTP requests and responses
    // methods of a controll class is called action methods that perform actions. 

    // Home Prefix is mapped to url
    //ex:  https://localhost/home/index
    // here home is prefix of HomeController and index is the method/ action of the controller HomeController

    //[Route("Home")]
    [Route("[controller]/[action]")] // token technique.
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository; // readonly prevent accidently assigning 
                                                                  //another value in that variable

        // dependency injection of IEmployeeRepository makes loosly coupling with MockEmployeeReposity 
        // Benifits of dependency injection : 1. Loosly coupling between classes and 2. Easy to unit test.
        public HomeController(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }
        // note the controller route template is not combined with action method route template if the route
        //on the action method begins with / or ~/
        [Route("~/Home")]
        //[Route("[action]")] // alaways covert to lower case. not case sensetive
        [Route("~/")] // default gateway
                      //here [action] toekn won't work so explicitly define it.
        [Route("~/Home/Index")]
        //[Route("~/Home")]
        public string Index() {
            return "Deafult Action";
        }

        //[Route("[action]")]
        public ViewResult  AllEmployees() {

            var _model = _employeeRepository.GetAllEmployees();
            //return View(_model); // by defult ssystem look for view file name AllEmployee.cshtml same name as action method.
            // If we change name of action method then system we have to specify the view file name
            return View("~/Views/Home/AllEmployees.cshtml", _model);

        }
        // To return Json Data: Json(model): explicitely
        /*public JsonResult Details()
        {
         {
            Employee model = _employeeRepository.GetEmployee(1);
            return Json(model);
        }
         */
        // to return xml or json data, use ObjectResult type
        // we can use it for developing API.  In case of API we don't have View 
        /* public ObjectResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return new ObjectResult(model);
        }
        */
        // to generate view for client
        //[Route("[action]/{Id?}")]
        [Route("{Id?}")]
        public ViewResult Details(int? Id) // ? makes nullable integer
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
                Employee = _employeeRepository.GetEmployee(Id??1), // if id is null then use default value 1
                PageTitle = "Employee Details"
                
            };
            //return View(model); // by default it will look for Details.cshtml file.
            ViewBag.PageTitle = "Employee detail";
            //ViewBag.Employee = model;
            return View(homeDetailsViewModel); // view path can be absolute or relative. see tutorial video
                           //Three ways to pass data to view: 1. ViewData, 2.ViewBag, and 3.strongly typed view
                           //Both  ViewData, and  ViewBag are loosly typed view. Resolved dynamically at runtime. 
                           //No compile time type checking and intellisence. ViewData needs casting the data type.
                           // preferred method is strongly typed view.

        }
    }
}
//shortcut: (ctrl+ shift + space) to show overloaded methods.
// (ctrl + .) auto fill 