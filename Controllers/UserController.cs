using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using GE = GlobalEntity;

namespace UserDetail_.net_project.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserBC userBC;
        public UserController(IUserBC userBC)
        {
            this.userBC = userBC;
        }
        public IActionResult Index()
        {new List<GE::User>();
            List<GE::User> users = this.userBC.GetUsers();
            return View(users);
        }
    }
}
