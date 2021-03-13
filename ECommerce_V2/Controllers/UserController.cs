using Microsoft.AspNetCore.Mvc;
using V2.DAL.DB_Context;
using V2.DAL.Models;

namespace V2.Website.Controllers
{
    public class UserController : Controller
    {

        private readonly UnitOfWork unitOfWork;


        public IActionResult Index()
        {
            return View();
        }

        // GET: /user/Details/5
        public ViewResult Details(int id)
        {
            User user = unitOfWork.Users.FindById(id);
            return View(user);
        }

        // GET: /user/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}
