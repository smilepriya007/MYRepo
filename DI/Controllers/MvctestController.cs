using DI.App_Start;
using DI.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DI.App_Start.NinjectWebCommon;

namespace DI.Controllers
{
    public class MvctestController : Controller
    {
        private readonly IRepo _repo;


        public MvctestController(IRepo repo)
        {
            _repo = repo;
        }
        public ActionResult Index()
        {
            string res = _repo.Message();
            return View();
        }
    }
}