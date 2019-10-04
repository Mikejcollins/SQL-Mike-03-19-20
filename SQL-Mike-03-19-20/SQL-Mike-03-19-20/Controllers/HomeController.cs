using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using SQL_Mike_03_19_20.Migrations;
using SQL_Mike_03_19_20.Models;

namespace SQL_Mike_03_19_20.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(testimonial t)
		{
			using (var db = new SQL_Mike_03_19_20.Models.ApplicationDbContext())
			{


				db.Testimonials.Add(t);
				db.SaveChanges();

				


			}
			return View();
		}


		public ActionResult Author(string author,string content, string qoute)
		{
			if (String.IsNullOrEmpty(author) && string.IsNullOrEmpty(content) == false)
			{


				using (var db = new SQL_Mike_03_19_20.Models.ApplicationDbContext())
				{
					testimonial myt = new testimonial();
					myt.Author = author;
					myt.Content = content;
					db.Testimonials.Add(myt);


					db.SaveChanges();






				}


			}
			return View("Index");
		}


		public ActionResult gT()
		{

			gtViewModel t1 = new gtViewModel();
			t1.author = RandomString(60, false);
			t1.content = RandomString(500, false);
			return View(t1);
		}

		public ActionResult saveGt(string at, string ct)
		{
			using (var db = new ApplicationDbContext())
			{
				testimonial t1 = new testimonial();
				t1.Author = at;
				t1.Content = ct;

				db.Testimonials.Add(t1);

				db.SaveChanges();

				
				var listOfT = db.Testimonials.ToList();
				
				return View(listOfT);
			}
			
		}

		public string RandomString(int size, bool lowerCase)
		{
			StringBuilder builder = new StringBuilder();
			Random random = new Random();
			char ch;
			for (int i = 0; i < size; i++)
			{
				ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
				builder.Append(ch);
			}
			if (lowerCase)
				return builder.ToString().ToLower();
			return builder.ToString();
		}
		//public ActionResult(var db)
		//public ActionResult Create(testimonial t)
		//{
		//	using (var db = new SQL_Mike_03_19_20.Models.ApplicationDbContext())
		//	{

		//		db.Testimonials.Add(t);
		//		db.SaveChanges();

		//		var testimonials = db.Testimonials.Count();

		//		return View(testimonials);
		//	}


		//}

	}
}