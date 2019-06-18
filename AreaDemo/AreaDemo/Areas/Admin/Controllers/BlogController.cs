using AreaDemo.Helpers;
using AreaDemo.Models;
using System.Linq;
using System.Web.Mvc;

namespace AreaDemo.Areas.Admin.Controllers
{

    [Auth]
    public class BlogController : Controller
    {
        NeviaEntities db = new NeviaEntities();
        // GET: Admin/Blog
        public ActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            AdminUser user = Session["User"] as AdminUser;
            if ( user.Level != 0 )
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Edit(int Id)
        {
            Blog blog = db.Blogs.FirstOrDefault(b => b.Id == Id);
            if (blog != null)
            {
                return View(blog);
            }
            return HttpNotFound();
        }
    }
}