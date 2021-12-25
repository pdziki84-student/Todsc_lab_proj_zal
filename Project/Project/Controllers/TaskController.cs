using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Services;
using Project.ViewModel;

namespace Project.Controllers
{
    public class TaskController : Controller
    {
        private TaskListService _taskListService;

        public TaskController(TaskListService taskListService)
        {
            _taskListService = taskListService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Add(NewTaskViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            _taskListService.Add(data.Title, data.Desc);
            return RedirectToAction("Index", "Home");
        }
    }
}
