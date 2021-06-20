using _17bangMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Write()
        {

            ProfileModel model = new ProfileModel
            {
                Constellations = new List<Constellation>
                {
                    new Constellation { Id = 1, Content = "宝瓶座" },
                    new Constellation { Id = 2, Content = "双鱼座" },
                    new Constellation { Id = 3, Content = "牡羊座" },
                    new Constellation { Id = 4, Content = "金牛座" },
                    new Constellation { Id = 5, Content = "双子座" },
                    new Constellation { Id = 6, Content = "巨蟹座" },
                    new Constellation { Id = 7, Content = "狮子座" },
                    new Constellation { Id = 8, Content = "处女座" },
                    new Constellation { Id = 9, Content = "天平座" },
                    new Constellation { Id = 10, Content = "天蝎座" },
                    new Constellation { Id = 11, Content = "人马座" },
                    new Constellation { Id = 12, Content = "山羊座" }
                },
                BirthYears = new List<BirthYear>
                {
                    new BirthYear { Id = 1, Year = 1991 },
                    new BirthYear { Id = 2, Year = 1992 },
                    new BirthYear { Id = 3, Year = 1993 },
                    new BirthYear { Id = 4, Year = 1994 },
                    new BirthYear { Id = 5, Year = 1995 },
                    new BirthYear { Id = 6, Year = 1996 },
                    new BirthYear { Id = 7, Year = 1997 },
                    new BirthYear { Id = 8, Year = 1998 },
                    new BirthYear { Id = 9, Year = 1999 },
                    new BirthYear { Id = 10, Year =2000},
                }

            };
            return View(model);
        }
    }
}