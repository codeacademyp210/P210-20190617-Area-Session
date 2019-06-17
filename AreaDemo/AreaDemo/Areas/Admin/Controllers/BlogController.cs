using AreaDemo.Models;
using System.Linq;
using System.Web.Mvc;

namespace AreaDemo.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        NeviaEntities db = new NeviaEntities();
        // GET: Admin/Blog
        public ActionResult Index()
        {

            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                return View(db.Blogs.ToList());
            }
            return RedirectToAction("Index", "Login");
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