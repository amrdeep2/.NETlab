using System.Diagnostics;
using lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var vm = new Lab2ViewModel
            {
                Header = "About Me",
                FullName = "Amardeep Sandhu",
                StudentNumber = "041110789",
                StudentEmailMasked = "sand0411@algonquinlive.com",
                AboutParagraph =
                    "I am a Computer Engineering Technology – Computing Science student who enjoys building practical software projects and learning modern web technologies.",
                CourseExpectationsParagraph =
                    "From this course, I expect to learn how ASP.NET Core MVC applications are structured using models, views, and controllers, and how to deploy a web application to Azure."
            };

            vm.QuestionsAndAnswers = new List<QaItem>
            {
                new() { Question = "1. Is C# a strongly or loosely typed language? Why?",
                        Answer = "C# is strongly typed because variables have specific types enforced by the compiler." },

                new() { Question = "2. Is C# declarative or imperative? Why?",
                        Answer = "C# is mainly imperative because it uses step-by-step instructions to change program state." },

                new() { Question = "3. Explain anonymous types in C#, why we use them, and give an example.",
                        Answer = "Anonymous types are temporary compiler-generated types created using new { }. Example: var x = new { Name = \"Amardeep\", Age = 20 };" },

                new() { Question = "4. What is the difference between a Value Type and a Reference type?",
                        Answer = "Value types store data directly and are copied on assignment; reference types store references to objects in memory and assignments copy the reference." },

                new() { Question = "5. What is a ‘Property’ in C# as it relates to classes and objects?",
                        Answer = "A property is a member that provides controlled access to data through get and set accessors." },

                new() { Question = "6. Describe the MVC design pattern. Explain its components.",
                        Answer = "MVC separates an app into Model (data), View (UI), and Controller (request handling) to improve structure and maintainability." },

                new() { Question = "7. Describe the purpose of the Program.cs class in this project.",
                        Answer = "Program.cs is the entry point that configures services and middleware and starts the web application." },

                new() { Question = "8. MVC Core applications can ‘host’ themselves: true or false.",
                        Answer = "True. ASP.NET Core can self-host using the Kestrel web server." },

                new() { Question = "9. Explain what happens in memory when we make a value type nullable.",
                        Answer = "A nullable value type stores the value plus a boolean flag indicating whether a value exists (HasValue)." },

                new() { Question = "10. Explain implicit types and why we use them and give an example.",
                        Answer = "Implicit types use var so the compiler infers the type. Example: var total = 10;" },

                new() { Question = "11. Explain Git flow and why we use it.",
                        Answer = "Git flow is a branching strategy that helps manage features, releases, and hotfixes in a structured way." },

                new() { Question = "12. Explain dependency injection and why we use it?",
                        Answer = "Dependency injection provides dependencies from outside a class to reduce coupling and improve testability and maintenance." }
            };

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
