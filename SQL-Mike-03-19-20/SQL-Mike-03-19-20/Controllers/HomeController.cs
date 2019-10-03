using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SQL_Mike_03_19_20.Models;

namespace SQL_Mike_03_19_20.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(testimonial t)
		{
			//using (var db = new SQL_Mike_03_19_20.Models.ApplicationDbContext())
			//{

				
			//	db.Testimonials.Add(t);
			//	db.SaveChanges();


				
			//}
			return View();
		}

		public ActionResult Create(testimonial t)
		{
			using (var db = new SQL_Mike_03_19_20.Models.ApplicationDbContext())
			{

				db.Testimonials.Add(t);
				db.SaveChanges();

				var testimonials = db.Testimonials.Count();

				return View(testimonials);
			}


		}

	}
}