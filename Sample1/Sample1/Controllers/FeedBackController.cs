using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sample.Controllers
{
    using Repository;
    using DataModel;

    public class FeedBackController : Controller
    {
        private readonly IFeedBackReposistory _feedBack;
        public FeedBackController(IFeedBackReposistory feedBack)
        {
            _feedBack = feedBack;
        }

        // GET: FeedBack/Create
        public IActionResult Index()
        {
            return View(new FeedBack());
        }

        // POST: FeedBack/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(FeedBack model)
        {
            if (ModelState.IsValid)
            {
                _feedBack.AddFeedBack(model);
                return RedirectToAction("FeedBackComplete");
            }
            return View(model);
        }

        public IActionResult FeedBackComplete()
        {
            return View();
        }
    }
}