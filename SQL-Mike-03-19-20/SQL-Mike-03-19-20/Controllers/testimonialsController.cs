using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using SQL_Mike_03_19_20.Migrations;
using SQL_Mike_03_19_20.Models;

namespace SQL_Mike_03_19_20.Controllers
{
	public class testimonialsController : Controller
	{
		private ApplicationDbContext db = new ApplicationDbContext();

		// GET: testimonials
		public ActionResult Index()
		{
			return View(db.Testimonials.ToList());
		}

		// GET: testimonials/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			testimonial testimonial = db.Testimonials.Find(id);
			if (testimonial == null)
			{
				return HttpNotFound();
			}
			return View(testimonial);
		}

		// GET: testimonials/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: testimonials/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
	//	[ValidateAntiForgeryToken]
		public ActionResult Create(testimonial testimonial)
		{

			


			db.Testimonials.Add(testimonial);
			db.SaveChanges();
			return RedirectToAction("Index");







		}

		
		public int createByNumber(int amount)
		{


			//add a foreach loop in to and save the t's the the db





			for (var i = 0; i < amount; i++)
			{

				var t = new testimonial();
				t.Author = i.ToString();
				t.Added = DateTime.Now;
				db.Testimonials.Add(t);
				db.SaveChanges();



			}

			return (amount);


		}



		//trying to work out a way of adding multiple testimonials until the amount added equals the number selected on the view




		// GET: testimonials/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			testimonial testimonial = db.Testimonials.Find(id);
			if (testimonial == null)
			{
				return HttpNotFound();
			}
			return View(testimonial);
		}

		// POST: testimonials/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "ID,Author,Content,Added")] testimonial testimonial)
		{
			if (ModelState.IsValid)
			{
				db.Entry(testimonial).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(testimonial);
		}



		// GET: testimonials/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			testimonial testimonial = db.Testimonials.Find(id);
			if (testimonial == null)
			{
				return HttpNotFound();
			}
			return View(testimonial);
		}

		// POST: testimonials/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			testimonial testimonial = db.Testimonials.Find(id);
			db.Testimonials.Remove(testimonial);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
